// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageRequest : TeaModel {
        /// <summary>
        /// <para>The image instance ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeImageInstances~~">DescribeImageInstances</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-hfs6gaawhyu6****</para>
        /// </summary>
        [NameInMap("ImageInstanceId")]
        [Validation(Required=false)]
        public string ImageInstanceId { get; set; }

        /// <summary>
        /// <para>The region ID of the image.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeImageInstances~~">DescribeImageInstances</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ImageRegionId")]
        [Validation(Required=false)]
        public string ImageRegionId { get; set; }

        /// <summary>
        /// <para>The image repository ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeImageInstances~~">DescribeImageInstances</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crr-7i88t7lx3fmf****</para>
        /// </summary>
        [NameInMap("ImageRepoId")]
        [Validation(Required=false)]
        public string ImageRepoId { get; set; }

        /// <summary>
        /// <para>The image tag.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeImageInstances~~">DescribeImageInstances</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.8.0.15</para>
        /// </summary>
        [NameInMap("ImageTag")]
        [Validation(Required=false)]
        public string ImageTag { get; set; }

    }

}
