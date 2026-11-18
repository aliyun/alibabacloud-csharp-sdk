// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListCloudAccountsRequest : TeaModel {
        /// <summary>
        /// <para>The filter conditions.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<ListCloudAccountsRequestFilter> Filter { get; set; }
        public class ListCloudAccountsRequestFilter : TeaModel {
            /// <summary>
            /// <para>The name of the filter field. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CloudAccountId: the ID of the cloud account.</description></item>
            /// <item><description>CloudAccountExternalId: the external unique identifier of the cloud account.</description></item>
            /// <item><description>CloudAccountVendorType: the type of the cloud account.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CloudAccountId</para>
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
        /// <para>The maximum number of entries per page.</para>
        /// <list type="bullet">
        /// <item><description>If this parameter is not specified, the default value is 20.</description></item>
        /// <item><description>The maximum value is 100.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that specifies the starting position of the next page.</para>
        /// <list type="bullet">
        /// <item><description>If this parameter is not specified, the query starts from the first page by default.</description></item>
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
