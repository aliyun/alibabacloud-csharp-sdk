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
        /// <para>This parameter is required for a General-purpose Apsara File Storage NAS (NAS) file system.</para>
        /// <para>The default permission group for virtual private clouds (VPCs) is named DEFAULT_VPC_GROUP_NAME.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DEFAULT_VPC_GROUP_NAME</para>
        /// </summary>
        [NameInMap("AccessGroup")]
        [Validation(Required=false)]
        public string AccessGroup { get; set; }

        /// <summary>
        /// <para>The ID of the access point.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ap-ie15yd****</para>
        /// </summary>
        [NameInMap("AccessPointId")]
        [Validation(Required=false)]
        public string AccessPointId { get; set; }

        /// <summary>
        /// <para>The name of the access point.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("AccessPointName")]
        [Validation(Required=false)]
        public string AccessPointName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the Resource Access Management (RAM) policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The RAM policy is enabled.</description></item>
        /// <item><description>false (default): The RAM policy is disabled.</description></item>
        /// </list>
        /// <remarks>
        /// <para> After the RAM policy is enabled for access points, no RAM user is allowed to use access points to mount and access data by default. To use access points to mount and access data as a RAM user, you must grant the related access permissions to the RAM user. If the RAM policy is disabled, access points can be anonymously mounted.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnabledRam")]
        [Validation(Required=false)]
        public bool? EnabledRam { get; set; }

        /// <summary>
        /// <para>The ID of the file system.</para>
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
