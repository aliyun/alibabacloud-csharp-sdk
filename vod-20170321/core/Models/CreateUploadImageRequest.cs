// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class CreateUploadImageRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application. Default value: <b>app-1000000</b>. For more information, see <a href="https://help.aliyun.com/document_detail/113600.html">Overview</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-1000000</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The category ID of the image. You can use one of the following methods to obtain the category ID:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a>. In the left-side navigation pane, choose <b>Configuration Management</b> &gt; <b>Media Management</b> &gt; <b>Categories</b>. On the Categories page, you can view the category ID of the image.</description></item>
        /// <item><description>Obtain the value of CateId from the response to the <a href="https://help.aliyun.com/document_detail/56401.html">AddCategory</a> operation.</description></item>
        /// <item><description>Obtain the value of CateId from the response to the <a href="https://help.aliyun.com/document_detail/56406.html">GetCategories</a> operation.</description></item>
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
        /// <item><description>The description can be up to 1,024 characters in length.</description></item>
        /// <item><description>The value must be encoded in UTF-8.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>The description of the image</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The file name extension of the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>png</b> (default)</description></item>
        /// <item><description><b>jpg</b></description></item>
        /// <item><description><b>jpeg</b></description></item>
        /// <item><description><b>gif</b></description></item>
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
        /// <item><description><b>default</b>: the default image type.</description></item>
        /// <item><description><b>cover</b>: the thumbnail.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can manage only images of the <b>default</b> type in the ApsaraVideo VOD console.</para>
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
        /// <para>The name of the source file.</para>
        /// <remarks>
        /// <para>The name must contain a file name extension. The file name extension is not case-sensitive.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>D:\picture_01.png</para>
        /// </summary>
        [NameInMap("OriginalFileName")]
        [Validation(Required=false)]
        public string OriginalFileName { get; set; }

        /// <summary>
        /// <para>The storage address. Perform the following operations to obtain the storage address: Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a>. In the left-side navigation pane, choose <b>Configuration Management</b> &gt; <b>Media Management</b> &gt; <b>Storage</b>. On the Storage page, view the storage address.</para>
        /// <remarks>
        /// <para>If you specify a storage address, media files are uploaded to the specified address.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>outin-****..oss-cn-shanghai.aliyuncs.com</para>
        /// </summary>
        [NameInMap("StorageLocation")]
        [Validation(Required=false)]
        public string StorageLocation { get; set; }

        /// <summary>
        /// <para>The tags of the image. The following rules apply:</para>
        /// <list type="bullet">
        /// <item><description>Each tag can be up to 32 characters in length.</description></item>
        /// <item><description>You can specify a maximum of 16 tags for an image.</description></item>
        /// <item><description>Separate multiple tags with commas (,).</description></item>
        /// <item><description>The value must be encoded in UTF-8.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>The title of the image. The following rules apply:</para>
        /// <list type="bullet">
        /// <item><description>The title can be up to 128 characters in length.</description></item>
        /// <item><description>The value must be encoded in UTF-8.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>mytitle</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The custom configurations, including callback configurations and upload acceleration configurations. The value must be a JSON string. For more information, see the &quot;UserData: specifies the custom configurations for media upload&quot; section of the <a href="https://help.aliyun.com/document_detail/86952.html">Request parameters</a> topic.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The callback configurations take effect only after you specify the HTTP callback URL and select specific callback events in the ApsaraVideo VOD console. For more information about how to configure HTTP callback settings in the ApsaraVideo VOD console, see <a href="https://help.aliyun.com/document_detail/86071.html">Configure callback settings</a>.</description></item>
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
