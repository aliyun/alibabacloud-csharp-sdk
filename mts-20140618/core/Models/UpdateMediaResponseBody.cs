// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class UpdateMediaResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the media file.</para>
        /// </summary>
        [NameInMap("Media")]
        [Validation(Required=false)]
        public UpdateMediaResponseBodyMedia Media { get; set; }
        public class UpdateMediaResponseBodyMedia : TeaModel {
            /// <summary>
            /// <para>The bitrate of the media file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2659.326</para>
            /// </summary>
            [NameInMap("Bitrate")]
            [Validation(Required=false)]
            public string Bitrate { get; set; }

            /// <summary>
            /// <para>The ID of the category to which the media file belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CateId")]
            [Validation(Required=false)]
            public long? CateId { get; set; }

            /// <summary>
            /// <para>The review state of the media file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Initiated</b>: The media file is uploaded but not reviewed.</description></item>
            /// <item><description><b>Pass</b>: The media file is uploaded and passes the review.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Initiated</para>
            /// </summary>
            [NameInMap("CensorState")]
            [Validation(Required=false)]
            public string CensorState { get; set; }

            /// <summary>
            /// <para>The URL of the thumbnail.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://example-bucket-****.oss-cn-shanghai.aliyuncs.com/example-****.jpg">http://example-bucket-****.oss-cn-shanghai.aliyuncs.com/example-****.jpg</a></para>
            /// </summary>
            [NameInMap("CoverURL")]
            [Validation(Required=false)]
            public string CoverURL { get; set; }

            /// <summary>
            /// <para>The time when the media file was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2016-09-14T08:30:33Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The description of the media file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The duration of the media file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7.965000</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            /// <summary>
            /// <para>The information about the input file.</para>
            /// </summary>
            [NameInMap("File")]
            [Validation(Required=false)]
            public UpdateMediaResponseBodyMediaFile File { get; set; }
            public class UpdateMediaResponseBodyMediaFile : TeaModel {
                /// <summary>
                /// <para>The state of the input file. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Normal</b>: The input file is normal.</description></item>
                /// <item><description><b>Deleted</b>: The input file is deleted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The name of the OSS bucket in which the input media file is stored.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://example-bucket-****.oss-cn-hangzhou.aliyuncs.com//example-****.mp4">http://example-bucket-****.oss-cn-hangzhou.aliyuncs.com//example-****.mp4</a></para>
                /// </summary>
                [NameInMap("URL")]
                [Validation(Required=false)]
                public string URL { get; set; }

            }

            /// <summary>
            /// <para>The format of the media file. Valid values: mov, mp4, m4a, 3gp, 3g2, and mj2.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mov</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <para>The frame rate of the media file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25.0</para>
            /// </summary>
            [NameInMap("Fps")]
            [Validation(Required=false)]
            public string Fps { get; set; }

            /// <summary>
            /// <para>The height of the media file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1080</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public string Height { get; set; }

            /// <summary>
            /// <para>The ID of the media file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3e1cd21131a94525be55acf65888****</para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// <para>The publishing state of the media file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Initiated</b>: The media file is in the initial state.</description></item>
            /// <item><description><b>UnPublish</b>: The media file has not been published, and the playback permission on the OSS object is Private.</description></item>
            /// <item><description><b>Published</b>: The media file has been published, and the playback permission on the OSS object is Default.</description></item>
            /// <item><description><b>Deleted</b>: The media file is deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Published</para>
            /// </summary>
            [NameInMap("PublishState")]
            [Validation(Required=false)]
            public string PublishState { get; set; }

            /// <summary>
            /// <para>The IDs of the media workflow execution instances.</para>
            /// </summary>
            [NameInMap("RunIdList")]
            [Validation(Required=false)]
            public UpdateMediaResponseBodyMediaRunIdList RunIdList { get; set; }
            public class UpdateMediaResponseBodyMediaRunIdList : TeaModel {
                [NameInMap("RunId")]
                [Validation(Required=false)]
                public List<string> RunId { get; set; }

            }

            /// <summary>
            /// <para>The size of the media file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2647692</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public string Size { get; set; }

            /// <summary>
            /// <para>The information about the tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public UpdateMediaResponseBodyMediaTags Tags { get; set; }
            public class UpdateMediaResponseBodyMediaTags : TeaModel {
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public List<string> Tag { get; set; }

            }

            /// <summary>
            /// <para>The title of the media file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hello</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The width of the media file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1920</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public string Width { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6A88246F-C91F-42BD-BABE-DB0DF993F960</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
