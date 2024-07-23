// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class AddMediaResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed information about the media file.</para>
        /// </summary>
        [NameInMap("Media")]
        [Validation(Required=false)]
        public AddMediaResponseBodyMedia Media { get; set; }
        public class AddMediaResponseBodyMedia : TeaModel {
            /// <summary>
            /// <para>The bitrate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1148.77</para>
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
            /// <para>The review status of the media file. Valid values:</para>
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
            /// <para><a href="http://bucket.oss-cn-hangzhou.aliyuncs.com/example/1.png">http://bucket.oss-cn-hangzhou.aliyuncs.com/example/1.png</a></para>
            /// </summary>
            [NameInMap("CoverURL")]
            [Validation(Required=false)]
            public string CoverURL { get; set; }

            /// <summary>
            /// <para>The time when the media file was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2016-09-20T03:02:40Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The description of the media file. The description can be up to 1,024 bytes in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A test video</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The duration of the media file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.645333</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            /// <summary>
            /// <para>The information about the input file.</para>
            /// </summary>
            [NameInMap("File")]
            [Validation(Required=false)]
            public AddMediaResponseBodyMediaFile File { get; set; }
            public class AddMediaResponseBodyMediaFile : TeaModel {
                /// <summary>
                /// <para>The status of the file. The default value is <b>Normal</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The URL of the media file.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://bucket.oss-cn-hangzhou.aliyuncs.com/A/B/C/test.mp4">http://bucket.oss-cn-hangzhou.aliyuncs.com/A/B/C/test.mp4</a></para>
                /// </summary>
                [NameInMap("URL")]
                [Validation(Required=false)]
                public string URL { get; set; }

            }

            /// <summary>
            /// <para>The format of the media file. Valid values: mov, mp4, m4a, 3gp, 3g2, and mj2.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mp4</para>
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
            /// <para>1280</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public string Height { get; set; }

            /// <summary>
            /// <para>The ID of the media file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3e6149d5a8c944c09b1a8d2dc3e4****</para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// <para>The publishing status of the media file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Initiated</b>: The media file is in the initial state.</description></item>
            /// <item><description><b>UnPublish</b>: The media file has not been published, and the playback permission on the OSS object is Private.</description></item>
            /// <item><description><b>Published</b>: The media file has been published, and the playback permission on the OSS object is Default.</description></item>
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
            public AddMediaResponseBodyMediaRunIdList RunIdList { get; set; }
            public class AddMediaResponseBodyMediaRunIdList : TeaModel {
                [NameInMap("RunId")]
                [Validation(Required=false)]
                public List<string> RunId { get; set; }

            }

            /// <summary>
            /// <para>The size of the media file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>379860</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public string Size { get; set; }

            /// <summary>
            /// <para>The tags of the media file.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public AddMediaResponseBodyMediaTags Tags { get; set; }
            public class AddMediaResponseBodyMediaTags : TeaModel {
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public List<string> Tag { get; set; }

            }

            /// <summary>
            /// <para>The title of the media file. The title can be up to 128 bytes in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mytest.mp4</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The width of the media file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1280</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public string Width { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>05F8B913-E9F3-4A6F-9922-48CADA0FFAAD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
