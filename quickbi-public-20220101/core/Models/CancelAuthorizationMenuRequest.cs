// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class CancelAuthorizationMenuRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the data portal.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0d173abb53e84c8ca7495429163b****</para>
        /// </summary>
        [NameInMap("DataPortalId")]
        [Validation(Required=false)]
        public string DataPortalId { get; set; }

        /// <summary>
        /// <para>The leaf node menu IDs of the data portal.</para>
        /// <list type="bullet">
        /// <item><description>Supports batch parameters, with IDs separated by commas (,). The maximum number for batch modification is 100.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54kqgoa****,pg1n135****</para>
        /// </summary>
        [NameInMap("MenuIds")]
        [Validation(Required=false)]
        public string MenuIds { get; set; }

        /// <summary>
        /// <para>List of user group IDs.</para>
        /// <list type="bullet">
        /// <item><description>Supports batch parameters, with IDs separated by commas (,). The maximum number for batch modification is 200.</description></item>
        /// <item><description>UserGroupIds and UserIds cannot both be empty.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>34fd141d-4598-4093-8c33-8e066dcb****,3d2c23d4-2b41-4af8-a1f5-f6390f32****</para>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public string UserGroupIds { get; set; }

        /// <summary>
        /// <para>List of user IDs. These are Quick BI UserIDs, not Alibaba Cloud UIDs.</para>
        /// <list type="bullet">
        /// <item><description>Supports batch parameters, with IDs separated by commas (,). The maximum number for batch modification is 200.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>204627493484****,121344444790****</para>
        /// </summary>
        [NameInMap("UserIds")]
        [Validation(Required=false)]
        public string UserIds { get; set; }

    }

}
