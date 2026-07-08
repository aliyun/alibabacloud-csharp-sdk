// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class CreateDataPermissionsRequest : TeaModel {
        /// <summary>
        /// <para>A unique identifier for the permission.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SystemSearch.QuarkCommonNews</para>
        /// </summary>
        [NameInMap("DataId")]
        [Validation(Required=false)]
        public string DataId { get; set; }

        /// <summary>
        /// <para>The permission type. Currently, only \<c>dataset\\</c> is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dataset</para>
        /// </summary>
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>The users to whom you want to assign permissions.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("PermissionUserInfos")]
        [Validation(Required=false)]
        public List<CreateDataPermissionsRequestPermissionUserInfos> PermissionUserInfos { get; set; }
        public class CreateDataPermissionsRequestPermissionUserInfos : TeaModel {
            /// <summary>
            /// <para>The user ID.</para>
            /// <list type="bullet">
            /// <item><description><para>For a RAM user: The ID of the RAM user.</para>
            /// </description></item>
            /// <item><description><para>For a role user: The user identity in the format AssumedRoleUser${roleId}.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PermissionUserId")]
            [Validation(Required=false)]
            public string PermissionUserId { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("PermissionUsername")]
            [Validation(Required=false)]
            public string PermissionUsername { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier of the Alibaba Cloud Model Studio workspace. For more information, see <a href="https://help.aliyun.com/document_detail/2587495.html">Get workspaceId</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-xxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
