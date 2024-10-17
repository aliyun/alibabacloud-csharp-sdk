// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateAccessPointRequest : TeaModel {
        /// <summary>
        /// <para>The name of the permission group.</para>
        /// <para>This parameter is required for a General-purpose Apsara File Storage NAS (NAS) file system.</para>
        /// <para>The default permission group for virtual private clouds (VPCs) is named DEFAULT_VPC_GROUP_NAME.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DEFAULT_VPC_GROUP_NAME</para>
        /// </summary>
        [NameInMap("AccessGroup")]
        [Validation(Required=false)]
        public string AccessGroup { get; set; }

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
        /// <para>Specifies whether to enable the RAM policy. Valid values:</para>
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
        /// <para>31a8e4****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The ID of the owner group.</para>
        /// <para>This parameter is required if the RootDirectory directory does not exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OwnerGroupId")]
        [Validation(Required=false)]
        public int? OwnerGroupId { get; set; }

        /// <summary>
        /// <para>The owner ID.</para>
        /// <para>This parameter is required if the RootDirectory directory does not exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OwnerUserId")]
        [Validation(Required=false)]
        public int? OwnerUserId { get; set; }

        /// <summary>
        /// <para>The Portable Operating System Interface for UNIX (POSIX) permission. Default value: 0777.</para>
        /// <para>This field takes effect only if you specify the OwnerUserId and OwnerGroupId parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0777</para>
        /// </summary>
        [NameInMap("Permission")]
        [Validation(Required=false)]
        public string Permission { get; set; }

        /// <summary>
        /// <para>The ID of the POSIX user group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("PosixGroupId")]
        [Validation(Required=false)]
        public int? PosixGroupId { get; set; }

        /// <summary>
        /// <para>The secondary user group. Separate multiple user group IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>123,345</para>
        /// </summary>
        [NameInMap("PosixSecondaryGroupIds")]
        [Validation(Required=false)]
        public string PosixSecondaryGroupIds { get; set; }

        /// <summary>
        /// <para>The ID of the POSIX user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("PosixUserId")]
        [Validation(Required=false)]
        public int? PosixUserId { get; set; }

        /// <summary>
        /// <para>The root directory of the access point. The default value is /. If the directory does not exist, you must also specify the OwnerUserId and OwnerGroupId parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("RootDirectory")]
        [Validation(Required=false)]
        public string RootDirectory { get; set; }

        /// <summary>
        /// <para>The VPC ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2zesj9afh3y518k9o****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-2zevmwkwyztjuoffg****</para>
        /// </summary>
        [NameInMap("VswId")]
        [Validation(Required=false)]
        public string VswId { get; set; }

    }

}
