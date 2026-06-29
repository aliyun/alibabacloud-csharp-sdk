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
        /// <para>This parameter is required if the file system is a General-purpose NAS or Extreme NAS file system.</para>
        /// <para>Default permission group: DEFAULT_VPC_GROUP_NAME (the default permission group for VPCs).</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-test</para>
        /// </summary>
        [NameInMap("AccessGroupName")]
        [Validation(Required=false)]
        public string AccessGroupName { get; set; }

        /// <summary>
        /// <para>Specifies whether to check for existing mount targets. Only CPFS file systems are supported.</para>
        /// <para>A dry run checks parameter validity and inventory without actually creating a mount target or incurring fees.</para>
        /// <list type="bullet">
        /// <item><description>true: sends a dry run request without creating a mount target. The check items include required parameters, request format, business limits, and CPFS inventory. If the check fails, the corresponding error is returned. If the check passes, <c>200 HttpCode</c> is returned, but <c>MountTargetDomain</c> is empty.</description></item>
        /// <item><description>false (default): sends a normal request. After the check passes, a mount target is created.</description></item>
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
        /// <item><description>true: creates an IPv6 mount target.</description></item>
        /// <item><description>false (default): does not create an IPv6 mount target.</description></item>
        /// </list>
        /// <remarks>
        /// <para>IPv6 is supported only by Extreme NAS file systems in all regions in the Chinese mainland. The file system must have IPv6 enabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableIpv6")]
        [Validation(Required=false)]
        public bool? EnableIpv6 { get; set; }

        /// <summary>
        /// <para>The file system ID.</para>
        /// <list type="bullet">
        /// <item><description><para>General-purpose NAS: 31a8e4\<em>\</em>\<em>\</em>.</para>
        /// </description></item>
        /// <item><description><para>Extreme NAS: The ID must start with <c>extreme-</c>, such as extreme-0015\<em>\</em>\<em>\</em>.</para>
        /// </description></item>
        /// <item><description><para>Cloud Parallel File Storage (CPFS): The ID must start with <c>cpfs-</c>, such as cpfs-125487\<em>\</em>\<em>\</em>.</para>
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
        /// <para>The security group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp1fg655nh68xyz9****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// <para>This parameter is required and valid only when the network type is VPC.
        /// For example:
        /// If NetworkType is set to VPC, VSwitchId is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-2zevmwkwyztjuoffg****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The VPC ID.</para>
        /// <para>This parameter is required and valid only when the network type is VPC.
        /// For example:
        /// If NetworkType is set to VPC, VpcId is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2zesj9afh3y518k9o****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
