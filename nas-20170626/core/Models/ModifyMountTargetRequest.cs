// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ModifyMountTargetRequest : TeaModel {
        /// <summary>
        /// <para>The name of the permission group that is attached to the mount target.</para>
        /// 
        /// <b>Example:</b>
        /// <para>classic-test</para>
        /// </summary>
        [NameInMap("AccessGroupName")]
        [Validation(Required=false)]
        public string AccessGroupName { get; set; }

        /// <summary>
        /// <para>The dual-stack (IPv4 and IPv6) domain name of the mount target.</para>
        /// <remarks>
        /// <para> Only Extreme NAS file systems that reside in the Chinese mainland support IPv6.</para>
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
        /// <item><description>Sample ID of a General-purpose NAS file system: <c>31a8e4****</c>.</description></item>
        /// <item><description>The IDs of Extreme NAS file systems must start with <c>extreme-</c>, for example, <c>extreme-0015****</c>.</description></item>
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
        /// <para>The IPv4 domain name of the mount target.</para>
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
        /// <item><description>Active: The mount target is available.</description></item>
        /// <item><description>Inactive: The mount target is unavailable.</description></item>
        /// </list>
        /// <remarks>
        /// <para> Only General-purpose File Storage NAS (NAS) file systems support changing the mount target status.</para>
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
