// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class UpdateMediaRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the category to which the media file belongs. The value must be an integer.</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter, the value is NULL.</description></item>
        /// <item><description>The value cannot be negative.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CateId")]
        [Validation(Required=false)]
        public long? CateId { get; set; }

        /// <summary>
        /// <para>The URL of the thumbnail. This parameter is used to specify the storage location of the thumbnail. To obtain the URL, you can log on to the <b>MPS console</b> and choose <b>Workflows</b> &gt; <b>Media Buckets</b> in the left-side navigation pane. Alternatively, you can log on to the <b>OSS console</b> and click <b>Buckets</b> in the left-side navigation pane.</para>
        /// <list type="bullet">
        /// <item><description>The value can be up to 3,200 bytes in length.</description></item>
        /// <item><description>The URL complies with RFC 2396 and is encoded in UTF-8, with reserved characters being percent-encoded. For more information, see <a href="https://help.aliyun.com/document_detail/423796.html">URL encoding</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example-bucket-****.oss-cn-hangzhou.aliyuncs.com/test****.jpg">http://example-bucket-****.oss-cn-hangzhou.aliyuncs.com/test****.jpg</a></para>
        /// </summary>
        [NameInMap("CoverURL")]
        [Validation(Required=false)]
        public string CoverURL { get; set; }

        /// <summary>
        /// <para>The description of the media file. Multiple character types, such as letters and digits, are supported.</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter, the value is NULL.</description></item>
        /// <item><description>The value is encoded in UTF-8 and can be up to 1,024 bytes in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>example description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the media file whose basic information you want to update. To obtain the ID of the media file, you can log on to the <b>ApsaraVideo Media Processing (MPS) console</b> and choose <b>Media Management</b> &gt; <b>Media List</b> in the left-side navigation pane.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3e1cd21131a94525be55acf65888****</para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

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
        /// <list type="bullet">
        /// <item><description>You can specify up to 16 tags for a media file. Separate multiple tags with commas (,).</description></item>
        /// <item><description>Each tag can be up to 32 bytes in length.</description></item>
        /// <item><description>The value is encoded in UTF-8.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>tag1,tag2</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>The title of the media file. Multiple character types, such as letters and digits, are supported.</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter, the value is NULL.</description></item>
        /// <item><description>The value is encoded in UTF-8 and can be up to 128 bytes in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>hello</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
