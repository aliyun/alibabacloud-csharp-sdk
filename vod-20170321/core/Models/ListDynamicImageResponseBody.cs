// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListDynamicImageResponseBody : TeaModel {
        /// <summary>
        /// <para>The animated image results.</para>
        /// </summary>
        [NameInMap("DynamicImageList")]
        [Validation(Required=false)]
        public List<ListDynamicImageResponseBodyDynamicImageList> DynamicImageList { get; set; }
        public class ListDynamicImageResponseBodyDynamicImageList : TeaModel {
            /// <summary>
            /// <para>The time when the animated image was created. The time follows the format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-07-28T02:01:06Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The duration of the animated image. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            /// <summary>
            /// <para>The animated image ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2b4e51df60323ef43d6e336ecf****</para>
            /// </summary>
            [NameInMap("DynamicImageId")]
            [Validation(Required=false)]
            public string DynamicImageId { get; set; }

            /// <summary>
            /// <para>The size of the animated image file. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>119866</para>
            /// </summary>
            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public string FileSize { get; set; }

            /// <summary>
            /// <para>The URL of the animated image file.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.aliyundoc.com/2e114f110059*****0c3193918fd449a/image/dynamic/2b4e51df60*****323ef43d6e336ecf.webp?auth_key=1597296785-0-0-4a48e85*****bd2bb358e0b3cade">https://example.aliyundoc.com/2e114f110059*****0c3193918fd449a/image/dynamic/2b4e51df60*****323ef43d6e336ecf.webp?auth_key=1597296785-0-0-4a48e85*****bd2bb358e0b3cade</a></para>
            /// </summary>
            [NameInMap("FileURL")]
            [Validation(Required=false)]
            public string FileURL { get; set; }

            /// <summary>
            /// <para>The format of the animated image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>gif</b></description></item>
            /// <item><description><b>webp</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>webp</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <para>The frame rate of the animated image. Unit: frames per second.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Fps")]
            [Validation(Required=false)]
            public string Fps { get; set; }

            /// <summary>
            /// <para>The height of the animated image. Unit: px.</para>
            /// 
            /// <b>Example:</b>
            /// <para>360</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public string Height { get; set; }

            /// <summary>
            /// <para>The animated image job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2bf4390af9e5491c09cc720ad****</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The video ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2e114f1100590c3193918fd449a****</para>
            /// </summary>
            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

            /// <summary>
            /// <para>The width of the animated image. Unit: px.</para>
            /// 
            /// <b>Example:</b>
            /// <para>640</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public string Width { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>570189B6-572E-4953-13B4278EE0D8****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
