// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListProjectsResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListProjectsResponseBodyData Data { get; set; }
        public class ListProjectsResponseBodyData : TeaModel {
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("marker")]
            [Validation(Required=false)]
            public string Marker { get; set; }

            [NameInMap("maxItem")]
            [Validation(Required=false)]
            public int? MaxItem { get; set; }

            [NameInMap("projects")]
            [Validation(Required=false)]
            public List<ListProjectsResponseBodyDataProjects> Projects { get; set; }
            public class ListProjectsResponseBodyDataProjects : TeaModel {
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListProjectsResponseBodyDataProjectsTags> Tags { get; set; }
                public class ListProjectsResponseBodyDataProjectsTags : TeaModel {
                    [NameInMap("TagKey")]
                    [Validation(Required=false)]
                    public string TagKey { get; set; }

                    [NameInMap("TagValue")]
                    [Validation(Required=false)]
                    public string TagValue { get; set; }

                }

                [NameInMap("comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                [NameInMap("costStorage")]
                [Validation(Required=false)]
                public string CostStorage { get; set; }

                [NameInMap("defaultQuota")]
                [Validation(Required=false)]
                public string DefaultQuota { get; set; }

                [NameInMap("ipWhiteList")]
                [Validation(Required=false)]
                public ListProjectsResponseBodyDataProjectsIpWhiteList IpWhiteList { get; set; }
                public class ListProjectsResponseBodyDataProjectsIpWhiteList : TeaModel {
                    [NameInMap("ipList")]
                    [Validation(Required=false)]
                    public string IpList { get; set; }

                    [NameInMap("vpcIpList")]
                    [Validation(Required=false)]
                    public string VpcIpList { get; set; }

                }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("properties")]
                [Validation(Required=false)]
                public ListProjectsResponseBodyDataProjectsProperties Properties { get; set; }
                public class ListProjectsResponseBodyDataProjectsProperties : TeaModel {
                    [NameInMap("allowFullScan")]
                    [Validation(Required=false)]
                    public bool? AllowFullScan { get; set; }

                    [NameInMap("elderTunnelQuota")]
                    [Validation(Required=false)]
                    public string ElderTunnelQuota { get; set; }

                    [NameInMap("enableDecimal2")]
                    [Validation(Required=false)]
                    public bool? EnableDecimal2 { get; set; }

                    [NameInMap("enableTunnelQuotaRoute")]
                    [Validation(Required=false)]
                    public bool? EnableTunnelQuotaRoute { get; set; }

                    [NameInMap("encryption")]
                    [Validation(Required=false)]
                    public ListProjectsResponseBodyDataProjectsPropertiesEncryption Encryption { get; set; }
                    public class ListProjectsResponseBodyDataProjectsPropertiesEncryption : TeaModel {
                        [NameInMap("algorithm")]
                        [Validation(Required=false)]
                        public string Algorithm { get; set; }

                        [NameInMap("enable")]
                        [Validation(Required=false)]
                        public bool? Enable { get; set; }

                        [NameInMap("key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                    }

                    [NameInMap("retentionDays")]
                    [Validation(Required=false)]
                    public long? RetentionDays { get; set; }

                    [NameInMap("sqlMeteringMax")]
                    [Validation(Required=false)]
                    public string SqlMeteringMax { get; set; }

                    [NameInMap("tableLifecycle")]
                    [Validation(Required=false)]
                    public ListProjectsResponseBodyDataProjectsPropertiesTableLifecycle TableLifecycle { get; set; }
                    public class ListProjectsResponseBodyDataProjectsPropertiesTableLifecycle : TeaModel {
                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("timezone")]
                    [Validation(Required=false)]
                    public string Timezone { get; set; }

                    [NameInMap("tunnelQuota")]
                    [Validation(Required=false)]
                    public string TunnelQuota { get; set; }

                    [NameInMap("typeSystem")]
                    [Validation(Required=false)]
                    public string TypeSystem { get; set; }

                }

                [NameInMap("saleTag")]
                [Validation(Required=false)]
                public ListProjectsResponseBodyDataProjectsSaleTag SaleTag { get; set; }
                public class ListProjectsResponseBodyDataProjectsSaleTag : TeaModel {
                    [NameInMap("resourceId")]
                    [Validation(Required=false)]
                    public string ResourceId { get; set; }

                    [NameInMap("resourceType")]
                    [Validation(Required=false)]
                    public string ResourceType { get; set; }

                }

                [NameInMap("securityProperties")]
                [Validation(Required=false)]
                public ListProjectsResponseBodyDataProjectsSecurityProperties SecurityProperties { get; set; }
                public class ListProjectsResponseBodyDataProjectsSecurityProperties : TeaModel {
                    [NameInMap("enableDownloadPrivilege")]
                    [Validation(Required=false)]
                    public bool? EnableDownloadPrivilege { get; set; }

                    [NameInMap("labelSecurity")]
                    [Validation(Required=false)]
                    public bool? LabelSecurity { get; set; }

                    [NameInMap("objectCreatorHasAccessPermission")]
                    [Validation(Required=false)]
                    public bool? ObjectCreatorHasAccessPermission { get; set; }

                    [NameInMap("objectCreatorHasGrantPermission")]
                    [Validation(Required=false)]
                    public bool? ObjectCreatorHasGrantPermission { get; set; }

                    [NameInMap("projectProtection")]
                    [Validation(Required=false)]
                    public ListProjectsResponseBodyDataProjectsSecurityPropertiesProjectProtection ProjectProtection { get; set; }
                    public class ListProjectsResponseBodyDataProjectsSecurityPropertiesProjectProtection : TeaModel {
                        [NameInMap("exceptionPolicy")]
                        [Validation(Required=false)]
                        public string ExceptionPolicy { get; set; }

                        [NameInMap("protected")]
                        [Validation(Required=false)]
                        public bool? Protected { get; set; }

                    }

                    [NameInMap("usingAcl")]
                    [Validation(Required=false)]
                    public bool? UsingAcl { get; set; }

                    [NameInMap("usingPolicy")]
                    [Validation(Required=false)]
                    public bool? UsingPolicy { get; set; }

                }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
