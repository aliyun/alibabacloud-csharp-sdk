// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateMediaInfoRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to append tags. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: updates the MediaTags parameter by appending new tags.</description></item>
        /// <item><description>false: updates the MediaTags parameter by overwriting existing tags with new tags.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AppendTags")]
        [Validation(Required=false)]
        public bool? AppendTags { get; set; }

        /// <summary>
        /// <para>The business type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>subtitles</description></item>
        /// <item><description>watermark</description></item>
        /// <item><description>opening</description></item>
        /// <item><description>ending</description></item>
        /// <item><description>general</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>video</para>
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        /// <summary>
        /// <para>The category ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3048</para>
        /// </summary>
        [NameInMap("CateId")]
        [Validation(Required=false)]
        public long? CateId { get; set; }

        /// <summary>
        /// <para>The category.</para>
        /// <list type="bullet">
        /// <item><description>The value can be up to 64 bytes in length.</description></item>
        /// <item><description>The value must be encoded in UTF-8.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>defaultCategory</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The URL of the thumbnail.</para>
        /// <list type="bullet">
        /// <item><description>The value can be up to 128 bytes in length.</description></item>
        /// <item><description>The value must be encoded in UTF-8.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example-bucket.oss-cn-shanghai.aliyuncs.com/example.png">http://example-bucket.oss-cn-shanghai.aliyuncs.com/example.png</a></para>
        /// </summary>
        [NameInMap("CoverURL")]
        [Validation(Required=false)]
        public string CoverURL { get; set; }

        /// <summary>
        /// <para>The content description.</para>
        /// <list type="bullet">
        /// <item><description>The value can be up to 1,024 bytes in length.</description></item>
        /// <item><description>The value must be encoded in UTF-8.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>defaultDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The input URL of the media asset in another service. The URL must be bound to the ID of the media asset in IMS. The URL cannot be modified once registered.</para>
        /// <para>For a media asset from Object Storage Service (OSS), the URL may have one of the following formats:</para>
        /// <para>1\. http(s)://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4</para>
        /// <para>2\. oss://example-bucket/example.mp4. This format indicates that the region in which the OSS bucket of the media asset resides is the same as the region in which OSS is activated.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4">http://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4</a></para>
        /// </summary>
        [NameInMap("InputURL")]
        [Validation(Required=false)]
        public string InputURL { get; set; }

        /// <summary>
        /// <para>The ID of the media asset. If this parameter is left empty, you must specify the input URL of the media asset, which has been registered in the IMS content library.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// <list type="bullet">
        /// <item><description>Up to 16 tags are supported.</description></item>
        /// <item><description>Separate multiple tags with commas (,).</description></item>
        /// <item><description>Each tag can be up to 32 bytes in length.</description></item>
        /// <item><description>The value must be encoded in UTF-8.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>updateTags1,updateTags2</para>
        /// </summary>
        [NameInMap("MediaTags")]
        [Validation(Required=false)]
        public string MediaTags { get; set; }

        /// <summary>
        /// <para>The custom ID. The ID can be 6 to 64 characters in length and can contain only letters, digits, hyphens (-), and underscores (_). Make sure that the ID is unique among users.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123-123</para>
        /// </summary>
        [NameInMap("ReferenceId")]
        [Validation(Required=false)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// <para>The title.</para>
        /// <list type="bullet">
        /// <item><description>The value can be up to 128 bytes in length.</description></item>
        /// <item><description>The value must be encoded in UTF-8.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>defaultTitle</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The user data. It can be up to 1,024 bytes in size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>userData</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
