// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListClusterServiceComponentHealthInfoResponseBody : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("HealthInfoList")]
        [Validation(Required=false)]
        public ListClusterServiceComponentHealthInfoResponseBodyHealthInfoList HealthInfoList { get; set; }
        public class ListClusterServiceComponentHealthInfoResponseBodyHealthInfoList : TeaModel {
            [NameInMap("HealthInfo")]
            [Validation(Required=false)]
            public List<ListClusterServiceComponentHealthInfoResponseBodyHealthInfoListHealthInfo> HealthInfo { get; set; }
            public class ListClusterServiceComponentHealthInfoResponseBodyHealthInfoListHealthInfo : TeaModel {
                [NameInMap("AgentHeartBeatLostNum")]
                [Validation(Required=false)]
                public int? AgentHeartBeatLostNum { get; set; }

                [NameInMap("BadHealthNum")]
                [Validation(Required=false)]
                public int? BadHealthNum { get; set; }

                [NameInMap("ComponentName")]
                [Validation(Required=false)]
                public string ComponentName { get; set; }

                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                [NameInMap("DisabledHealthNum")]
                [Validation(Required=false)]
                public int? DisabledHealthNum { get; set; }

                [NameInMap("GoodHealthNum")]
                [Validation(Required=false)]
                public int? GoodHealthNum { get; set; }

                [NameInMap("HealthDetailList")]
                [Validation(Required=false)]
                public ListClusterServiceComponentHealthInfoResponseBodyHealthInfoListHealthInfoHealthDetailList HealthDetailList { get; set; }
                public class ListClusterServiceComponentHealthInfoResponseBodyHealthInfoListHealthInfoHealthDetailList : TeaModel {
                    [NameInMap("HealthDetail")]
                    [Validation(Required=false)]
                    public List<ListClusterServiceComponentHealthInfoResponseBodyHealthInfoListHealthInfoHealthDetailListHealthDetail> HealthDetail { get; set; }
                    public class ListClusterServiceComponentHealthInfoResponseBodyHealthInfoListHealthInfoHealthDetailListHealthDetail : TeaModel {
                        [NameInMap("HealthRuleParam")]
                        [Validation(Required=false)]
                        public ListClusterServiceComponentHealthInfoResponseBodyHealthInfoListHealthInfoHealthDetailListHealthDetailHealthRuleParam HealthRuleParam { get; set; }
                        public class ListClusterServiceComponentHealthInfoResponseBodyHealthInfoListHealthInfoHealthDetailListHealthDetailHealthRuleParam : TeaModel {
                            [NameInMap("Component")]
                            [Validation(Required=false)]
                            public string Component { get; set; }

                            [NameInMap("HostNames")]
                            [Validation(Required=false)]
                            public string HostNames { get; set; }

                            [NameInMap("Pass")]
                            [Validation(Required=false)]
                            public string Pass { get; set; }

                            [NameInMap("RuleDescription")]
                            [Validation(Required=false)]
                            public string RuleDescription { get; set; }

                            [NameInMap("RuleId")]
                            [Validation(Required=false)]
                            public string RuleId { get; set; }

                            [NameInMap("RuleTitle")]
                            [Validation(Required=false)]
                            public string RuleTitle { get; set; }

                            [NameInMap("Service")]
                            [Validation(Required=false)]
                            public string Service { get; set; }

                        }

                        [NameInMap("code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                    }

                }

                [NameInMap("HealthLevel")]
                [Validation(Required=false)]
                public string HealthLevel { get; set; }

                [NameInMap("HealthStatus")]
                [Validation(Required=false)]
                public string HealthStatus { get; set; }

                [NameInMap("ManualStoppedNum")]
                [Validation(Required=false)]
                public int? ManualStoppedNum { get; set; }

                [NameInMap("NoneHealthNum")]
                [Validation(Required=false)]
                public int? NoneHealthNum { get; set; }

                [NameInMap("NormalNum")]
                [Validation(Required=false)]
                public int? NormalNum { get; set; }

                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

                [NameInMap("StoppedHealthNum")]
                [Validation(Required=false)]
                public int? StoppedHealthNum { get; set; }

                [NameInMap("StoppedNum")]
                [Validation(Required=false)]
                public int? StoppedNum { get; set; }

                [NameInMap("TotalNum")]
                [Validation(Required=false)]
                public int? TotalNum { get; set; }

                [NameInMap("UnknownHealthNum")]
                [Validation(Required=false)]
                public int? UnknownHealthNum { get; set; }

                [NameInMap("WarningHealthNum")]
                [Validation(Required=false)]
                public int? WarningHealthNum { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
