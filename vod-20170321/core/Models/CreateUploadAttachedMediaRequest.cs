// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class CreateUploadAttachedMediaRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. Default value: <b>app-1000000</b>. If you have activated the multi-application service, specify the application ID to upload the auxiliary media asset to the specified application. For more information, see <a href="https://help.aliyun.com/document_detail/113600.html">Multi-application</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The type of the auxiliary media asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>watermark</b>: watermark.</description></item>
        /// <item><description><b>subtitle</b>: subtitle.</description></item>
        /// <item><description><b>material</b>: material.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>watermark</para>
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        /// <summary>
        /// <para>The category IDs. Separate multiple IDs with commas (,). A maximum of 5 IDs are supported. You can obtain category IDs by using the following methods:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Configuration Management</b> &gt; <b>Media Management Configuration</b> &gt; <b>Category Management</b> to view category IDs.</description></item>
        /// <item><description>The category ID is returned when you call the <a href="~~AddCategory~~">AddCategory</a> operation to create a category.</description></item>
        /// <item><description>The category ID is returned when you call the <a href="~~GetCategories~~">GetCategories</a> operation to query categories.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1298****,0813****</para>
        /// </summary>
        [NameInMap("CateIds")]
        [Validation(Required=false)]
        public string CateIds { get; set; }

        /// <summary>
        /// <para>The description of the media asset. Rules:</para>
        /// <list type="bullet">
        /// <item><description>The description can be up to 1024 bytes in length.</description></item>
        /// <item><description>The description must be encoded in UTF-8.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>uploadTest</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The source file address of the auxiliary media asset to be uploaded.</para>
        /// <remarks>
        /// <para>The file name extension is optional. If a file name extension is specified here and is different from the extension specified in MediaExt, the value of MediaExt takes precedence.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>D:\test.png</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The file size. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("FileSize")]
        [Validation(Required=false)]
        public string FileSize { get; set; }

        /// <summary>
        /// <para>The file name extension of the auxiliary media asset source file to be uploaded. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Watermark: <b>png, gif, apng, mov</b>.</description></item>
        /// <item><description>Subtitle: <b>srt, ass, stl, ttml, vtt</b>.</description></item>
        /// <item><description>Material: <b>jpg, gif, png, mp4, mat, zip, apk</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>png</para>
        /// </summary>
        [NameInMap("MediaExt")]
        [Validation(Required=false)]
        public string MediaExt { get; set; }

        /// <summary>
        /// <para>The storage address. You can obtain the storage address by using the following method:</para>
        /// <para>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Configuration Management</b> &gt; <b>Media Management Configuration</b> &gt; <b>Storage Management</b> to view the storage address.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the auxiliary media asset is uploaded to the default storage address. If you specify this parameter, the auxiliary media asset is uploaded to the specified storage address.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>out-****.oss-cn-shanghai.aliyuncs.com</para>
        /// </summary>
        [NameInMap("StorageLocation")]
        [Validation(Required=false)]
        public string StorageLocation { get; set; }

        /// <summary>
        /// <para>The tags. Rules:</para>
        /// <list type="bullet">
        /// <item><description>A maximum of 16 tags are supported.</description></item>
        /// <item><description>Separate multiple tags with commas (,).</description></item>
        /// <item><description>Each tag can be up to 32 characters or Chinese characters in length.</description></item>
        /// <item><description>The tags must be encoded in UTF-8.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>tag1,tag2</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>The title of the auxiliary media asset. Rules:</para>
        /// <list type="bullet">
        /// <item><description>The title can be up to 128 bytes in length.</description></item>
        /// <item><description>The title must be encoded in UTF-8.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Test</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The custom settings, which is a JSON string. The settings support message callbacks, upload acceleration, and other configurations. For more information, see <a href="~~86952#section-6fg-qll-v3w~~">UserData</a>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>To use message callbacks in this parameter, you must configure an HTTP callback URL and select the corresponding callback event types in the console. Otherwise, the callback settings do not take effect. For information about how to configure HTTP callbacks in the console, see <a href="https://help.aliyun.com/document_detail/86071.html">Callback settings</a>.</description></item>
        /// <item><description>To use the upload acceleration feature, submit a ticket to activate it. For more information, see <a href="https://help.aliyun.com/document_detail/55396.html">Upload instructions</a>. For information about how to submit a ticket, see <a href="https://help.aliyun.com/document_detail/464625.html">Contact us</a>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;MessageCallback&quot;:{&quot;CallbackURL&quot;:&quot;<a href="http://example.aliyundoc.com%22%7D,%22Extend%22:%7B%22localId%22:%22xxx%22,%22test%22:%22www%22%7D%7D">http://example.aliyundoc.com&quot;},&quot;Extend&quot;:{&quot;localId&quot;:&quot;xxx&quot;,&quot;test&quot;:&quot;www&quot;}}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
