// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class RegisterMediaInfoRequest : TeaModel {
        /// <summary>
        /// <para>The business type of the media asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>subtitles</description></item>
        /// <item><description>watermark</description></item>
        /// <item><description>opening</description></item>
        /// <item><description>ending</description></item>
        /// <item><description>general</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>opening</para>
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
        /// <para>The client token that is used to ensure the idempotence of the request. The value must be a UUID that contains 32 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>0311a423d11a5f7dee713535</b></b></para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The thumbnail URL of the media asset.</para>
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
        /// <para>The description of the media asset.</para>
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
        /// <para>The URL of the media asset in another service. The URL is associated with the ID of the media asset in IMS. The URL cannot be modified once registered. The following types of URLs are supported:</para>
        /// <list type="bullet">
        /// <item><description>OSS URL in one of the following formats:</description></item>
        /// </list>
        /// <para>http(s)://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4</para>
        /// <para>oss://example-bucket/example.mp4: In this format, it is considered by default that the region of the OSS bucket in which the media asset resides is the same as the region in which IMS is activated.</para>
        /// <list type="bullet">
        /// <item><description>URL of an ApsaraVideo VOD media asset</description></item>
        /// </list>
        /// <para>vod://\<em>\</em>\<em>20b48fb04483915d4f2cd8ac\</em>\<em>\</em>\*</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InputURL")]
        [Validation(Required=false)]
        public string InputURL { get; set; }

        /// <summary>
        /// <para>The tags of the media asset.</para>
        /// <list type="bullet">
        /// <item><description>Up to 16 tags are supported.</description></item>
        /// <item><description>Separate multiple tags with commas (,).</description></item>
        /// <item><description>Each tag can be up to 32 bytes in length.</description></item>
        /// <item><description>The value must be encoded in UTF-8.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>tag1,tag2</para>
        /// </summary>
        [NameInMap("MediaTags")]
        [Validation(Required=false)]
        public string MediaTags { get; set; }

        /// <summary>
        /// <para>The type of the media asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>image</description></item>
        /// <item><description>video</description></item>
        /// <item><description>audio</description></item>
        /// <item><description>text</description></item>
        /// </list>
        /// <para>We recommend that you specify this parameter based on your business requirements. If you set InputURL to an OSS URL, the media asset type can be automatically determined based on the file name extension. For more information
        /// &lt;props=&quot;china&quot;&gt;, see <a href="https://help.aliyun.com/document_detail/466207.html">File formats</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>video</para>
        /// </summary>
        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public string MediaType { get; set; }

        /// <summary>
        /// <para>Specifies whether to overwrite the media asset that has been registered by using the same URL. Default value: false. Valid values:</para>
        /// <para>\- true: If a media asset has been registered by using the same URL, the original media asset is deleted and the new media asset is registered.</para>
        /// <para>\- false: If a media asset has been registered by using the same URL, the new media asset is not registered. A URL cannot be used to register multiple media assets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Overwrite")]
        [Validation(Required=false)]
        public bool? Overwrite { get; set; }

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
        /// <para>The registration configurations.</para>
        /// <para>By default, a sprite is generated for the media asset. You can set NeedSprite to false to disable automatic sprite generation.</para>
        /// <para>By default, a snapshot is generated for the media asset. You can set NeedSnapshot to false to disable automatic snapshot generation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;NeedSprite&quot;: &quot;false&quot;
        /// }</para>
        /// </summary>
        [NameInMap("RegisterConfig")]
        [Validation(Required=false)]
        public string RegisterConfig { get; set; }

        /// <summary>
        /// <para>The ID of the smart tagging template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>S00000101-300080: the system template that supports natural language processing (NLP) for content recognition.</description></item>
        /// <item><description>S00000103-000001: the system template that supports NLP for content recognition and all tagging capabilities.</description></item>
        /// <item><description>S00000103-000002: the system template that supports all tagging capabilities but does not support NLP for content recognition.</description></item>
        /// </list>
        /// <para>After you configure this parameter, a smart tag analysis task is automatically initiated after the media asset is registered. For more information about the billable items&lt;props=&quot;china&quot;&gt;, see <a href="https://help.aliyun.com/zh/ims/media-ai-billing?spm=a2c4g.11186623.0.0.3147392dWwlSjL#p-k38-3rb-dug">Smart tagging</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>S00000101-300080</para>
        /// </summary>
        [NameInMap("SmartTagTemplateId")]
        [Validation(Required=false)]
        public string SmartTagTemplateId { get; set; }

        /// <summary>
        /// <para>The title. If you do not specify this parameter, a default title is automatically generated based on the date.</para>
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
        /// <para>The user data. You can specify a custom callback URL. For more information&lt;props=&quot;china&quot;&gt; ,see <a href="https://help.aliyun.com/document_detail/451631.html">Configure a callback upon editing completion</a>.</para>
        /// <list type="bullet">
        /// <item><description>The value can be up to 1,024 bytes in length.</description></item>
        /// <item><description>The value must be encoded in UTF-8.</description></item>
        /// <item><description>The value must be in the JSON format.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The workflow ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>b4fb044839815d4f2cd8</b></b></b></para>
        /// </summary>
        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public string WorkflowId { get; set; }

    }

}
