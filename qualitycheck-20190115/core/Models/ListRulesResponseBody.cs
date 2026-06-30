// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class ListRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code. A value of 200 means success. Any other value means failure. Use this field to identify the cause of failure.</para>
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
        /// <para>20</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The rule list.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListRulesResponseBodyData> Data { get; set; }
        public class ListRulesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The names of business categories associated with the rule.</para>
            /// </summary>
            [NameInMap("BusinessCategoryNameList")]
            [Validation(Required=false)]
            public List<string> BusinessCategoryNameList { get; set; }

            /// <summary>
            /// <para>Comments for the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>检测是否出现了禁用语</para>
            /// </summary>
            [NameInMap("Comments")]
            [Validation(Required=false)]
            public string Comments { get; set; }

            /// <summary>
            /// <para>The time when the rule was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-04-20T20:10Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>禁用语检测</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567</para>
            /// </summary>
            [NameInMap("Rid")]
            [Validation(Required=false)]
            public long? Rid { get; set; }

            /// <summary>
            /// <para>The rule category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>1: Custom rule</para>
            /// </description></item>
            /// <item><description><para>0: System-provided rule</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public int? RuleType { get; set; }

            /// <summary>
            /// <para>The type value of the rule\&quot;s rule type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// <para>The name of the rule\&quot;s rule type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>服务规范</para>
            /// </summary>
            [NameInMap("TypeName")]
            [Validation(Required=false)]
            public string TypeName { get; set; }

        }

        /// <summary>
        /// <para>Details about an error if the request failed. If the request succeeded, the value is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number of the rule list.</para>
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
        /// <para>82C91484-B2D5-4D2A-A21F-A6D73F**</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded. A value of true means success. A value of false or null means failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
