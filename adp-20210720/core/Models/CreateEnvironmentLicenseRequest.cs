// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class CreateEnvironmentLicenseRequest : TeaModel {
        [NameInMap("companyName")]
        [Validation(Required=false)]
        public string CompanyName { get; set; }

        [NameInMap("contact")]
        [Validation(Required=false)]
        public string Contact { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("expireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        [NameInMap("licenseQuota")]
        [Validation(Required=false)]
        public CreateEnvironmentLicenseRequestLicenseQuota LicenseQuota { get; set; }
        public class CreateEnvironmentLicenseRequestLicenseQuota : TeaModel {
            [NameInMap("clusterQuota")]
            [Validation(Required=false)]
            public CreateEnvironmentLicenseRequestLicenseQuotaClusterQuota ClusterQuota { get; set; }
            public class CreateEnvironmentLicenseRequestLicenseQuotaClusterQuota : TeaModel {
                [NameInMap("cpuCoreLimit")]
                [Validation(Required=false)]
                public long? CpuCoreLimit { get; set; }

            }

            [NameInMap("customQuotas")]
            [Validation(Required=false)]
            public List<CreateEnvironmentLicenseRequestLicenseQuotaCustomQuotas> CustomQuotas { get; set; }
            public class CreateEnvironmentLicenseRequestLicenseQuotaCustomQuotas : TeaModel {
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

        [NameInMap("machineFingerprint")]
        [Validation(Required=false)]
        public string MachineFingerprint { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("productVersionUID")]
        [Validation(Required=false)]
        public string ProductVersionUID { get; set; }

        [NameInMap("scenario")]
        [Validation(Required=false)]
        public string Scenario { get; set; }

        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
