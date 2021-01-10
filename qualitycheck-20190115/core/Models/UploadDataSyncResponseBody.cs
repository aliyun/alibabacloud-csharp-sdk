// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class UploadDataSyncResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public UploadDataSyncResponseBodyData Data { get; set; }
        public class UploadDataSyncResponseBodyData : TeaModel {
            [NameInMap("ResultInfo")]
            [Validation(Required=false)]
            public List<UploadDataSyncResponseBodyDataResultInfo> ResultInfo { get; set; }
            public class UploadDataSyncResponseBodyDataResultInfo : TeaModel {
                public int? Score { get; set; }
                public UploadDataSyncResponseBodyDataResultInfoRules Rules { get; set; }
                public class UploadDataSyncResponseBodyDataResultInfoRules : TeaModel {
                    [NameInMap("RuleHitInfo")]
                    [Validation(Required=false)]
                    public List<UploadDataSyncResponseBodyDataResultInfoRulesRuleHitInfo> RuleHitInfo { get; set; }
                    public class UploadDataSyncResponseBodyDataResultInfoRulesRuleHitInfo : TeaModel {
                        [NameInMap("Tid")]
                        [Validation(Required=false)]
                        public string Tid { get; set; }

                        [NameInMap("Hit")]
                        [Validation(Required=false)]
                        public UploadDataSyncResponseBodyDataResultInfoRulesRuleHitInfoHit Hit { get; set; }
                        public class UploadDataSyncResponseBodyDataResultInfoRulesRuleHitInfoHit : TeaModel {
                            [NameInMap("ConditionHitInfo")]
                            [Validation(Required=false)]
                            public List<UploadDataSyncResponseBodyDataResultInfoRulesRuleHitInfoHitConditionHitInfo> ConditionHitInfo { get; set; }
                            public class UploadDataSyncResponseBodyDataResultInfoRulesRuleHitInfoHitConditionHitInfo : TeaModel {
                                [NameInMap("Words")]
                                [Validation(Required=false)]
                                public string Words { get; set; }

                                [NameInMap("Identity")]
                                [Validation(Required=false)]
                                public string Identity { get; set; }

                                [NameInMap("Begin")]
                                [Validation(Required=false)]
                                public long? Begin { get; set; }

                                [NameInMap("BeginTime")]
                                [Validation(Required=false)]
                                public string BeginTime { get; set; }

                                [NameInMap("End")]
                                [Validation(Required=false)]
                                public long? End { get; set; }

                                [NameInMap("Role")]
                                [Validation(Required=false)]
                                public string Role { get; set; }

                            }
                        };

                        [NameInMap("ConditionInfo")]
                        [Validation(Required=false)]
                        public UploadDataSyncResponseBodyDataResultInfoRulesRuleHitInfoConditionInfo ConditionInfo { get; set; }
                        public class UploadDataSyncResponseBodyDataResultInfoRulesRuleHitInfoConditionInfo : TeaModel {
                            [NameInMap("ConditionBasicInfo")]
                            [Validation(Required=false)]
                            public List<UploadDataSyncResponseBodyDataResultInfoRulesRuleHitInfoConditionInfoConditionBasicInfo> ConditionBasicInfo { get; set; }
                            public class UploadDataSyncResponseBodyDataResultInfoRulesRuleHitInfoConditionInfoConditionBasicInfo : TeaModel {
                                public string ConditionInfoCid { get; set; }
                            }
                        };

                        [NameInMap("Rid")]
                        [Validation(Required=false)]
                        public string Rid { get; set; }

                    }

                }
                public UploadDataSyncResponseBodyDataResultInfoHandScoreIdList HandScoreIdList { get; set; }
                public class UploadDataSyncResponseBodyDataResultInfoHandScoreIdList : TeaModel {
                    [NameInMap("HandScoreIdList")]
                    [Validation(Required=false)]
                    public List<string> HandScoreIdList { get; set; }

                }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
