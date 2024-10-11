// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class CreateUploadAttachedMediaRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application. Default value: <b>app-1000000</b>. If you have activated the multi-application service, specify the ID of the application to add the watermark template in the specified application. For more information, see <a href="https://help.aliyun.com/document_detail/113600.html">Overview</a>.</para>
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
        /// <item><description><b>watermark</b></description></item>
        /// <item><description><b>subtitle</b></description></item>
        /// <item><description><b>material</b></description></item>
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
        /// <para>The ID of the category. Separate multiple IDs with commas (,). You can specify up to five IDs. You can use one of the following methods to obtain the ID:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a>. In the left-side navigation pane, choose <b>Configuration Management</b> &gt; <b>Media Management</b> &gt; <b>Categories</b> to view the category ID of the media file.</description></item>
        /// <item><description>Obtain the category ID from the response to the <a href="~~AddCategory~~">AddCategory</a> operation that you call to create a category.</description></item>
        /// <item><description>Obtain the category ID from the response to the <a href="~~GetCategories~~">GetCategories</a> operation that you call to query categories.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1298****,0813****</para>
        /// </summary>
        [NameInMap("CateIds")]
        [Validation(Required=false)]
        public string CateIds { get; set; }

        /// <summary>
        /// <para>The description of the auxiliary media asset. Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The description can be up to 1,024 bytes in length.</description></item>
        /// <item><description>The value must be encoded in UTF-8.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>uploadTest</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The source file URL of the auxiliary media asset.</para>
        /// <remarks>
        /// <para> The file name extension is optional. If the file name extension that you specified for this parameter is different from the value of MediaExt, the value of MediaExt takes effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>D:\test.png</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The size of the auxiliary media asset. Unit: byte.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("FileSize")]
        [Validation(Required=false)]
        public string FileSize { get; set; }

        /// <summary>
        /// <para>The file name extension of the auxiliary media asset.</para>
        /// <list type="bullet">
        /// <item><description>Valid values for watermarks: <b>png, gif, apng, and mov</b></description></item>
        /// <item><description>Valid values for subtitles: <b>srt, ass, stl, ttml, and vtt</b></description></item>
        /// <item><description>Valid values for materials: <b>jpg, gif, png, mp4, mat, zip, and apk</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>png</para>
        /// </summary>
        [NameInMap("MediaExt")]
        [Validation(Required=false)]
        public string MediaExt { get; set; }

        /// <summary>
        /// <para>The storage address. Perform the following operations to obtain the storage address:</para>
        /// <para>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a>. In the left-side navigation pane, choose <b>Configuration Management</b> &gt; <b>Media Management</b> &gt; <b>Storage</b>. On the Storage page, view the storage address.</para>
        /// <remarks>
        /// <para> If you leave this parameter empty, the auxiliary media asset is uploaded to the default storage address. If you specify this parameter, the auxiliary media asset is uploaded to the specified storage address.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>out-****.oss-cn-shanghai.aliyuncs.com</para>
        /// </summary>
        [NameInMap("StorageLocation")]
        [Validation(Required=false)]
        public string StorageLocation { get; set; }

        /// <summary>
        /// <para>The one or more tags of the auxiliary media asset. Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>You can specify a maximum of 16 tags.</description></item>
        /// <item><description>If you need to specify multiple tags, separate the tags with commas (,).</description></item>
        /// <item><description>Each tag can be up to 32 characters in length.</description></item>
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
        /// <para>The title of the auxiliary media asset. The following rules apply:</para>
        /// <list type="bullet">
        /// <item><description>The title cannot exceed 128 bytes.</description></item>
        /// <item><description>The title must be encoded in UTF-8.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>testTitle</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The custom configurations. For example, you can specify callback configurations and upload acceleration configurations. The value must be a JSON string. For more information, see <a href="~~86952#section-6fg-qll-v3w~~">Request parameters</a>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The callback configurations take effect only after you specify the HTTP callback URL and select the specific callback events in the ApsaraVideo VOD console. For more information about how to configure HTTP callback settings in the ApsaraVideo VOD console, see <a href="https://help.aliyun.com/document_detail/86071.html">Configure callback settings</a>.</description></item>
        /// <item><description>If you want to enable the upload acceleration feature, submit a ticket. For more information, see <a href="https://help.aliyun.com/document_detail/55396.html">Overview</a>. For more information about how to submit a ticket, see <a href="https://help.aliyun.com/document_detail/464625.html">Contact us</a>.</description></item>
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
