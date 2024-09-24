// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the image.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeImageInstances~~">DescribeImageInstances</a> operation to query the IDs of instances.</para>
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
        /// <para> You can call the <a href="~~DescribeImageInstances~~">DescribeImageInstances</a> operation to query the IDs of regions.</para>
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
        /// <para>The ID of the image repository.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeImageInstances~~">DescribeImageInstances</a> operation to query the IDs of image repositories.</para>
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
        /// <para>The tag that is added to the image.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeImageInstances~~">DescribeImageInstances</a> operation to query tags.</para>
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
