// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeMountTargetsRequest : TeaModel {
        /// <summary>
        /// <para>The IPv4 and IPv6 dual-stack mount target.</para>
        /// <remarks>
        /// <para>Currently, only Extreme NAS in regions in the Chinese mainland supports IPv6.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1ca404****-x****.dualstack.cn-hangzhou.nas.aliyuncs.com</para>
        /// </summary>
        [NameInMap("DualStackMountTargetDomain")]
        [Validation(Required=false)]
        public string DualStackMountTargetDomain { get; set; }

        /// <summary>
        /// <para>The file system ID.</para>
        /// <list type="bullet">
        /// <item><description><para>General-purpose NAS: 31a8e4\<em>\</em>\<em>\</em>.</para>
        /// </description></item>
        /// <item><description><para>Extreme NAS: must start with <c>extreme-</c>, for example, extreme-0015\<em>\</em>\<em>\</em>.</para>
        /// </description></item>
        /// <item><description><para>CPFS: must start with <c>cpfs-</c>, for example, cpfs-125487\<em>\</em>\<em>\</em>.</para>
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
        /// <para>The mount target address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ca404****-x****.cn-hangzhou.nas.aliyuncs.com</para>
        /// </summary>
        [NameInMap("MountTargetDomain")]
        [Validation(Required=false)]
        public string MountTargetDomain { get; set; }

        /// <summary>
        /// <para>The page number of the list.</para>
        /// <para>Start value (default value): 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of mount targets on each page.</para>
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
