// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class CreateUploadImageRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. Default value: <b>app-1000000</b>. If you have activated the multi-application service, specify the application ID to upload the image to the specified application. For more information, see <a href="https://help.aliyun.com/document_detail/113600.html">Multi-application</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-1000000</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The category ID. You can obtain the category ID by using the following methods:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Configuration Management</b> &gt; <b>Media Management</b> &gt; <b>Categories</b> to view the category ID.</description></item>
        /// <item><description>Obtain the value of CateId from the response when you call the <a href="~~AddCategory~~">AddCategory</a> operation to create a category.</description></item>
        /// <item><description>Obtain the value of CateId from the response when you call the <a href="~~GetCategories~~">GetCategories</a> operation to query categories.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>100036****</para>
        /// </summary>
        [NameInMap("CateId")]
        [Validation(Required=false)]
        public long? CateId { get; set; }

        /// <summary>
        /// <para>The description of the image.</para>
        /// <list type="bullet">
        /// <item><description>The description can be up to 1024 characters in length.</description></item>
        /// <item><description>The description must be encoded in UTF-8.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Image upload test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The file name extension of the image source file to upload. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>png</b> (default)</description></item>
        /// <item><description><b>jpg</b></description></item>
        /// <item><description><b>jpeg</b></description></item>
        /// <item><description><b>gif</b></description></item>
        /// <item><description><b>heic</b></description></item>
        /// <item><description><b>webp</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>png</para>
        /// </summary>
        [NameInMap("ImageExt")]
        [Validation(Required=false)]
        public string ImageExt { get; set; }

        /// <summary>
        /// <para>The type of the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>default</b> (default): a common image.</description></item>
        /// <item><description><b>cover</b>: a video thumbnail.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The ApsaraVideo VOD console supports viewing and managing only images of the <b>default</b> type.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("ImageType")]
        [Validation(Required=false)]
        public string ImageType { get; set; }

        /// <summary>
        /// <para>The address of the image source file to upload.</para>
        /// <remarks>
        /// <para>The file name extension is optional. If a file name extension is included here and is different from the value specified in <c>ImageExt</c>, the value of <c>ImageExt</c> takes precedence.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>D:\picture_01</para>
        /// </summary>
        [NameInMap("OriginalFileName")]
        [Validation(Required=false)]
        public string OriginalFileName { get; set; }

        /// <summary>
        /// <para>The storage address. You can obtain the storage address by using the following method:
        /// Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Configuration Management</b> &gt; <b>Media Management</b> &gt; <b>Storage</b> to view the storage address.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the image is uploaded to the default storage address. If you specify this parameter, the image is uploaded to the specified storage address.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>outin-****..oss-cn-shanghai.aliyuncs.com</para>
        /// </summary>
        [NameInMap("StorageLocation")]
        [Validation(Required=false)]
        public string StorageLocation { get; set; }

        /// <summary>
        /// <para>The tags of the image. Rules:</para>
        /// <list type="bullet">
        /// <item><description>Each tag can be up to 32 characters in length.</description></item>
        /// <item><description>You can specify up to 16 tags.</description></item>
        /// <item><description>Separate multiple tags with commas (,).</description></item>
        /// <item><description>The tags must be encoded in UTF-8.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Test</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>The title of the image. Rules:</para>
        /// <list type="bullet">
        /// <item><description>The title can be up to 128 characters in length.</description></item>
        /// <item><description>The title must be encoded in UTF-8.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>mytitle</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The custom settings in a JSON string. The settings support message callbacks, upload acceleration, and other configurations. For more information, see <a href="https://help.aliyun.com/document_detail/86952.html">UserData</a>.</para>
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
