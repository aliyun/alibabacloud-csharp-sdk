// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code. <b>200</b> means success. Any other value means failure. Use this field to identify the cause of failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRuleResponseBodyData Data { get; set; }
        public class GetRuleResponseBodyData : TeaModel {
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public GetRuleResponseBodyDataRules Rules { get; set; }
            public class GetRuleResponseBodyDataRules : TeaModel {
                [NameInMap("RuleInfo")]
                [Validation(Required=false)]
                public List<GetRuleResponseBodyDataRulesRuleInfo> RuleInfo { get; set; }
                public class GetRuleResponseBodyDataRulesRuleInfo : TeaModel {
                    [NameInMap("AutoReview")]
                    [Validation(Required=false)]
                    public int? AutoReview { get; set; }

                    [NameInMap("BusinessCategoryNameList")]
                    [Validation(Required=false)]
                    public GetRuleResponseBodyDataRulesRuleInfoBusinessCategoryNameList BusinessCategoryNameList { get; set; }
                    public class GetRuleResponseBodyDataRulesRuleInfoBusinessCategoryNameList : TeaModel {
                        [NameInMap("BusinessCategoryNameList")]
                        [Validation(Required=false)]
                        public List<string> BusinessCategoryNameList { get; set; }

                    }

                    [NameInMap("Comments")]
                    [Validation(Required=false)]
                    public string Comments { get; set; }

                    [NameInMap("CreateEmpid")]
                    [Validation(Required=false)]
                    public string CreateEmpid { get; set; }

                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    [NameInMap("IsDelete")]
                    [Validation(Required=false)]
                    public int? IsDelete { get; set; }

                    [NameInMap("IsOnline")]
                    [Validation(Required=false)]
                    public int? IsOnline { get; set; }

                    [NameInMap("LastUpdateEmpid")]
                    [Validation(Required=false)]
                    public string LastUpdateEmpid { get; set; }

                    [NameInMap("LastUpdateTime")]
                    [Validation(Required=false)]
                    public string LastUpdateTime { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Rid")]
                    [Validation(Required=false)]
                    public string Rid { get; set; }

                    [NameInMap("RuleLambda")]
                    [Validation(Required=false)]
                    public string RuleLambda { get; set; }

                    [NameInMap("RuleScoreType")]
                    [Validation(Required=false)]
                    public int? RuleScoreType { get; set; }

                    [NameInMap("ScoreId")]
                    [Validation(Required=false)]
                    public int? ScoreId { get; set; }

                    [NameInMap("ScoreName")]
                    [Validation(Required=false)]
                    public string ScoreName { get; set; }

                    [NameInMap("ScoreSubId")]
                    [Validation(Required=false)]
                    public int? ScoreSubId { get; set; }

                    [NameInMap("ScoreSubName")]
                    [Validation(Required=false)]
                    public string ScoreSubName { get; set; }

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public int? Type { get; set; }

                    [NameInMap("Weight")]
                    [Validation(Required=false)]
                    public string Weight { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>Error details if the request fails. Returns <b>successful</b> if the request succeeds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>F190ADE9-619A-447D-84E3-7E241A5C428E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded. true means success. <b>false</b> or <b>null</b> means failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
