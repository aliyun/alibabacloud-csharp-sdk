// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class AuthorizeMenuRequest : TeaModel {
        /// <summary>
        /// <para>Authorizes the permissions of the menu. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: view</description></item>
        /// <item><description>3: View + Export (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("AuthPointsValue")]
        [Validation(Required=false)]
        public int? AuthPointsValue { get; set; }

        /// <summary>
        /// <para>The ID of the BI portal.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0d173abb53e84c8ca7495429163b****</para>
        /// </summary>
        [NameInMap("DataPortalId")]
        [Validation(Required=false)]
        public string DataPortalId { get; set; }

        /// <summary>
        /// <para>The menu ID of the BI portal leaf node.</para>
        /// <list type="bullet">
        /// <item><description>The directory menu cannot be authorized.</description></item>
        /// <item><description>You can upload multiple parameters at a time. Separate multiple IDs with commas (,). The maximum number of parameters that can be modified at a time is 100.</description></item>
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
        /// <para>The IDs of the user groups.</para>
        /// <list type="bullet">
        /// <item><description>You can upload multiple parameters at a time. Separate multiple IDs with commas (,). The maximum number of parameters that can be modified at a time is 200.</description></item>
        /// <item><description>UserGroupIds and UserIds cannot be empty at the same time</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>34fd141d-4598-4093-8c33-8e066dcb****,3d2c23d4-2b41-4af8-a1f5-f6390f32****</para>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public string UserGroupIds { get; set; }

        /// <summary>
        /// <para>The IDs of the end users. The UserID of the Quick BI is used instead of the UID of Alibaba Cloud.</para>
        /// <list type="bullet">
        /// <item><description>You can upload multiple parameters at a time. Separate multiple IDs with commas (,). The maximum number of parameters that can be modified at a time is 200.</description></item>
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
