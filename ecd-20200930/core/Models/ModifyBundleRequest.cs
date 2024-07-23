// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyBundleRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cloud computer template that you want to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b-2g65ljy4291vl****</para>
        /// </summary>
        [NameInMap("BundleId")]
        [Validation(Required=false)]
        public string BundleId { get; set; }

        /// <summary>
        /// <para>The name of the new cloud computer template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>newName</para>
        /// </summary>
        [NameInMap("BundleName")]
        [Validation(Required=false)]
        public string BundleName { get; set; }

        /// <summary>
        /// <para>The description of the new cloud computer template.</para>
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
        /// <item><description>The new image must be in the Available state.</description></item>
        /// <item><description>The operating system of the new image must be the same as that of the original image.</description></item>
        /// <item><description>The required disk size for the new image cannot be greater than that for the original image.</description></item>
        /// <item><description>The GPU type of the new image must be the same as that of the original image.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>m-aea3oaww001np****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The OS language. This parameter is available only for system images.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>en-US: American English</para>
        /// </description></item>
        /// <item><description><para>zh-HK: Traditional Chinese (Hong Kong)</para>
        /// </description></item>
        /// <item><description><para>zh-CN: Simplified Chinese.</para>
        /// </description></item>
        /// <item><description><para>ja-JP: Japanese</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

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
