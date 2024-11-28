// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateVideoInfoRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the video category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>384761111</para>
        /// </summary>
        [NameInMap("CateId")]
        [Validation(Required=false)]
        public long? CateId { get; set; }

        /// <summary>
        /// <para>The URL of the video thumbnail.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.aliyundoc.com/****.jpg">https://example.aliyundoc.com/****.jpg</a></para>
        /// </summary>
        [NameInMap("CoverURL")]
        [Validation(Required=false)]
        public string CoverURL { get; set; }

        /// <summary>
        /// <para>The description of the video.</para>
        /// <list type="bullet">
        /// <item><description>The value can be up to 1,024 bytes in length.</description></item>
        /// <item><description>The string must be encoded in the UTF-8 format.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>video description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The tags of the video.</para>
        /// <list type="bullet">
        /// <item><description>Each tag can be up to 32 bytes in length. A maximum of 16 tags can be specified.</description></item>
        /// <item><description>Separate multiple tags with commas (,).</description></item>
        /// <item><description>The string must be encoded in the UTF-8 format.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>tag1,tag2</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>The title of the video.</para>
        /// <list type="bullet">
        /// <item><description>The value can be up to 128 bytes in length.</description></item>
        /// <item><description>The string must be encoded in the UTF-8 format.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>video title</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The ID of the video.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2deda93265312baf9b0ed810d****</para>
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
