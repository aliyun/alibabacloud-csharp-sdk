// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ResetDesktopsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the shared cloud desktop.</para>
        /// <list type="bullet">
        /// <item><description><para>If you specify <c>DesktopId</c>, the system ignores <c>DesktopGroupId</c>.</para>
        /// </description></item>
        /// <item><description><para>If <c>DesktopId</c> is empty, the system uses <c>DesktopGroupId</c> to retrieve the <c>DesktopId</c> of all cloud desktops in the shared cloud desktop group.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dg-07if7qsxoxkb6****</para>
        /// </summary>
        [NameInMap("DesktopGroupId")]
        [Validation(Required=false)]
        public string DesktopGroupId { get; set; }

        /// <summary>
        /// <para>A list of shared cloud desktop group IDs.</para>
        /// </summary>
        [NameInMap("DesktopGroupIds")]
        [Validation(Required=false)]
        public List<string> DesktopGroupIds { get; set; }

        /// <summary>
        /// <para>A list of cloud desktop IDs. You can specify 1 to 100 IDs.</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public List<string> DesktopId { get; set; }

        /// <summary>
        /// <para>The image ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-4zfb6zj728hhr****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("LastRetryTime")]
        [Validation(Required=false)]
        public long? LastRetryTime { get; set; }

        /// <summary>
        /// <para>The billing method.</para>
        /// <remarks>
        /// <para>This parameter applies only when resetting shared cloud desktops. If you leave it empty, the system resets all cloud desktops in the shared cloud desktop group, regardless of their billing method.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The region ID. Call <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> to list regions that support WUYING Workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The scope of the reset operation. Set this parameter to reset either the image or the cloud desktop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("ResetScope")]
        [Validation(Required=false)]
        public string ResetScope { get; set; }

        /// <summary>
        /// <para>The reset type. This determines whether to reset and which disks to reset.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ResetType")]
        [Validation(Required=false)]
        public string ResetType { get; set; }

    }

}
