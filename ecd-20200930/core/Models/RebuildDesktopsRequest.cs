// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class RebuildDesktopsRequest : TeaModel {
        [NameInMap("AfterStatus")]
        [Validation(Required=false)]
        public string AfterStatus { get; set; }

        /// <summary>
        /// <para>The IDs of the cloud computers to rebuild. You can specify 1 to 20 IDs.</para>
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

        /// <summary>
        /// <para>The operating system language. This parameter applies only to system images. For Linux cloud computers, only English is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en-US</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>Specifies how to handle the data disk.</para>
        /// <remarks>
        /// <para>This parameter is optional.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If a cloud computer does not have a data disk, this parameter is ignored.<br></para>
        /// </description></item>
        /// <item><description><para>If a cloud computer has a data disk:</para>
        /// <ol>
        /// <item><description><para>If the new image has the same operating system as the original one:</para>
        /// <list type="bullet">
        /// <item><description><para>If you set this parameter to <c>replace</c>, the data disk is replaced.</para>
        /// </description></item>
        /// <item><description><para>If you do not specify this parameter, the data disk is retained.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If the new image has a different operating system:</para>
        /// <list type="bullet">
        /// <item><description><para>If you set this parameter to <c>replace</c>, the data disk is replaced.</para>
        /// </description></item>
        /// <item><description><para>If you do not specify this parameter, the data disk is erased.</para>
        /// </description></item>
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
        /// <para>The region ID. You can call the <a href="~~DescribeRegions~~">DescribeRegions</a> operation to find the regions where Elastic Desktop Service is available.</para>
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
