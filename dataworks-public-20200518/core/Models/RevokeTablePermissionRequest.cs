// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class RevokeTablePermissionRequest : TeaModel {
        /// <summary>
        /// <para>The permissions that you want to revoke. Separate multiple permissions with commas (,). You can revoke only the SELECT, DESCRIBE, and DOWNLOAD permissions on MaxCompute tables.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Select,Describe</para>
        /// </summary>
        [NameInMap("Actions")]
        [Validation(Required=false)]
        public string Actions { get; set; }

        /// <summary>
        /// <para>The name of the MaxCompute project to which the table belongs. You can log on to the DataWorks console and go to the SettingCenter page to obtain the name of the MaxCompute project that you associate with the workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aMaxcomputeProjectName</para>
        /// </summary>
        [NameInMap("MaxComputeProjectName")]
        [Validation(Required=false)]
        public string MaxComputeProjectName { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account from which you want to revoke permissions. You can log on to the DataWorks console and go to the Security Settings page to obtain the ID. You must specify either this parameter or the RevokeUserName parameter. If you specify both this parameter and the RevokeUserName parameter and the parameter values are different, the value of this parameter prevails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>267842600408993176</para>
        /// </summary>
        [NameInMap("RevokeUserId")]
        [Validation(Required=false)]
        public string RevokeUserId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account from which you want to revoke permissions. Specify this parameter in the format that is the same as the format of the account used to access the MaxCompute project.</para>
        /// <list type="bullet">
        /// <item><description>If the account is an Alibaba Cloud account, the value is in the ALIYUN$+Account name format.</description></item>
        /// <item><description>If the account is a RAM user, the value is in the RAM$+Account name format.</description></item>
        /// </list>
        /// <para>You must specify either this parameter or the RevokeUserId parameter. If you specify both this parameter and the RevokeUserId parameter and the parameter values are different, the value of the RevokeUserId parameter prevails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RAM$dataworks_3h1_1:stsramuser</para>
        /// </summary>
        [NameInMap("RevokeUserName")]
        [Validation(Required=false)]
        public string RevokeUserName { get; set; }

        /// <summary>
        /// <para>The name of the MaxCompute table. You can call the <a href="https://help.aliyun.com/document_detail/173919.html">SearchMetaTables</a> operation to query the name of the MaxCompute table.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aTableName</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace with which the MaxCompute project is associated. You can log on to the DataWorks console and go to the Workspace page to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public long? WorkspaceId { get; set; }

    }

}
