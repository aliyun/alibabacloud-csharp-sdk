// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListAuthorizationResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The authorization rule ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>arrule_01kf143ug06fg7m9f43u7vahxxxx</para>
        /// </summary>
        [NameInMap("AuthorizationRuleId")]
        [Validation(Required=false)]
        public string AuthorizationRuleId { get; set; }

        /// <summary>
        /// <para>The filter conditions.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<ListAuthorizationResourcesRequestFilter> Filter { get; set; }
        public class ListAuthorizationResourcesRequestFilter : TeaModel {
            /// <summary>
            /// <para>The name of the filter field. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>AuthorizationResourceEntityType: the resource entity type associated with the authorization resource.</para>
            /// </description></item>
            /// <item><description><para>AuthorizationResourceEntityId: the resource entity ID associated with the authorization resource.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AuthorizationResourceEntityId</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The values of the filter field.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page.</para>
        /// <list type="bullet">
        /// <item><description><para>Default value: 20.</para>
        /// </description></item>
        /// <item><description><para>Maximum value: 100.</para>
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
        /// <para>The token that identifies the start position of the next page.</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter, the query starts from the first page.</description></item>
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
