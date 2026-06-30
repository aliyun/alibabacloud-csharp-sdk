// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class ListQualityCheckSchemeResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A value of <b>200</b> indicates success. Other values indicate a failure. Use this code to identify the cause of the failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The data of the quality check scheme list.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListQualityCheckSchemeResponseBodyData> Data { get; set; }
        public class ListQualityCheckSchemeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the scheme was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-10T09:34Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The name of the creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("CreateUserName")]
            [Validation(Required=false)]
            public string CreateUserName { get; set; }

            /// <summary>
            /// <para>The data type of the quality check scheme. Valid values: 0 (text) and 1 (audio).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public int? DataType { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>售前使用</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the quality check scheme.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The list of check items.</para>
            /// </summary>
            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public List<ListQualityCheckSchemeResponseBodyDataRuleList> RuleList { get; set; }
            public class ListQualityCheckSchemeResponseBodyDataRuleList : TeaModel {
                /// <summary>
                /// <para>The rule information. This parameter is reserved for future use. Currently, only one rule is returned.</para>
                /// </summary>
                [NameInMap("Rules")]
                [Validation(Required=false)]
                public List<ListQualityCheckSchemeResponseBodyDataRuleListRules> Rules { get; set; }
                public class ListQualityCheckSchemeResponseBodyDataRuleListRules : TeaModel {
                    /// <summary>
                    /// <para>The quality check dimension to which the item belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("CheckType")]
                    [Validation(Required=false)]
                    public int? CheckType { get; set; }

                    /// <summary>
                    /// <para>The name of the check item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>测试规则</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The ID of the check item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("Rid")]
                    [Validation(Required=false)]
                    public long? Rid { get; set; }

                    /// <summary>
                    /// <para>Indicates whether to calculate a score. Valid values: 1 (no score) and 3 (score).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("RuleScoreType")]
                    [Validation(Required=false)]
                    public int? RuleScoreType { get; set; }

                    /// <summary>
                    /// <para>The score.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("ScoreNum")]
                    [Validation(Required=false)]
                    public int? ScoreNum { get; set; }

                    /// <summary>
                    /// <para>The scoring type. Valid values: 0 (Points are added or deducted each time the rule is triggered) and 1 (A one-time score is given when the rule is triggered).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ScoreNumType")]
                    [Validation(Required=false)]
                    public int? ScoreNumType { get; set; }

                    /// <summary>
                    /// <para>The scoring method. Valid values: 1 (add points) and 3 (deduct points).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ScoreType")]
                    [Validation(Required=false)]
                    public int? ScoreType { get; set; }

                    /// <summary>
                    /// <para>The application scenario of the check item. Valid values: 10 (common check item) and 11 (SOP flow check item).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("TargetType")]
                    [Validation(Required=false)]
                    public int? TargetType { get; set; }

                }

            }

            /// <summary>
            /// <para>The list of quality check dimensions.</para>
            /// </summary>
            [NameInMap("SchemeCheckTypeList")]
            [Validation(Required=false)]
            public List<ListQualityCheckSchemeResponseBodyDataSchemeCheckTypeList> SchemeCheckTypeList { get; set; }
            public class ListQualityCheckSchemeResponseBodyDataSchemeCheckTypeList : TeaModel {
                /// <summary>
                /// <para>The name of the quality check dimension.</para>
                /// 
                /// <b>Example:</b>
                /// <para>服务规范性检测</para>
                /// </summary>
                [NameInMap("CheckName")]
                [Validation(Required=false)]
                public string CheckName { get; set; }

                /// <summary>
                /// <para>The type of the quality check dimension.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CheckType")]
                [Validation(Required=false)]
                public int? CheckType { get; set; }

                /// <summary>
                /// <para>The enabled status. Valid values: 0 (disabled) and 1 (enabled).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public int? Enable { get; set; }

                /// <summary>
                /// <para>The score of the quality check dimension.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public int? Score { get; set; }

                /// <summary>
                /// <para>An internal parameter. You can ignore this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public int? TargetType { get; set; }

            }

            /// <summary>
            /// <para>The ID of the quality check scheme.</para>
            /// 
            /// <b>Example:</b>
            /// <para>112**</para>
            /// </summary>
            [NameInMap("SchemeId")]
            [Validation(Required=false)]
            public long? SchemeId { get; set; }

            /// <summary>
            /// <para>The status of the quality check scheme. Valid values: 0 (deleted), 1 (published), 2 (unpublished), and 3 (updated but not published).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The type of the quality check scheme template. Valid values: 1 (built-in) and 2 (user-defined).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public int? TemplateType { get; set; }

            /// <summary>
            /// <para>The type of the quality check scheme. Valid values: 0 (built-in) and 1 (user-defined).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// <para>The time when the scheme was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-10T10:34Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The name of the user who last updated the scheme.</para>
            /// 
            /// <b>Example:</b>
            /// <para>李四</para>
            /// </summary>
            [NameInMap("UpdateUserName")]
            [Validation(Required=false)]
            public string UpdateUserName { get; set; }

            /// <summary>
            /// <para>The version of the quality check scheme.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

        /// <summary>
        /// <para>The returned message. If the request is successful, \<c>successful\\</c> is returned. If the request fails, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>82C91484-B2D5-4D2A-A21F-A6D73F4***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An internal parameter. You can ignore this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>XXX</para>
        /// </summary>
        [NameInMap("ResultCountId")]
        [Validation(Required=false)]
        public string ResultCountId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. A value of true indicates success. A value of <b>false</b> or <b>null</b> indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
