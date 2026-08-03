// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ModifyMountTargetRequest : TeaModel {
        /// <summary>
        /// <para>The permission group attached to the mount target.</para>
        /// 
        /// <b>Example:</b>
        /// <para>classic-test</para>
        /// </summary>
        [NameInMap("AccessGroupName")]
        [Validation(Required=false)]
        public string AccessGroupName { get; set; }

        /// <summary>
        /// <para>Specifies whether the VPC mount target supports access only through access points. This parameter applies only to CPFS for Lingjun file systems.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AccessPointAccessOnly")]
        [Validation(Required=false)]
        public bool? AccessPointAccessOnly { get; set; }

        /// <summary>
        /// <para>The IPv4/IPv6 dual-stack mount target.</para>
        /// <remarks>
        /// <para>Currently, only Extreme NAS in regions in the Chinese mainland supports IPv6.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>174494b666-x****.dualstack.cn-hangzhou.nas.aliyuncs.com</para>
        /// </summary>
        [NameInMap("DualStackMountTargetDomain")]
        [Validation(Required=false)]
        public string DualStackMountTargetDomain { get; set; }

        /// <summary>
        /// <para>The file system ID.</para>
        /// <list type="bullet">
        /// <item><description>General-purpose NAS: <c>31a8e4****</c>.</description></item>
        /// <item><description>Extreme NAS: Must start with <c>extreme-</c>, such as <c>extreme-0015****</c>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ca404****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The IPv4 mount target.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ca404a666-w****.cn-hangzhou.nas.aliyuncs.com</para>
        /// </summary>
        [NameInMap("MountTargetDomain")]
        [Validation(Required=false)]
        public string MountTargetDomain { get; set; }

        /// <summary>
        /// <para>The mount target status.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Active: active</description></item>
        /// <item><description>Inactive: inactive</description></item>
        /// </list>
        /// <remarks>
        /// <para>Only General-purpose NAS supports changing the mount target status.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Inactive</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
