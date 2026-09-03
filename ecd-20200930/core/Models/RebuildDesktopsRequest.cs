// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class RebuildDesktopsRequest : TeaModel {
        /// <summary>
        /// <para>The target status of the cloud computer after the rebuild is complete.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("AfterStatus")]
        [Validation(Required=false)]
        public string AfterStatus { get; set; }

        /// <summary>
        /// <para>The cloud computer ID. You can specify 1 to 20 IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-gx2x1dhsmucyy****</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public List<string> DesktopId { get; set; }

        /// <summary>
        /// <para>The ID of the new image to use after the change.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-84mztzatmlnys****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The operating system language. Currently, only system images are supported, and Linux computers only support English.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en-US</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The operation type for the data cloud disk.</para>
        /// <remarks>
        /// <para>Regardless of whether the cloud computer has a data cloud disk, no field value is passed in by default when you call this operation.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If the cloud computer has no data cloud disk:<br>  No data cloud disk operation is performed regardless of the field value passed in.</description></item>
        /// <item><description>If the cloud computer has a data cloud disk:<ol>
        /// <item><description>When the operating system of the cloud computer is the same as that of the target image:<list type="bullet">
        /// <item><description>If the field value is <c>replace</c>, the data cloud disk of the cloud computer is replaced.</description></item>
        /// <item><description>If no field value is passed in, the original data cloud disk of the cloud computer is retained.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>When the operating system of the cloud computer is different from that of the target image:<list type="bullet">
        /// <item><description>If the field value is <c>replace</c>, the data cloud disk of the cloud computer is replaced.</description></item>
        /// <item><description>If no field value is passed in, the data cloud disk of the cloud computer is cleared.</description></item>
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
        /// <para>The region ID. You can call <a href="~~DescribeRegions~~">DescribeRegions</a> to query the list of regions supported by Elastic Desktop Service.</para>
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
