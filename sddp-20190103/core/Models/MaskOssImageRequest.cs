// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class MaskOssImageRequest : TeaModel {
        /// <summary>
        /// <para>The name of the OSS bucket.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sddp-api-demo-bucket</para>
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// <para>Specifies whether to always upload the processed image.</para>
        /// <para>If you set this to false, the image is uploaded only if it matches a masking rule.</para>
        /// <para>If you set this to true, the processed image is always uploaded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsAlwaysUpload")]
        [Validation(Required=false)]
        public bool? IsAlwaysUpload { get; set; }

        [NameInMap("IsCoverObject")]
        [Validation(Required=false)]
        public bool? IsCoverObject { get; set; }

        /// <summary>
        /// <para>Specifies whether you can restore the original image from the masked version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSupportRestore")]
        [Validation(Required=false)]
        public bool? IsSupportRestore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>A comma-separated list of masking rule IDs.</para>
        /// <para>The following rule IDs correspond to the listed sensitive data types:</para>
        /// <para>3000: Images that contain ID card information (Chinese mainland)</para>
        /// <para>3009: Images that contain license plate information (Chinese mainland)</para>
        /// <para>3002: Images that contain faces</para>
        /// <para>1002: Names (Simplified Chinese)</para>
        /// <para>1003: Addresses (Chinese mainland)</para>
        /// <para>4003: Unified Social Credit Code</para>
        /// <para>63009: Images that contain eyes</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3000,3002</para>
        /// </summary>
        [NameInMap("MaskRuleIdList")]
        [Validation(Required=false)]
        public string MaskRuleIdList { get; set; }

        /// <summary>
        /// <para>The full key of the object stored in OSS.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dir1/test.png</para>
        /// </summary>
        [NameInMap("ObjectKey")]
        [Validation(Required=false)]
        public string ObjectKey { get; set; }

        /// <summary>
        /// <para>The region where the bucket is located.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ServiceRegionId")]
        [Validation(Required=false)]
        public string ServiceRegionId { get; set; }

    }

}
