// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class StartTaskForDistributeImageRequest : TeaModel {
        /// <summary>
        /// <para>The regions to which you want to replicate the image.</para>
        /// </summary>
        [NameInMap("DestinationRegionList")]
        [Validation(Required=false)]
        public List<string> DestinationRegionList { get; set; }

        /// <summary>
        /// <para>The image ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>imgc-07jyldnd9i*****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The product type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CloudDesktop: Elastic Desktop Service</description></item>
        /// <item><description>CloudApp: App Streaming</description></item>
        /// <item><description>WuyingServer: Workstation</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>This parameter is not publicly available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RETRY</para>
        /// </summary>
        [NameInMap("RetryType")]
        [Validation(Required=false)]
        public string RetryType { get; set; }

        /// <summary>
        /// <para>The region where the source image is located. If you leave this parameter empty, a random region is selected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("SourceRegion")]
        [Validation(Required=false)]
        public string SourceRegion { get; set; }

        /// <summary>
        /// <para>The ID of the image version. If you do not specify this parameter, the latest image version is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iv-07jyldnd9i****</para>
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}
