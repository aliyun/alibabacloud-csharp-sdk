// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListDynamicImageResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of animated stickers.</para>
        /// </summary>
        [NameInMap("DynamicImageList")]
        [Validation(Required=false)]
        public List<ListDynamicImageResponseBodyDynamicImageList> DynamicImageList { get; set; }
        public class ListDynamicImageResponseBodyDynamicImageList : TeaModel {
            /// <summary>
            /// <para>The time when the animated sticker was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-07-28T02:01:06Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The duration of the animated sticker. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            /// <summary>
            /// <para>The ID of the animated sticker.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2b4e51df60323ef43d6e336ecf****</para>
            /// </summary>
            [NameInMap("DynamicImageId")]
            [Validation(Required=false)]
            public string DynamicImageId { get; set; }

            /// <summary>
            /// <para>The size of the animated sticker file. Unit: byte.</para>
            /// 
            /// <b>Example:</b>
            /// <para>119866</para>
            /// </summary>
            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public string FileSize { get; set; }

            /// <summary>
            /// <para>The URL of the animated sticker file.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.aliyundoc.com/2e114f110059*****0c3193918fd449a/image/dynamic/2b4e51df60*****323ef43d6e336ecf.webp?auth_key=1597296785-0-0-4a48e85*****bd2bb358e0b3cade">https://example.aliyundoc.com/2e114f110059*****0c3193918fd449a/image/dynamic/2b4e51df60*****323ef43d6e336ecf.webp?auth_key=1597296785-0-0-4a48e85*****bd2bb358e0b3cade</a></para>
            /// </summary>
            [NameInMap("FileURL")]
            [Validation(Required=false)]
            public string FileURL { get; set; }

            /// <summary>
            /// <para>The format of the animated sticker. Valid values: gif and webp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>webp</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <para>The frame rate of the animated sticker. Unit: frames per second.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Fps")]
            [Validation(Required=false)]
            public string Fps { get; set; }

            /// <summary>
            /// <para>The height of the animated sticker. Unit: pixel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>360</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public string Height { get; set; }

            /// <summary>
            /// <para>The job ID for creating the animated sticker.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2bf4390af9e5491c09cc720ad****</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The ID of the video.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2e114f1100590c3193918fd449a****</para>
            /// </summary>
            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

            /// <summary>
            /// <para>The width of the animated sticker. Unit: pixel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>640</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public string Width { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>570189B6-572E-4953-13B4278EE0D8****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
