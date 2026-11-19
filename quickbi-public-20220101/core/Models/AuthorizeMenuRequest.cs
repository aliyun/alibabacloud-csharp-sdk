// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class AuthorizeMenuRequest : TeaModel {
        /// <summary>
        /// <para>The permissions to grant for the menus. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: View.</description></item>
        /// <item><description>3: View and export. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("AuthPointsValue")]
        [Validation(Required=false)]
        public int? AuthPointsValue { get; set; }

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
        /// <para>The IDs of the leaf node menus in the data portal. You can specify multiple IDs. Separate multiple IDs with commas (,). You can specify up to 100 IDs at a time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54kqgoa****,pg1n135****</para>
        /// </summary>
        [NameInMap("MenuIds")]
        [Validation(Required=false)]
        public string MenuIds { get; set; }

        /// <summary>
        /// <para>The IDs of the user groups. You can specify multiple IDs. Separate multiple IDs with commas (,). You can specify up to 200 IDs at a time. You must specify at least one of UserGroupIds and UserIds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34fd141d-4598-4093-8c33-8e066dcb****,3d2c23d4-2b41-4af8-a1f5-f6390f32****</para>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public string UserGroupIds { get; set; }

        /// <summary>
        /// <para>The IDs of the users. These are Quick BI user IDs, not Alibaba Cloud UIDs. You can specify multiple IDs. Separate multiple IDs with commas (,). You can specify up to 200 IDs at a time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>204627493484****,121344444790****</para>
        /// </summary>
        [NameInMap("UserIds")]
        [Validation(Required=false)]
        public string UserIds { get; set; }

    }

}
