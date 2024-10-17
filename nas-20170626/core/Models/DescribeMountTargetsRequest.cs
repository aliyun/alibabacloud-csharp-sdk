// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeMountTargetsRequest : TeaModel {
        /// <summary>
        /// <para>The dual-stack (IPv4 and IPv6) domain name of the mount target.</para>
        /// <remarks>
        /// <para>Only Extreme NAS file systems that reside in the Chinese mainland support IPv6.</para>
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
        /// <para>1ca404****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The domain name of the mount target.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ca404a666-x****.cn-hangzhou.nas.aliyuncs.com</para>
        /// </summary>
        [NameInMap("MountTargetDomain")]
        [Validation(Required=false)]
        public string MountTargetDomain { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>Valid values: 1 to 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
