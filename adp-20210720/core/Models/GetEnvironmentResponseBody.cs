// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class GetEnvironmentResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetEnvironmentResponseBodyData Data { get; set; }
        public class GetEnvironmentResponseBodyData : TeaModel {
            [NameInMap("advancedConfigs")]
            [Validation(Required=false)]
            public GetEnvironmentResponseBodyDataAdvancedConfigs AdvancedConfigs { get; set; }
            public class GetEnvironmentResponseBodyDataAdvancedConfigs : TeaModel {
                [NameInMap("enableDeploySimulation")]
                [Validation(Required=false)]
                public bool? EnableDeploySimulation { get; set; }

                [NameInMap("enableSiteSurvey")]
                [Validation(Required=false)]
                public bool? EnableSiteSurvey { get; set; }

            }

            [NameInMap("clusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("clusterUID")]
            [Validation(Required=false)]
            public string ClusterUID { get; set; }

            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("expiredAt")]
            [Validation(Required=false)]
            public string ExpiredAt { get; set; }

            [NameInMap("foundationType")]
            [Validation(Required=false)]
            public string FoundationType { get; set; }

            [NameInMap("foundationVersion")]
            [Validation(Required=false)]
            public string FoundationVersion { get; set; }

            [NameInMap("foundationVersionUID")]
            [Validation(Required=false)]
            public string FoundationVersionUID { get; set; }

            [NameInMap("instanceList")]
            [Validation(Required=false)]
            public List<InstanceInfo> InstanceList { get; set; }

            [NameInMap("instanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            [NameInMap("location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("oldProductVersion")]
            [Validation(Required=false)]
            public string OldProductVersion { get; set; }

            [NameInMap("oldProductVersionUID")]
            [Validation(Required=false)]
            public string OldProductVersionUID { get; set; }

            [NameInMap("platform")]
            [Validation(Required=false)]
            public GetEnvironmentResponseBodyDataPlatform Platform { get; set; }
            public class GetEnvironmentResponseBodyDataPlatform : TeaModel {
                [NameInMap("architecture")]
                [Validation(Required=false)]
                public string Architecture { get; set; }

                [NameInMap("os")]
                [Validation(Required=false)]
                public string Os { get; set; }

            }

            [NameInMap("platformList")]
            [Validation(Required=false)]
            public List<Platform> PlatformList { get; set; }

            [NameInMap("platformStatus")]
            [Validation(Required=false)]
            public string PlatformStatus { get; set; }

            [NameInMap("productName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            [NameInMap("productVersion")]
            [Validation(Required=false)]
            public string ProductVersion { get; set; }

            [NameInMap("siteSurveyReport")]
            [Validation(Required=false)]
            public GetEnvironmentResponseBodyDataSiteSurveyReport SiteSurveyReport { get; set; }
            public class GetEnvironmentResponseBodyDataSiteSurveyReport : TeaModel {
                [NameInMap("checkList")]
                [Validation(Required=false)]
                public List<GetEnvironmentResponseBodyDataSiteSurveyReportCheckList> CheckList { get; set; }
                public class GetEnvironmentResponseBodyDataSiteSurveyReportCheckList : TeaModel {
                    [NameInMap("description")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Description { get; set; }

                    [NameInMap("failedList")]
                    [Validation(Required=false)]
                    public List<GetEnvironmentResponseBodyDataSiteSurveyReportCheckListFailedList> FailedList { get; set; }
                    public class GetEnvironmentResponseBodyDataSiteSurveyReportCheckListFailedList : TeaModel {
                        [NameInMap("ip")]
                        [Validation(Required=false)]
                        public string Ip { get; set; }

                        [NameInMap("reason")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> Reason { get; set; }

                    }

                    [NameInMap("level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                [NameInMap("result")]
                [Validation(Required=false)]
                public string Result { get; set; }

            }

            [NameInMap("uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            [NameInMap("vendorConfig")]
            [Validation(Required=false)]
            public string VendorConfig { get; set; }

            [NameInMap("vendorType")]
            [Validation(Required=false)]
            public string VendorType { get; set; }

        }

        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

    }

}
