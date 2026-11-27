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
        /// <para>This parameter is required when the target file system is a General-purpose NAS file system or an Extreme NAS file system.</para>
        /// <para>Default permission group: DEFAULT_VPC_GROUP_NAME (the default permission group for VPCs).</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-test</para>
        /// </summary>
        [NameInMap("AccessGroupName")]
        [Validation(Required=false)]
        public string AccessGroupName { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run to check for existing mount targets. Only CPFS file systems are supported.</para>
        /// <para>A dry run checks the validity of parameters and inventory without actually creating a mount target or incurring fees.</para>
        /// <list type="bullet">
        /// <item><description>true: Perform a dry run. No mount target is created. The system checks whether required parameters are specified, the request format, service limits, and CPFS inventory. If the dry run fails, the corresponding error is returned. If the dry run succeeds, the HTTP status code <c>200</c> is returned, but <c>MountTargetDomain</c> is empty.</description></item>
        /// <item><description>false: Perform a standard request. If the check succeeds, a mount target is directly created. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to create an IPv6 mount target.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Create an IPv6 mount target.</description></item>
        /// <item><description>false: Do not create an IPv6 mount target. This is the default value.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Currently, IPv6 is supported only for Extreme NAS file systems in regions in the Chinese mainland, and the IPv6 feature must be enabled for the file system.</para>
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
        /// <item><description><para>General-purpose NAS file system: 31a8e4****.</para>
        /// </description></item>
        /// <item><description><para>Extreme NAS file system: The ID must start with <c>extreme-</c>, for example, extreme-0015****.</para>
        /// </description></item>
        /// <item><description><para>Cloud Parallel File Storage (CPFS): The ID must start with <c>cpfs-</c>, for example, cpfs-125487****.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>174494****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The network type of the mount target. Set the value to <b>Vpc</b>, which indicates a virtual private cloud (VPC).</para>
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
        /// <para>This parameter is required and valid only when the network type is VPC.
        /// Example:
        /// When NetworkType is set to VPC, VSwitchId is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-2zevmwkwyztjuoffg****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC.</para>
        /// <para>This parameter is required and valid only when the network type is VPC.
        /// Example:
        /// When NetworkType is set to VPC, VpcId is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2zesj9afh3y518k9o****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
