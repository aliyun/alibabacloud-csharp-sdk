// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class RevokeTablePermissionRequest : TeaModel {
        /// <summary>
        /// <para>The operation permissions on the table that you want to revoke. Separate multiple operation permissions with commas (,).</para>
        /// <para>Currently, only the Select, Describe, and Download operation permissions on MaxCompute tables can be revoked.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Select,Describe</para>
        /// </summary>
        [NameInMap("Actions")]
        [Validation(Required=false)]
        public string Actions { get; set; }

        /// <summary>
        /// <para>The name of the MaxCompute project that contains the table from which you want to revoke permissions. You can log on to the DataWorks console and go to the Workspace Settings page to obtain the name of the MaxCompute project associated with the DataWorks workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aMaxcomputeProjectName</para>
        /// </summary>
        [NameInMap("MaxComputeProjectName")]
        [Validation(Required=false)]
        public string MaxComputeProjectName { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID from which you want to revoke table permissions. You can logon to the DataWorks console and go to the Security Settings page to obtain the account ID.</para>
        /// <para>You only need to specify either this parameter or the RevokeUserName parameter. If both this parameter and the RevokeUserName parameter are specified in the parameter settings but have different values, the value of the RevokeUserId parameter takes precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>267842600408993176</para>
        /// </summary>
        [NameInMap("RevokeUserId")]
        [Validation(Required=false)]
        public string RevokeUserId { get; set; }

        /// <summary>
        /// <para>The name of the Alibaba Cloud account from which you want to revoke table permissions. The account format is the same as the account format used in MaxCompute.</para>
        /// <list type="bullet">
        /// <item><description>An Alibaba Cloud account is in the format of ALIYUN$+account name.</description></item>
        /// <item><description>A RAM user is in the format of RAM$+account name.</description></item>
        /// </list>
        /// <para>You only need to specify either this parameter or the RevokeUserId parameter. If both this parameter and the RevokeUserId parameter are specified in the parameter settings but have different values, the value of the RevokeUserId parameter takes precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RAM$dataworks_3h1_1:stsramuser</para>
        /// </summary>
        [NameInMap("RevokeUserName")]
        [Validation(Required=false)]
        public string RevokeUserName { get; set; }

        /// <summary>
        /// <para>The name of the MaxCompute table from which you want to revoke permissions. You can call the <a href="https://help.aliyun.com/document_detail/173919.html">SearchMetaTables</a> operation to obtain the MaxCompute table name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aTableName</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace to which the MaxCompute table belongs. You can log on to the DataWorks console and go to the Workspace Settings page to obtain the workspace ID.</para>
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
