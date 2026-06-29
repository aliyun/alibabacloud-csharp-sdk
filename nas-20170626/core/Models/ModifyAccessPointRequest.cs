// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ModifyAccessPointRequest : TeaModel {
        /// <summary>
        /// <para>The permission group name.</para>
        /// <para>This parameter is required when the file system is a General-purpose NAS file system.</para>
        /// <para>Default permission group: DEFAULT_VPC_GROUP_NAME (the default VPC permission group).</para>
        /// <remarks>
        /// <para>Agentic file systems do not support this parameter.</para>
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
        /// <item><description>false (default): Not enabled.</description></item>
        /// </list>
        /// <remarks>
        /// <para>After you enable the access point RAM policy, all Resource Access Management (RAM) users are denied access to mount and access data through the access point by default. You must grant the corresponding access permissions through authorization and mount and access data through the access point. After you disable the RAM policy, the access point allows anonymity mounting.</para>
        /// </remarks>
        /// <remarks>
        /// <para>Agentic file systems do not support this parameter.</para>
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
