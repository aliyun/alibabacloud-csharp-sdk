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
                public int? AgentHeartBeatLostNum { get; set; }
                public int? BadHealthNum { get; set; }
                public string ComponentName { get; set; }
                public long? CreatedTime { get; set; }
                public int? DisabledHealthNum { get; set; }
                public int? GoodHealthNum { get; set; }
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
                        };

                        [NameInMap("code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                    }

                }
                public string HealthLevel { get; set; }
                public string HealthStatus { get; set; }
                public int? ManualStoppedNum { get; set; }
                public int? NoneHealthNum { get; set; }
                public int? NormalNum { get; set; }
                public string ServiceName { get; set; }
                public int? StoppedHealthNum { get; set; }
                public int? StoppedNum { get; set; }
                public int? TotalNum { get; set; }
                public int? UnknownHealthNum { get; set; }
                public int? WarningHealthNum { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
