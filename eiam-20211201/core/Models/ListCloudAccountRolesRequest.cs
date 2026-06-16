// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListCloudAccountRolesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Alibaba Cloud account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca_01kmegjc11qa1txxxxx</para>
        /// </summary>
        [NameInMap("CloudAccountId")]
        [Validation(Required=false)]
        public string CloudAccountId { get; set; }

        /// <summary>
        /// <para>The filter conditions.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<ListCloudAccountRolesRequestFilter> Filter { get; set; }
        public class ListCloudAccountRolesRequestFilter : TeaModel {
            /// <summary>
            /// <para>The name of the filter field. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>CloudAccountRoleId: The ID of the cloud role.</para>
            /// </description></item>
            /// <item><description><para>CloudAccountRoleName: The name of the cloud role.</para>
            /// </description></item>
            /// <item><description><para>CloudAccountRoleExternalId: The external ID of the cloud role.</para>
            /// </description></item>
            /// <item><description><para>CloudAccountRoleUsageType: The usage type of the cloud role.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CloudAccountRoleId</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The list of values for the filter field.</para>
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
        /// <para>The maximum number of records to return on each page.</para>
        /// <list type="bullet">
        /// <item><description><para>The default value is 20.</para>
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
        /// <para>The token that specifies the start of the next page of results.</para>
        /// <list type="bullet">
        /// <item><description>If this parameter is not specified, the query starts from the first page.</description></item>
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
