// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateMountTargetRequest : TeaModel {
        /// <summary>
        /// <para>The name of the permission group.</para>
        /// <para>This parameter is required if you create a mount target for a General-purpose NAS file system or an Extreme NAS file system.</para>
        /// <para>The default permission group for virtual private clouds (VPCs) is named DEFAULT_VPC_GROUP_NAME.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-test</para>
        /// </summary>
        [NameInMap("AccessGroupName")]
        [Validation(Required=false)]
        public string AccessGroupName { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run to check for existing mount targets. This parameter is valid only for CPFS file systems.</para>
        /// <para>If you set this parameter to true, the system checks whether the request parameters are valid and whether the requested resources are available. In this case, no mount target is created and no fee is incurred.</para>
        /// <list type="bullet">
        /// <item><description>true: performs a dry run but does not create a mount target. In the dry run, the system checks the request format, service limits, available CPFS resources, and whether the required parameters are specified. If the request fails the dry run, an error message is returned. If the request passes the dry run, the HTTP status code <c>200</c> is returned. No value is returned for the <c>MountTargetDomain</c> parameter.</description></item>
        /// <item><description>false (default): sends the request. If the request passes the dry run, a mount target is created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to create an IPv6 domain name for the mount target.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: An IPv6 domain name is created for the mount target.</description></item>
        /// <item><description>false (default): No IPv6 domain name is created for the mount target.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Only Extreme NAS file systems that reside in the Chinese mainland support IPv6. If you want to create an IPv6 domain name for the mount target, you must enable IPv6 for the file system.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableIpv6")]
        [Validation(Required=false)]
        public bool? EnableIpv6 { get; set; }

        /// <summary>
        /// <para>The ID of the file system.</para>
        /// <list type="bullet">
        /// <item><description>Sample ID of a General-purpose NAS file system: 31a8e4\<em>\</em>\<em>\</em>.</description></item>
        /// <item><description>The IDs of Extreme NAS file systems must start with <c>extreme-</c>, for example, extreme-0015\<em>\</em>\<em>\</em>.</description></item>
        /// <item><description>The IDs of Cloud Parallel File Storage (CPFS) file systems must start with <c>cpfs-</c>, for example, cpfs-125487\<em>\</em>\<em>\</em>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>CPFS file systems are available only on the China site (aliyun.com).</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>174494****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The network type of the mount target. Valid value: <b>Vpc</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Vpc</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>The ID of the security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp1fg655nh68xyz9****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch.</para>
        /// <para>This parameter is valid and required if the mount target resides in a VPC. Example: If you set the NetworkType parameter to VPC, you must specify the VSwitchId parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-2zevmwkwyztjuoffg****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC.</para>
        /// <para>This parameter is valid and required if the mount target resides in a VPC. Example: If you set the NetworkType parameter to VPC, you must specify the VpcId parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2zesj9afh3y518k9o****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
