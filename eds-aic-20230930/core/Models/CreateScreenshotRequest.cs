// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreateScreenshotRequest : TeaModel {
        /// <summary>
        /// <para>The list of instance IDs. Batch screenshots are supported.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AndroidInstanceIdList")]
        [Validation(Required=false)]
        public List<string> AndroidInstanceIdList { get; set; }

        /// <summary>
        /// <para>The custom OSS bucket. The bucket name must start with the cloudphone-saved-bucket- prefix. The cloud phone instance and the OSS bucket must be in the same region. If you leave this parameter empty, a default bucket named cloudphone-saved-bucket-{RegionOfCloudPhone}-{AliUid} is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloudphone-saved-bucket-cn-shanghai-default</para>
        /// </summary>
        [NameInMap("OssBucketName")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

        /// <summary>
        /// <para>The screenshot ID. The generated screenshot is named &quot;ScreenshotId_AndroidInstanceId.png.&quot;</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>The ScreenshotId must be 2 to 128 characters long, beginning with a letter, but cannot start with http\:// or https\://. Allowed characters include letters, digits, underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>image</para>
        /// </summary>
        [NameInMap("ScreenshotId")]
        [Validation(Required=false)]
        public string ScreenshotId { get; set; }

        /// <summary>
        /// <para>Specifies whether to skip the screenshot policy check. The default value is false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SkipCheckPolicyConfig")]
        [Validation(Required=false)]
        public string SkipCheckPolicyConfig { get; set; }

    }

}
