// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryCasLoadbalanceListenerResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryCasLoadbalanceListenerResponseBodyData> Data { get; set; }
        public class QueryCasLoadbalanceListenerResponseBodyData : TeaModel {
            [NameInMap("BackendServerPort")]
            [Validation(Required=false)]
            public long? BackendServerPort { get; set; }

            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public long? Bandwidth { get; set; }

            [NameInMap("CertificateIaasId")]
            [Validation(Required=false)]
            public string CertificateIaasId { get; set; }

            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public string CertificateId { get; set; }

            [NameInMap("Cookie")]
            [Validation(Required=false)]
            public string Cookie { get; set; }

            [NameInMap("CookieTimeout")]
            [Validation(Required=false)]
            public long? CookieTimeout { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EstablishedTimeout")]
            [Validation(Required=false)]
            public long? EstablishedTimeout { get; set; }

            [NameInMap("GmCryptoCertIaasId")]
            [Validation(Required=false)]
            public string GmCryptoCertIaasId { get; set; }

            [NameInMap("IaasId")]
            [Validation(Required=false)]
            public string IaasId { get; set; }

            [NameInMap("IaasType")]
            [Validation(Required=false)]
            public string IaasType { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("IsHealthMonitor")]
            [Validation(Required=false)]
            public string IsHealthMonitor { get; set; }

            [NameInMap("ListenerPort")]
            [Validation(Required=false)]
            public long? ListenerPort { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("PersistTimeout")]
            [Validation(Required=false)]
            public long? PersistTimeout { get; set; }

            [NameInMap("Scheduler")]
            [Validation(Required=false)]
            public string Scheduler { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StickySession")]
            [Validation(Required=false)]
            public string StickySession { get; set; }

            [NameInMap("StickySessionType")]
            [Validation(Required=false)]
            public string StickySessionType { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("UrlPath")]
            [Validation(Required=false)]
            public string UrlPath { get; set; }

            [NameInMap("XForwardedFor")]
            [Validation(Required=false)]
            public string XForwardedFor { get; set; }

            [NameInMap("HealthMonitor")]
            [Validation(Required=false)]
            public QueryCasLoadbalanceListenerResponseBodyDataHealthMonitor HealthMonitor { get; set; }
            public class QueryCasLoadbalanceListenerResponseBodyDataHealthMonitor : TeaModel {
                [NameInMap("CheckType")]
                [Validation(Required=false)]
                public string CheckType { get; set; }
                [NameInMap("ConnectPort")]
                [Validation(Required=false)]
                public long? ConnectPort { get; set; }
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }
                [NameInMap("HealthyThreshold")]
                [Validation(Required=false)]
                public long? HealthyThreshold { get; set; }
                [NameInMap("HttpMethod")]
                [Validation(Required=false)]
                public string HttpMethod { get; set; }
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public long? Interval { get; set; }
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public long? Timeout { get; set; }
                [NameInMap("UnHealthyThreshold")]
                [Validation(Required=false)]
                public long? UnHealthyThreshold { get; set; }
                [NameInMap("Uri")]
                [Validation(Required=false)]
                public string Uri { get; set; }
                [NameInMap("HealthCheckHttpCode")]
                [Validation(Required=false)]
                public List<string> HealthCheckHttpCode { get; set; }
            };

            [NameInMap("LoadBalancer")]
            [Validation(Required=false)]
            public QueryCasLoadbalanceListenerResponseBodyDataLoadBalancer LoadBalancer { get; set; }
            public class QueryCasLoadbalanceListenerResponseBodyDataLoadBalancer : TeaModel {
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }
                [NameInMap("AutoRenew")]
                [Validation(Required=false)]
                public bool? AutoRenew { get; set; }
                [NameInMap("AutoRenewPeriod")]
                [Validation(Required=false)]
                public long? AutoRenewPeriod { get; set; }
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public long? Bandwidth { get; set; }
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }
                [NameInMap("ClusterMode")]
                [Validation(Required=false)]
                public bool? ClusterMode { get; set; }
                [NameInMap("IaasType")]
                [Validation(Required=false)]
                public string IaasType { get; set; }
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }
                [NameInMap("InternetChargeType")]
                [Validation(Required=false)]
                public string InternetChargeType { get; set; }
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }
                [NameInMap("ShareMode")]
                [Validation(Required=false)]
                public bool? ShareMode { get; set; }
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }
                [NameInMap("UtcCreate")]
                [Validation(Required=false)]
                public string UtcCreate { get; set; }
                [NameInMap("UtcModified")]
                [Validation(Required=false)]
                public string UtcModified { get; set; }
                [NameInMap("VipAddressType")]
                [Validation(Required=false)]
                public string VipAddressType { get; set; }
                [NameInMap("VipType")]
                [Validation(Required=false)]
                public string VipType { get; set; }
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }
                [NameInMap("VswitchIaasId")]
                [Validation(Required=false)]
                public string VswitchIaasId { get; set; }
                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }
                [NameInMap("AppServiceIds")]
                [Validation(Required=false)]
                public List<string> AppServiceIds { get; set; }
                [NameInMap("AssignedAppIds")]
                [Validation(Required=false)]
                public List<string> AssignedAppIds { get; set; }
                [NameInMap("AssignedAppServiceIds")]
                [Validation(Required=false)]
                public List<string> AssignedAppServiceIds { get; set; }
                [NameInMap("Domains")]
                [Validation(Required=false)]
                public List<string> Domains { get; set; }
                [NameInMap("VipAddresses")]
                [Validation(Required=false)]
                public List<string> VipAddresses { get; set; }
                [NameInMap("Scope")]
                [Validation(Required=false)]
                public QueryCasLoadbalanceListenerResponseBodyDataLoadBalancerScope Scope { get; set; }
                public class QueryCasLoadbalanceListenerResponseBodyDataLoadBalancerScope : TeaModel {
                    [NameInMap("Cell")]
                    [Validation(Required=false)]
                    public string Cell { get; set; }

                    [NameInMap("Cluster")]
                    [Validation(Required=false)]
                    public string Cluster { get; set; }

                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    [NameInMap("Tenant")]
                    [Validation(Required=false)]
                    public string Tenant { get; set; }

                    [NameInMap("Workspace")]
                    [Validation(Required=false)]
                    public string Workspace { get; set; }

                    [NameInMap("WorkspaceGroup")]
                    [Validation(Required=false)]
                    public string WorkspaceGroup { get; set; }

                    [NameInMap("Zone")]
                    [Validation(Required=false)]
                    public string Zone { get; set; }

                }
            };

        }

    }

}
