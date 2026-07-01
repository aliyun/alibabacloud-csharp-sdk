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
        /// <item><description><para>subtitles</para>
        /// </description></item>
        /// <item><description><para>watermark</para>
        /// </description></item>
        /// <item><description><para>opening</para>
        /// </description></item>
        /// <item><description><para>ending</para>
        /// </description></item>
        /// <item><description><para>general</para>
        /// </description></item>
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
        /// <item><description><para>The value can be up to 128 bytes in length.</para>
        /// </description></item>
        /// <item><description><para>The value must be encoded in UTF-8.</para>
        /// </description></item>
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
        /// <item><description><para>The value can be up to 1,024 bytes in length.</para>
        /// </description></item>
        /// <item><description><para>The value must be encoded in UTF-8.</para>
        /// </description></item>
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
        /// <item><description><para>OSS URL in one of the following formats:</para>
        /// <list type="bullet">
        /// <item><description><para><c>http(s)://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4</c></para>
        /// </description></item>
        /// <item><description><para><c>oss://example-bucket/example.mp4</c>: In this format, it is considered by default that the region of the OSS bucket in which the media asset resides is the same as the region in which IMS is activated.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>URL of an ApsaraVideo VOD media asset</para>
        /// <para><c>vod://***20b48fb04483915d4f2cd8ac****</c></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4">http://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4</a>  or  vod://<b><b>20b48fb04483915d4f2cd8ac</b></b></para>
        /// </summary>
        [NameInMap("InputURL")]
        [Validation(Required=false)]
        public string InputURL { get; set; }

        /// <summary>
        /// <para>The tags of the media asset.</para>
        /// <list type="bullet">
        /// <item><description><para>Up to 16 tags are supported.</para>
        /// </description></item>
        /// <item><description><para>Separate multiple tags with commas (,).</para>
        /// </description></item>
        /// <item><description><para>Each tag can be up to 32 bytes in length.</para>
        /// </description></item>
        /// <item><description><para>The value must be encoded in UTF-8.</para>
        /// </description></item>
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
        /// <item><description><para>image</para>
        /// </description></item>
        /// <item><description><para>video</para>
        /// </description></item>
        /// <item><description><para>audio</para>
        /// </description></item>
        /// <item><description><para>text</para>
        /// </description></item>
        /// </list>
        /// <para>We recommend that you specify this parameter based on your business requirements. If you set InputURL to an OSS URL, the media asset type can be automatically determined based on the file name extension. Refer to <a href="t2240981.xdita#"></a>for details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>video</para>
        /// </summary>
        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public string MediaType { get; set; }

        /// <summary>
        /// <para>Specifies whether to overwrite the media asset that has been registered by using the same URL. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: If a media asset has been registered by using the same URL, the original media asset is deleted and the new media asset is registered.</para>
        /// </description></item>
        /// <item><description><para>false: If a media asset has been registered by using the same URL, the new media asset is not registered. A URL cannot be used to register multiple media assets.</para>
        /// </description></item>
        /// </list>
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
        ///     &quot;NeedSprite&quot;: &quot;false&quot;,
        ///     &quot;CoverConfig&quot;: {
        ///         &quot;StartTime&quot;: 1.0
        ///     },
        ///        &quot;SearchLibName&quot;: &quot;test&quot;
        /// }</para>
        /// </summary>
        [NameInMap("RegisterConfig")]
        [Validation(Required=false)]
        public string RegisterConfig { get; set; }

        /// <summary>
        /// <para>The ID of the smart tagging template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>S00000101-300080: the system template that supports natural language processing (NLP) for content recognition.</para>
        /// </description></item>
        /// <item><description><para>S00000103-000001: the system template that supports NLP for content recognition and all <a href="t2729541.xdita#93b27f536airj">tagging capabilities</a>.</para>
        /// </description></item>
        /// <item><description><para>S00000103-000002: the system template that supports all <a href="t2729541.xdita#93b27f536airj">tagging capabilities</a> but does not support NLP for content recognition.</para>
        /// </description></item>
        /// </list>
        /// <para>After you configure this parameter, a smart tag analysis task is automatically initiated after the media asset is registered.</para>
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
        /// <item><description><para>The value can be up to 128 bytes in length.</para>
        /// </description></item>
        /// <item><description><para>The value must be encoded in UTF-8.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>defaultTitle</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The user data. You can specify a custom callback URL. For more information, see <a href="t2243473.xdita#"></a>.</para>
        /// <list type="bullet">
        /// <item><description><para>The value can be up to 1,024 bytes in length.</para>
        /// </description></item>
        /// <item><description><para>The value must be encoded in UTF-8.</para>
        /// </description></item>
        /// <item><description><para>The value must be in the JSON format.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NotifyAddress&quot;:&quot;<a href="http://xx.xx.xxx%22%7D">http://xx.xx.xxx&quot;}</a> or{&quot;NotifyAddress&quot;:&quot;<a href="https://xx.xx.xxx%22%7D">https://xx.xx.xxx&quot;}</a> or{&quot;NotifyAddress&quot;:&quot;ice-callback-demo&quot;}</para>
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
