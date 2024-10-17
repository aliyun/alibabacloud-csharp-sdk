// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateUploadMediaRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. Default value: app-1000000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-1000000</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The entity ID. You can call the CreateEntity operation to create an entity and specify a dynamic metadata structure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9e177cac2fb44f8b8c67b199fcc7bffd</para>
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public string EntityId { get; set; }

        /// <summary>
        /// <para>The file information, which is in the JSON format and contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description>Type: required. The file type. Valid values: video, image, audio, text, and other.</description></item>
        /// <item><description>Name: required. The file name without the extension.</description></item>
        /// <item><description>Size: optional. The file size.</description></item>
        /// <item><description>Ext: required. The file name extension.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;Type\&quot;:\&quot;video\&quot;,\&quot;Name\&quot;:\&quot;test.mp4\&quot;,\&quot;Size\&quot;:108078336,\&quot;Ext\&quot;:\&quot;mp4\&quot;}</para>
        /// </summary>
        [NameInMap("FileInfo")]
        [Validation(Required=false)]
        public string FileInfo { get; set; }

        /// <summary>
        /// <para>The metadata of the media asset, which is a JSON string that contains the following fields:</para>
        /// <para>Title: required.</para>
        /// <list type="bullet">
        /// <item><description>The value can be up to 128 characters in length.</description></item>
        /// <item><description>The value must be encoded in UTF-8.</description></item>
        /// </list>
        /// <para>Description: optional.</para>
        /// <list type="bullet">
        /// <item><description>The value can be up to 1,024 characters in length.</description></item>
        /// <item><description>The value must be encoded in UTF-8.</description></item>
        /// </list>
        /// <para>CateId: optional.</para>
        /// <para>Tags: optional.</para>
        /// <para>BusinessType: required. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>opening or ending if Type is set to video</description></item>
        /// <item><description>default or cover if Type is set to image</description></item>
        /// <item><description>subtitles or font if Type is set to text</description></item>
        /// <item><description>watermark if Type is set to material</description></item>
        /// <item><description>general CoverURL: optional.</description></item>
        /// </list>
        /// <para>DynamicMetaData: The value is a string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;Title\&quot;: \&quot;UploadTest\&quot;, \&quot;Description\&quot;: \&quot;UploadImageTest\&quot;, \&quot;Tags\&quot;: \&quot;tag1,tag2\&quot;,\&quot;BusinessType\&quot;:\&quot;cover\&quot;}</para>
        /// </summary>
        [NameInMap("MediaMetaData")]
        [Validation(Required=false)]
        public string MediaMetaData { get; set; }

        /// <summary>
        /// <para>The postprocessing configurations. You can specify this parameter if Type is set to video or audio.</para>
        /// <para>Set ProcessType to Workflow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;ProcessType\&quot;:\&quot;Workflow\&quot;,\&quot;ProcessID\&quot;:\&quot;74ba870f1a4873a3ba238e0bf6fa9***\&quot;}</para>
        /// </summary>
        [NameInMap("PostProcessConfig")]
        [Validation(Required=false)]
        public string PostProcessConfig { get; set; }

        /// <summary>
        /// <para>The destination storage address.</para>
        /// <para>Set StorageType to oss.</para>
        /// <para>Set StorageLocation to an address in ApsaraVideo VOD. You cannot set this field to an OSS URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;StorageType\&quot;:\&quot;oss\&quot;,\&quot;StorageLocation\&quot;:\&quot;outin-***.oss-cn-shanghai.aliyuncs.com\&quot;}</para>
        /// </summary>
        [NameInMap("UploadTargetConfig")]
        [Validation(Required=false)]
        public string UploadTargetConfig { get; set; }

        /// <summary>
        /// <para>The user data. The value must be a JSON string. You can configure settings such as message callbacks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;MessageCallback&quot;:{&quot;CallbackURL&quot;:&quot;<a href="http://example.aliyundoc.com%22%7D,%22Extend%22:%7B%22localId%22:%22*****%22,%22test%22:%22www%22%7D%7D">http://example.aliyundoc.com&quot;},&quot;Extend&quot;:{&quot;localId&quot;:&quot;*****&quot;,&quot;test&quot;:&quot;www&quot;}}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
