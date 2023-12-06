// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class GetEnvironmentLicenseResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetEnvironmentLicenseResponseBodyData Data { get; set; }
        public class GetEnvironmentLicenseResponseBodyData : TeaModel {
            [NameInMap("expireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            [NameInMap("licenseKey")]
            [Validation(Required=false)]
            public string LicenseKey { get; set; }

            [NameInMap("licenseQuota")]
            [Validation(Required=false)]
            public GetEnvironmentLicenseResponseBodyDataLicenseQuota LicenseQuota { get; set; }
            public class GetEnvironmentLicenseResponseBodyDataLicenseQuota : TeaModel {
                [NameInMap("clusterQuota")]
                [Validation(Required=false)]
                public GetEnvironmentLicenseResponseBodyDataLicenseQuotaClusterQuota ClusterQuota { get; set; }
                public class GetEnvironmentLicenseResponseBodyDataLicenseQuotaClusterQuota : TeaModel {
                    [NameInMap("cpuCoreLimit")]
                    [Validation(Required=false)]
                    public long? CpuCoreLimit { get; set; }

                }

                [NameInMap("componentQuotas")]
                [Validation(Required=false)]
                public List<GetEnvironmentLicenseResponseBodyDataLicenseQuotaComponentQuotas> ComponentQuotas { get; set; }
                public class GetEnvironmentLicenseResponseBodyDataLicenseQuotaComponentQuotas : TeaModel {
                    [NameInMap("componentName")]
                    [Validation(Required=false)]
                    public string ComponentName { get; set; }

                    [NameInMap("componentSource")]
                    [Validation(Required=false)]
                    public string ComponentSource { get; set; }

                    [NameInMap("instanceLimit")]
                    [Validation(Required=false)]
                    public long? InstanceLimit { get; set; }

                }

                [NameInMap("customQuotas")]
                [Validation(Required=false)]
                public List<GetEnvironmentLicenseResponseBodyDataLicenseQuotaCustomQuotas> CustomQuotas { get; set; }
                public class GetEnvironmentLicenseResponseBodyDataLicenseQuotaCustomQuotas : TeaModel {
                    [NameInMap("description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            [NameInMap("productVersionUID")]
            [Validation(Required=false)]
            public string ProductVersionUID { get; set; }

            [NameInMap("rejectReason")]
            [Validation(Required=false)]
            public string RejectReason { get; set; }

            [NameInMap("scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// kubernetes secret yaml。
            /// </summary>
            [NameInMap("secretYAML")]
            [Validation(Required=false)]
            public string SecretYAML { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

    }

}
