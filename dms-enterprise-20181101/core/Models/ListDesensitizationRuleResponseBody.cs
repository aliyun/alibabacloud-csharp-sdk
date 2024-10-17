// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListDesensitizationRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of masking rules.</para>
        /// </summary>
        [NameInMap("DesensitizationRuleList")]
        [Validation(Required=false)]
        public List<ListDesensitizationRuleResponseBodyDesensitizationRuleList> DesensitizationRuleList { get; set; }
        public class ListDesensitizationRuleResponseBodyDesensitizationRuleList : TeaModel {
            /// <summary>
            /// <para>The parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{paramName: salt, paramValue: 1}</para>
            /// </summary>
            [NameInMap("FuncParams")]
            [Validation(Required=false)]
            public string FuncParams { get; set; }

            /// <summary>
            /// <para>The example.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{paramName: testStr, paramValue: 1}]</para>
            /// </summary>
            [NameInMap("FuncSample")]
            [Validation(Required=false)]
            public string FuncSample { get; set; }

            /// <summary>
            /// <para>The algorithm type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MD5</para>
            /// </summary>
            [NameInMap("FunctionType")]
            [Validation(Required=false)]
            public string FunctionType { get; set; }

            /// <summary>
            /// <para>The ID of the user who last modified the masking rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("LastModifierId")]
            [Validation(Required=false)]
            public string LastModifierId { get; set; }

            /// <summary>
            /// <para>The name of the user who last modified the masking rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test user</para>
            /// </summary>
            [NameInMap("LastModifierName")]
            [Validation(Required=false)]
            public string LastModifierName { get; set; }

            /// <summary>
            /// <para>The number of times that the masking was used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ReferenceCount")]
            [Validation(Required=false)]
            public int? ReferenceCount { get; set; }

            /// <summary>
            /// <para>The description of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hash desensitization algorithm</para>
            /// </summary>
            [NameInMap("RuleDesc")]
            [Validation(Required=false)]
            public string RuleDesc { get; set; }

            /// <summary>
            /// <para>The ID of the masking rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public int? RuleId { get; set; }

            /// <summary>
            /// <para>The name of the masking rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default desensitization rule test</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The algorithm used for masking.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HASH</para>
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

        }

        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E76DD2E7-EBAC-5724-B163-19AAC233F8F2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries returned. By default, this parameter is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
