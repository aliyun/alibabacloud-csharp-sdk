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
        /// <item><description>font</description></item>
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
        /// <para>The client token. A 32-character UUID that ensures the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>0311a423d11a5f7dee713535</b></b></para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The cover image URL.</para>
        /// <list type="bullet">
        /// <item><description><para>Maximum length: 128 bytes.</para>
        /// </description></item>
        /// <item><description><para>UTF-8 encoded.</para>
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
        /// <para>The content description.</para>
        /// <list type="bullet">
        /// <item><description><para>Maximum length: 1024 bytes.</para>
        /// </description></item>
        /// <item><description><para>UTF-8 encoded.</para>
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
        /// <para>The URL of the media asset to be registered in the corresponding system. Once registered, this URL cannot be changed and is attached to the IMS mediaId.</para>
        /// <list type="bullet">
        /// <item><description>OSS URL. Two formats are supported:</description></item>
        /// </list>
        /// <para>http(s)://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4</para>
        /// <para>oss://example-bucket/example.mp4
        ///  (This format assumes by default that the OSS region is the same as the service registration area.)</para>
        /// <list type="bullet">
        /// <item><description>VOD media asset:</description></item>
        /// </list>
        /// <para>vod://\<em>\</em>\<em>20b48fb04483915d4f2cd8ac</em>***</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4">http://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4</a>  or  vod://<b><b>20b48fb04483915d4f2cd8ac</b></b></para>
        /// </summary>
        [NameInMap("InputURL")]
        [Validation(Required=false)]
        public string InputURL { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// <list type="bullet">
        /// <item><description><para>Maximum number of tags: 16.</para>
        /// </description></item>
        /// <item><description><para>Separate multiple tags with commas.</para>
        /// </description></item>
        /// <item><description><para>Maximum length of a single tag: 32 bytes.</para>
        /// </description></item>
        /// <item><description><para>UTF-8 encoded.</para>
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
        /// <para>The media type of the media asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>image</description></item>
        /// <item><description>video</description></item>
        /// <item><description>audio</description></item>
        /// <item><description>text</description></item>
        /// </list>
        /// <para>When the value is &quot;text&quot;, the businessType must be set to &quot;subtitles&quot; or &quot;font&quot;.</para>
        /// <para>Specify this field as needed. When the InputURL field is an OSS URL, the media type can also be automatically determined based on the file name extension (only for image, video, and audio file extensions). For the mapping between file extensions and media types, see <a href="https://help.aliyun.com/document_detail/466207.html">File formats</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>video</para>
        /// </summary>
        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public string MediaType { get; set; }

        /// <summary>
        /// <para>Specifies whether to overwrite an existing registered media asset. Default value: false.</para>
        /// <list type="bullet">
        /// <item><description><para>true: If the inputUrl is already registered, the existing media asset is deleted and a new media asset is registered.</para>
        /// </description></item>
        /// <item><description><para>false: If the inputUrl is already registered, the new media asset is not registered. Duplicate inputUrl values are not supported.</para>
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
        /// <para>The custom ID. Only lowercase letters, uppercase letters, digits, hyphens (-), and underscores (_) are supported. The length must be 6 to 64 characters. The ID must be unique for each user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123-123</para>
        /// </summary>
        [NameInMap("ReferenceId")]
        [Validation(Required=false)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// <para>The registration configuration.</para>
        /// <para>By default, a sprite image is generated for the media asset. To disable this, set the NeedSprite field to false.</para>
        /// <para>By default, a snapshot is generated. To disable this, set the NeedSnapshot field to false.</para>
        /// <para>To specify the time for the cover image, configure CoverConfig, which contains the following field:</para>
        /// <list type="bullet">
        /// <item><description>StartTime: The time in seconds at which the cover image is captured from the media asset. Up to four decimal places are supported.</description></item>
        /// </list>
        /// <para>After media asset registration, to import the media asset into a custom search library, configure SearchLibName. For information about how to create and use a custom search library, see <a href="~~2796619#dd34d8c740yj9~~">Use a custom search library</a>.</para>
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
        /// <para>The intelligent tagging template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>S00000101-300080: A system template that includes NLP content understanding.</description></item>
        /// <item><description>S00000103-000001: A system template that includes NLP content understanding and all <a href="~~2804526#93b27f536airj~~">tagging capabilities</a>.</description></item>
        /// <item><description>S00000103-000002: A system template that includes all <a href="~~2804526#93b27f536airj~~">tagging capabilities</a> but does not include NLP content understanding.</description></item>
        /// </list>
        /// <para>For more information about tagging capabilities, see the documentation.</para>
        /// <para>After this field is configured, an intelligent tagging analysis task is automatically initiated upon media asset registration. For billing information, see <a href="https://help.aliyun.com/document_detail/600262.html">Billing of Smart Tag Standard Edition</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>S00000101-300080</para>
        /// </summary>
        [NameInMap("SmartTagTemplateId")]
        [Validation(Required=false)]
        public string SmartTagTemplateId { get; set; }

        /// <summary>
        /// <para>The title. If not provided, a default title is automatically generated based on the date.</para>
        /// <list type="bullet">
        /// <item><description><para>Maximum length: 128 bytes.</para>
        /// </description></item>
        /// <item><description><para>UTF-8 encoded.</para>
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
        /// <para>The user data. Custom callback URL configuration is supported. For configuration instructions, see <a href="https://help.aliyun.com/document_detail/451631.html">Configure a callback upon editing completion</a>.</para>
        /// <list type="bullet">
        /// <item><description><para>Maximum length: 1024 bytes.</para>
        /// </description></item>
        /// <item><description><para>UTF-8 encoded.</para>
        /// </description></item>
        /// <item><description><para>Json format.</para>
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
