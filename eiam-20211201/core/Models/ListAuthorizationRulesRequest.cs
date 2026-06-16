// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListAuthorizationRulesRequest : TeaModel {
        /// <summary>
        /// <para>The filter conditions.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<ListAuthorizationRulesRequestFilter> Filter { get; set; }
        public class ListAuthorizationRulesRequestFilter : TeaModel {
            /// <summary>
            /// <para>The name of the field to filter. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>AuthorizationRuleId: the ID of the authorization rule.</para>
            /// </description></item>
            /// <item><description><para>AuthorizationRuleNameStartWith: the leftmost characters of the authorization rule name.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AuthorizationRuleId</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The list of values for the field to filter.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page.</para>
        /// <list type="bullet">
        /// <item><description><para>If you do not specify this parameter, the default value is 20.</para>
        /// </description></item>
        /// <item><description><para>The maximum value is 100.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that identifies the start of the next page of results.</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter, the system returns the first page of results.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NTxxxxxexample</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
