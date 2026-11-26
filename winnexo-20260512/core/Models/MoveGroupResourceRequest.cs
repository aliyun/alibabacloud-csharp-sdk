// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class MoveGroupResourceRequest : TeaModel {
        /// <summary>
        /// <para>平台应用 Token（控制台签发）。传入后将以 opsUserId 或 opsUserCode 指定的用户身份执行</para>
        /// 
        /// <b>Example:</b>
        /// <para>wn_app_xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("appToken")]
        [Validation(Required=false)]
        public string AppToken { get; set; }

        /// <summary>
        /// <para>The collaboration space ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>group_example</para>
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>代理用户编码（租户内唯一），仅当应用凭证配置为 source_uid 时使用</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("opsUserCode")]
        [Validation(Required=false)]
        public string OpsUserCode { get; set; }

        /// <summary>
        /// <para>代理用户ID（WINNEXO 平台用户ID），仅当应用凭证配置为 winnexo_uid 时使用</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("opsUserId")]
        [Validation(Required=false)]
        public string OpsUserId { get; set; }

        /// <summary>
        /// <para>The real ID of the physical directory in the space where the resource currently resides. The root sentinel is not supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("sourceDirectoryId")]
        [Validation(Required=false)]
        public string SourceDirectoryId { get; set; }

        /// <summary>
        /// <para>The physical GROUP resource ID to be moved. Referenced resources are read-only.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("sourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The real ID of the target physical directory in the same space. This value must be different from the source directory ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("targetDirectoryId")]
        [Validation(Required=false)]
        public string TargetDirectoryId { get; set; }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter. If this parameter is not specified, the default tenant of the caller is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
