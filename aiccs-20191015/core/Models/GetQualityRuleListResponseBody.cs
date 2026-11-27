// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetQualityRuleListResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A value of 200 indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The quality check rule information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetQualityRuleListResponseBodyData Data { get; set; }
        public class GetQualityRuleListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

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
            /// <para>The list of rule details.</para>
            /// </summary>
            [NameInMap("QualityRuleList")]
            [Validation(Required=false)]
            public List<GetQualityRuleListResponseBodyDataQualityRuleList> QualityRuleList { get; set; }
            public class GetQualityRuleListResponseBodyDataQualityRuleList : TeaModel {
                /// <summary>
                /// <para>The keywords.</para>
                /// </summary>
                [NameInMap("KeyWords")]
                [Validation(Required=false)]
                public List<string> KeyWords { get; set; }

                /// <summary>
                /// <para>The keyword match type. Valid values:	</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Any keyword appears.</description></item>
                /// <item><description><b>2</b>: All keywords appear.</description></item>
                /// <item><description><b>3</b>: No keywords appear.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MatchType")]
                [Validation(Required=false)]
                public int? MatchType { get; set; }

                /// <summary>
                /// <para>The name of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Automatically created quality check rule</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The time when the rule was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Mon Mar 29 22:14:02 CST 2021</para>
                /// </summary>
                [NameInMap("RuleCreateTime")]
                [Validation(Required=false)]
                public string RuleCreateTime { get; set; }

                /// <summary>
                /// <para>The ID of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5369</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

                /// <summary>
                /// <para>The tag of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>638</para>
                /// </summary>
                [NameInMap("RuleTag")]
                [Validation(Required=false)]
                public int? RuleTag { get; set; }

            }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>84</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE338D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
