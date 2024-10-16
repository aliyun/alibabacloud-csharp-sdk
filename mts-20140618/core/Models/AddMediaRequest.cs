// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class AddMediaRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the category to which the media file belongs. The value cannot be negative.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("CateId")]
        [Validation(Required=false)]
        public long? CateId { get; set; }

        /// <summary>
        /// <para>The URL of the thumbnail. To obtain the URL, you can log on to the <b>MPS console</b> and choose <b>Workflows</b> &gt; <b>Media Buckets</b>. Alternatively, you can log on to the <b>OSS console</b> and click <b>My OSS Paths</b>.</para>
        /// <list type="bullet">
        /// <item><description>The value can be up to 3,200 bytes in length.</description></item>
        /// <item><description>The URL complies with RFC 2396 and is encoded in UTF-8, with reserved characters being percent-encoded. For more information, see <a href="https://help.aliyun.com/document_detail/423796.html">URL encoding</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://bucket.oss-cn-hangzhou.aliyuncs.com/example/1.png">http://bucket.oss-cn-hangzhou.aliyuncs.com/example/1.png</a></para>
        /// </summary>
        [NameInMap("CoverURL")]
        [Validation(Required=false)]
        public string CoverURL { get; set; }

        /// <summary>
        /// <para>The description of the media file.</para>
        /// <list type="bullet">
        /// <item><description>The description can be up to 1,024 bytes in length.</description></item>
        /// <item><description>The value must be encoded in UTF-8.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>A test video</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The URL of the input file. You can obtain the URL in the MPS or OSS console. For more information, see the <b>Triggering and matching rule for a workflow</b> section of this topic.</para>
        /// <list type="bullet">
        /// <item><description>Only OSS HTTP URLs are supported. Alibaba Cloud CDN URLs and HTTPS URLs are not supported.</description></item>
        /// <item><description>The value can be up to 3,200 bytes in size.</description></item>
        /// <item><description>The URL complies with RFC 2396 and is encoded in UTF-8. For more information, see <a href="https://help.aliyun.com/document_detail/423796.html">URL encoding</a>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://bucket.oss-cn-hangzhou.aliyuncs.com/A/B/C/test.mp4">http://bucket.oss-cn-hangzhou.aliyuncs.com/A/B/C/test.mp4</a></para>
        /// </summary>
        [NameInMap("FileURL")]
        [Validation(Required=false)]
        public string FileURL { get; set; }

        /// <summary>
        /// <para>Specifies whether to check if the media workflow supports the specified input path. We recommend that you set this parameter to true to prevent errors that may result from invalid paths. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: checks whether the workflow supports the specified input path.</description></item>
        /// <item><description><b>false</b>: does not check whether the workflow supports the specified input path.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("InputUnbind")]
        [Validation(Required=false)]
        public bool? InputUnbind { get; set; }

        /// <summary>
        /// <para>The ID of the media workflow that you want to run for the media file. To query the ID of a media workflow, you can log on to the MPS console or call the <a href="https://help.aliyun.com/document_detail/44437.html">AddMediaWorkflow</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>07da6c65da7f458997336e0de192****</para>
        /// </summary>
        [NameInMap("MediaWorkflowId")]
        [Validation(Required=false)]
        public string MediaWorkflowId { get; set; }

        /// <summary>
        /// <para>The custom data of the media workflow.</para>
        /// <list type="bullet">
        /// <item><description>The value can be up to 1,024 bytes in length.</description></item>
        /// <item><description>The value must be encoded in UTF-8.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("MediaWorkflowUserData")]
        [Validation(Required=false)]
        public string MediaWorkflowUserData { get; set; }

        /// <summary>
        /// <para>The subtitle settings that are used to overwrite the original settings.</para>
        /// <list type="bullet">
        /// <item><description>Example 1: Use <c>{&quot;WebVTTSubtitleOverrides&quot;,[{&quot;RefActivityName&quot;:&quot;subtitleNode&quot;,&quot;WebVTTSubtitleURL&quot;:&quot;http://test.oss-cn-hangzhou.aliyuncs.com/example1.vtt&quot;}]}</c> to overwrite the original subtitle settings during HTTP Live Streaming (HLS) packaging.</description></item>
        /// <item><description>Example 2: Use <c>{&quot;subtitleTransNodeName&quot;:{&quot;InputConfig&quot;:{&quot;Format&quot;:&quot;stl&quot;,&quot;InputFile&quot;:{&quot;URL&quot;:&quot;http://subtitleBucket.oss-cn-hangzhou.aliyuncs.com/package/example/CENG.stl&quot;}}}}</c> to overwrite the original subtitle settings during Dynamic Adaptive Streaming over HTTP (DASH) packaging.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{“subtitleTransNodeName”:{“InputConfig”:{“Format”:”stl”,”InputFile”:{“URL”:”<a href="http://exampleBucket.oss-cn-hangzhou.aliyuncs.com/package/example/CENG.stl%22%7D%7D%7D%7D">http://exampleBucket.oss-cn-hangzhou.aliyuncs.com/package/example/CENG.stl&quot;}}}}</a></para>
        /// </summary>
        [NameInMap("OverrideParams")]
        [Validation(Required=false)]
        public string OverrideParams { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The tags that you want to add to the media file.</para>
        /// <remarks>
        /// <para>In MPS, each tag that is specified for a media file is independent. You can search for all the media files that have the same tags in the Media Library.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You can specify up to 16 tags for a media file. Separate multiple tags with commas (,).</description></item>
        /// <item><description>Each tag can be up to 32 bytes in size</description></item>
        /// <item><description>The value must be encoded in UTF-8.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>tag1,tag2</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>The title of the media file.</para>
        /// <list type="bullet">
        /// <item><description>The title can be up to 128 bytes in length.</description></item>
        /// <item><description>The value must be encoded in UTF-8.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>mytest</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
