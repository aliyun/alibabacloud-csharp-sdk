// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class UploadDataSyncResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public UploadDataSyncResponseBodyData Data { get; set; }
        public class UploadDataSyncResponseBodyData : TeaModel {
            [NameInMap("ResultInfo")]
            [Validation(Required=false)]
            public List<UploadDataSyncResponseBodyDataResultInfo> ResultInfo { get; set; }
            public class UploadDataSyncResponseBodyDataResultInfo : TeaModel {
                [NameInMap("HandScoreIdList")]
                [Validation(Required=false)]
                public UploadDataSyncResponseBodyDataResultInfoHandScoreIdList HandScoreIdList { get; set; }
                public class UploadDataSyncResponseBodyDataResultInfoHandScoreIdList : TeaModel {
                    [NameInMap("HandScoreIdList")]
                    [Validation(Required=false)]
                    public List<string> HandScoreIdList { get; set; }

                }

                [NameInMap("Rules")]
                [Validation(Required=false)]
                public UploadDataSyncResponseBodyDataResultInfoRules Rules { get; set; }
                public class UploadDataSyncResponseBodyDataResultInfoRules : TeaModel {
                    [NameInMap("RuleHitInfo")]
                    [Validation(Required=false)]
                    public List<UploadDataSyncResponseBodyDataResultInfoRulesRuleHitInfo> RuleHitInfo { get; set; }
                    public class UploadDataSyncResponseBodyDataResultInfoRulesRuleHitInfo : TeaModel {
                        [NameInMap("ConditionInfo")]
                        [Validation(Required=false)]
                        public UploadDataSyncResponseBodyDataResultInfoRulesRuleHitInfoConditionInfo ConditionInfo { get; set; }
                        public class UploadDataSyncResponseBodyDataResultInfoRulesRuleHitInfoConditionInfo : TeaModel {
                            [NameInMap("ConditionBasicInfo")]
                            [Validation(Required=false)]
                            public List<UploadDataSyncResponseBodyDataResultInfoRulesRuleHitInfoConditionInfoConditionBasicInfo> ConditionBasicInfo { get; set; }
                            public class UploadDataSyncResponseBodyDataResultInfoRulesRuleHitInfoConditionInfoConditionBasicInfo : TeaModel {
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>xxx</para>
                                /// </summary>
                                [NameInMap("ConditionInfoCid")]
                                [Validation(Required=false)]
                                public string ConditionInfoCid { get; set; }

                            }

                        }

                        [NameInMap("Hit")]
                        [Validation(Required=false)]
                        public UploadDataSyncResponseBodyDataResultInfoRulesRuleHitInfoHit Hit { get; set; }
                        public class UploadDataSyncResponseBodyDataResultInfoRulesRuleHitInfoHit : TeaModel {
                            [NameInMap("ConditionHitInfo")]
                            [Validation(Required=false)]
                            public List<UploadDataSyncResponseBodyDataResultInfoRulesRuleHitInfoHitConditionHitInfo> ConditionHitInfo { get; set; }
                            public class UploadDataSyncResponseBodyDataResultInfoRulesRuleHitInfoHitConditionHitInfo : TeaModel {
                                [NameInMap("HitCids")]
                                [Validation(Required=false)]
                                public UploadDataSyncResponseBodyDataResultInfoRulesRuleHitInfoHitConditionHitInfoHitCids HitCids { get; set; }
                                public class UploadDataSyncResponseBodyDataResultInfoRulesRuleHitInfoHitConditionHitInfoHitCids : TeaModel {
                                    [NameInMap("CidItem")]
                                    [Validation(Required=false)]
                                    public List<string> CidItem { get; set; }

                                }

                                [NameInMap("HitKeyWords")]
                                [Validation(Required=false)]
                                public UploadDataSyncResponseBodyDataResultInfoRulesRuleHitInfoHitConditionHitInfoHitKeyWords HitKeyWords { get; set; }
                                public class UploadDataSyncResponseBodyDataResultInfoRulesRuleHitInfoHitConditionHitInfoHitKeyWords : TeaModel {
                                    [NameInMap("HitKeyWord")]
                                    [Validation(Required=false)]
                                    public List<UploadDataSyncResponseBodyDataResultInfoRulesRuleHitInfoHitConditionHitInfoHitKeyWordsHitKeyWord> HitKeyWord { get; set; }
                                    public class UploadDataSyncResponseBodyDataResultInfoRulesRuleHitInfoHitConditionHitInfoHitKeyWordsHitKeyWord : TeaModel {
                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("From")]
                                        [Validation(Required=false)]
                                        public int? From { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("Pid")]
                                        [Validation(Required=false)]
                                        public int? Pid { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("Tid")]
                                        [Validation(Required=false)]
                                        public string Tid { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("To")]
                                        [Validation(Required=false)]
                                        public int? To { get; set; }

                                        [NameInMap("Val")]
                                        [Validation(Required=false)]
                                        public string Val { get; set; }

                                    }

                                }

                                [NameInMap("Phrase")]
                                [Validation(Required=false)]
                                public UploadDataSyncResponseBodyDataResultInfoRulesRuleHitInfoHitConditionHitInfoPhrase Phrase { get; set; }
                                public class UploadDataSyncResponseBodyDataResultInfoRulesRuleHitInfoHitConditionHitInfoPhrase : TeaModel {
                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>0</para>
                                    /// </summary>
                                    [NameInMap("Begin")]
                                    [Validation(Required=false)]
                                    public long? Begin { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>1564574</para>
                                    /// </summary>
                                    [NameInMap("BeginTime")]
                                    [Validation(Required=false)]
                                    public string BeginTime { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>2090</para>
                                    /// </summary>
                                    [NameInMap("End")]
                                    [Validation(Required=false)]
                                    public long? End { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>1</para>
                                    /// </summary>
                                    [NameInMap("Identity")]
                                    [Validation(Required=false)]
                                    public string Identity { get; set; }

                                    [NameInMap("Role")]
                                    [Validation(Required=false)]
                                    public string Role { get; set; }

                                    [NameInMap("Words")]
                                    [Validation(Required=false)]
                                    public string Words { get; set; }

                                }

                            }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>801</para>
                        /// </summary>
                        [NameInMap("Rid")]
                        [Validation(Required=false)]
                        public string Rid { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>88888888</para>
                        /// </summary>
                        [NameInMap("Tid")]
                        [Validation(Required=false)]
                        public string Tid { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public int? Score { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4987D326-83D9-4A42-B9A5-0B27F9B***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
