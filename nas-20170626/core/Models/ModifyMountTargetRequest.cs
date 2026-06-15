// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ModifyMountTargetRequest : TeaModel {
        /// <summary>
        /// <para>The name of the access group that is associated with the mount target.</para>
        /// 
        /// <b>Example:</b>
        /// <para>classic-test</para>
        /// </summary>
        [NameInMap("AccessGroupName")]
        [Validation(Required=false)]
        public string AccessGroupName { get; set; }

        [NameInMap("AccessPointAccessOnly")]
        [Validation(Required=false)]
        public bool? AccessPointAccessOnly { get; set; }

        /// <summary>
        /// <para>The domain name of the dual-stack mount target.</para>
        /// <remarks>
        /// <para>The IPv6 feature is available only for Extreme NAS file systems in the Chinese mainland.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>174494b666-x****.dualstack.cn-hangzhou.nas.aliyuncs.com</para>
        /// </summary>
        [NameInMap("DualStackMountTargetDomain")]
        [Validation(Required=false)]
        public string DualStackMountTargetDomain { get; set; }

        /// <summary>
        /// <para>The ID of the file system.</para>
        /// <list type="bullet">
        /// <item><description><para>For a General-purpose NAS file system, the ID is similar to <c>31a8e4****</c>.</para>
        /// </description></item>
        /// <item><description><para>For an Extreme NAS file system, the ID must start with <c>extreme-</c>, for example, <c>extreme-0015****</c>.</para>
        /// </description></item>
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
        /// <para>The domain name of the IPv4 mount target.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ca404a666-w****.cn-hangzhou.nas.aliyuncs.com</para>
        /// </summary>
        [NameInMap("MountTargetDomain")]
        [Validation(Required=false)]
        public string MountTargetDomain { get; set; }

        /// <summary>
        /// <para>The status of the mount target.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Active: The mount target is available.</para>
        /// </description></item>
        /// <item><description><para>Inactive: The mount target is unavailable.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You can change the status of a mount target only if the mount target is attached to a General-purpose NAS file system.</para>
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
