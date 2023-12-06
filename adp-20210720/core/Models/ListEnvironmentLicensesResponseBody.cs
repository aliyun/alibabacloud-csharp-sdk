// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class ListEnvironmentLicensesResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ListEnvironmentLicensesResponseBodyData Data { get; set; }
        public class ListEnvironmentLicensesResponseBodyData : TeaModel {
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<ListEnvironmentLicensesResponseBodyDataList> List { get; set; }
            public class ListEnvironmentLicensesResponseBodyDataList : TeaModel {
                [NameInMap("expireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                [NameInMap("licenseKey")]
                [Validation(Required=false)]
                public string LicenseKey { get; set; }

                [NameInMap("licenseQuota")]
                [Validation(Required=false)]
                public ListEnvironmentLicensesResponseBodyDataListLicenseQuota LicenseQuota { get; set; }
                public class ListEnvironmentLicensesResponseBodyDataListLicenseQuota : TeaModel {
                    [NameInMap("clusterQuota")]
                    [Validation(Required=false)]
                    public ListEnvironmentLicensesResponseBodyDataListLicenseQuotaClusterQuota ClusterQuota { get; set; }
                    public class ListEnvironmentLicensesResponseBodyDataListLicenseQuotaClusterQuota : TeaModel {
                        [NameInMap("cpuCoreLimit")]
                        [Validation(Required=false)]
                        public int? CpuCoreLimit { get; set; }

                    }

                    [NameInMap("componentQuotas")]
                    [Validation(Required=false)]
                    public List<ListEnvironmentLicensesResponseBodyDataListLicenseQuotaComponentQuotas> ComponentQuotas { get; set; }
                    public class ListEnvironmentLicensesResponseBodyDataListLicenseQuotaComponentQuotas : TeaModel {
                        [NameInMap("componentName")]
                        [Validation(Required=false)]
                        public string ComponentName { get; set; }

                        [NameInMap("componentSource")]
                        [Validation(Required=false)]
                        public string ComponentSource { get; set; }

                        [NameInMap("instanceLimit")]
                        [Validation(Required=false)]
                        public int? InstanceLimit { get; set; }

                    }

                    [NameInMap("customQuotas")]
                    [Validation(Required=false)]
                    public List<ListEnvironmentLicensesResponseBodyDataListLicenseQuotaCustomQuotas> CustomQuotas { get; set; }
                    public class ListEnvironmentLicensesResponseBodyDataListLicenseQuotaCustomQuotas : TeaModel {
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

            [NameInMap("pageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

    }

}
