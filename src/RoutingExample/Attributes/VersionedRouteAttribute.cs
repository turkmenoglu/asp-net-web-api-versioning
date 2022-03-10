using RoutingExample.Constraints;
using System;
using System.Collections.Generic;
using System.Web.Http.Routing;

namespace RoutingExample.Attributes
{
    public class VersionedRouteAttribute : RouteFactoryAttribute
    {
        private int _AllowedVersion;

        public VersionedRouteAttribute(string template, int allowedVersion)
            : base(template)
        {
            _AllowedVersion = allowedVersion;
        }

        public override IDictionary<String, Object> Constraints
        {
            get
            {
                var constraints = new HttpRouteValueDictionary();
                constraints.Add("version", new VersionConstraint(_AllowedVersion));

                return constraints;
            }
        }
    }
}