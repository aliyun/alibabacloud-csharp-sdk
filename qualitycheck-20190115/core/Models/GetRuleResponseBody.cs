// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetRuleResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("CreateEmpid")]
                    [Validation(Required=false)]
                    public string CreateEmpid { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2016-08-05 10:37:10</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2016-08-05 10:37:10</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("IsDelete")]
                    [Validation(Required=false)]
                    public int? IsDelete { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("IsOnline")]
                    [Validation(Required=false)]
                    public int? IsOnline { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("LastUpdateEmpid")]
                    [Validation(Required=false)]
                    public string LastUpdateEmpid { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2019-10-28 14:23:28</para>
                    /// </summary>
                    [NameInMap("LastUpdateTime")]
                    [Validation(Required=false)]
                    public string LastUpdateTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>demo</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("Rid")]
                    [Validation(Required=false)]
                    public string Rid { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>a &amp;&amp; b</para>
                    /// </summary>
                    [NameInMap("RuleLambda")]
                    [Validation(Required=false)]
                    public string RuleLambda { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("RuleScoreType")]
                    [Validation(Required=false)]
                    public int? RuleScoreType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("ScoreId")]
                    [Validation(Required=false)]
                    public int? ScoreId { get; set; }

                    [NameInMap("ScoreName")]
                    [Validation(Required=false)]
                    public string ScoreName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>22</para>
                    /// </summary>
                    [NameInMap("ScoreSubId")]
                    [Validation(Required=false)]
                    public int? ScoreSubId { get; set; }

                    [NameInMap("ScoreSubName")]
                    [Validation(Required=false)]
                    public string ScoreSubName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2016-08-05 10:37:10</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public int? Type { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Weight")]
                    [Validation(Required=false)]
                    public string Weight { get; set; }

                }

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
        /// <para>F190ADE9-619A-447D-84E3-7E241A5C428E</para>
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
