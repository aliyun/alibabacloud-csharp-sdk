// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class RebuildDesktopsRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the cloud computers. You can specify 1 to 20 IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-gx2x1dhsmucyy****</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public List<string> DesktopId { get; set; }

        /// <summary>
        /// <para>The ID of the new image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-84mztzatmlnys****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The operation type on the data disk.</para>
        /// <remarks>
        /// <para> This parameter is empty by default regardless of whether data disks are attached to the cloud computer.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>No data disks are attached to the cloud computer:\
        /// No operation is performed on the data disks of the cloud computer regardless of the value of this parameter.</para>
        /// </description></item>
        /// <item><description><para>Data disks are attached to the cloud computer:</para>
        /// <ol>
        /// <item><description><para>The OS of the cloud computer is the same as the OS of the destination image:</para>
        /// <list type="bullet">
        /// <item><description>If you set the OperateType parameter to <c>replace</c>, the data in the data disks of the cloud computer is replaced.</description></item>
        /// <item><description>If you leave the OperateType parameter empty, the data in the data disks of the cloud computer is retained.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>The OS of the cloud computer is different from the OS of the destination image:</para>
        /// <list type="bullet">
        /// <item><description>If you set the OperateType parameter to <c>replace</c>, the data in the data disks of the cloud computer is replaced.</description></item>
        /// <item><description>If you leave the OperateType parameter empty, the data in the data disks of the cloud computer is cleared.</description></item>
        /// </list>
        /// </description></item>
        /// </ol>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>replace</para>
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
