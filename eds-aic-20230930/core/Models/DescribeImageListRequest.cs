// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeImageListRequest : TeaModel {
        [NameInMap("ImageBizTags")]
        [Validation(Required=false)]
        public List<DescribeImageListRequestImageBizTags> ImageBizTags { get; set; }
        public class DescribeImageListRequestImageBizTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>imgc-075cllfeuazh0****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The name of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Android 12 image</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>Image package type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VM</para>
        /// </summary>
        [NameInMap("ImagePackageType")]
        [Validation(Required=false)]
        public string ImagePackageType { get; set; }

        /// <summary>
        /// <para>The type of the image.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>User: custom images.</description></item>
        /// <item><description>System: system images.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>System</para>
        /// </summary>
        [NameInMap("ImageType")]
        [Validation(Required=false)]
        public string ImageType { get; set; }

        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. If the parameter is left empty, the data is queried from the first entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6kw9dGL5jves2FS9RLq****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The state of the image.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AVAILABLE: The image is available.</description></item>
        /// <item><description>DELETE: The image is deleted.</description></item>
        /// <item><description>INIT: The image is being initialized.</description></item>
        /// <item><description>CREATE_FAILED: The image failed to be created.</description></item>
        /// <item><description>CREATING: The image is being created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AVAILABLE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
