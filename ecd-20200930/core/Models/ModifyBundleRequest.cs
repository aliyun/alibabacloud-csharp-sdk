// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyBundleRequest : TeaModel {
        /// <summary>
        /// <para>The cloud computer template ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b-2g65ljy4291vl****</para>
        /// </summary>
        [NameInMap("BundleId")]
        [Validation(Required=false)]
        public string BundleId { get; set; }

        /// <summary>
        /// <para>The new cloud computer template name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>newName</para>
        /// </summary>
        [NameInMap("BundleName")]
        [Validation(Required=false)]
        public string BundleName { get; set; }

        /// <summary>
        /// <para>The new cloud computer template description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>newDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The new image ID. The new image must meet the following conditions:</para>
        /// <list type="bullet">
        /// <item><description><para>The new image must be in the Available state.</para>
        /// </description></item>
        /// <item><description><para>The new image must have the same operating system as the original image.</para>
        /// </description></item>
        /// <item><description><para>The disk size required by the new image cannot be larger than that of the original image.</para>
        /// </description></item>
        /// <item><description><para>The GPU type of the new image must be the same as that of the original image.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>m-aea3oaww001np****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The operating system language. Currently, only system images are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> to query the regions supported by Elastic Desktop Service.</para>
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
