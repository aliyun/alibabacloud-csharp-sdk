// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ModifyAccessPointRequest : TeaModel {
        /// <summary>
        /// <para>The name of the permission group.</para>
        /// <para>This parameter is required when the target file system is a General-purpose NAS file system.</para>
        /// <para>Default permission group: DEFAULT_VPC_GROUP_NAME (the default permission group for VPCs).</para>
        /// <remarks>
        /// <para>Not supported by Agentic file systems.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>DEFAULT_VPC_GROUP_NAME</para>
        /// </summary>
        [NameInMap("AccessGroup")]
        [Validation(Required=false)]
        public string AccessGroup { get; set; }

        /// <summary>
        /// <para>The access point ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ap-ie15yd****</para>
        /// </summary>
        [NameInMap("AccessPointId")]
        [Validation(Required=false)]
        public string AccessPointId { get; set; }

        /// <summary>
        /// <para>The access point name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("AccessPointName")]
        [Validation(Required=false)]
        public string AccessPointName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the RAM policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled.</description></item>
        /// <item><description>false: Disabled. This is the default value.</description></item>
        /// </list>
        /// <remarks>
        /// <para>After you enable the RAM policy for the access point, all Resource Access Management (RAM) users are denied from using the access point to mount and access data by default. You must grant authorization to the accounts to enable the corresponding access permissions, and mount the file system through the access point. If this feature is disabled, the access point allows anonymous mounting.</para>
        /// </remarks>
        /// <remarks>
        /// <para>Not supported by Agentic file systems.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnabledRam")]
        [Validation(Required=false)]
        public bool? EnabledRam { get; set; }

        /// <summary>
        /// <para>The file system ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ca404****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

    }

}
