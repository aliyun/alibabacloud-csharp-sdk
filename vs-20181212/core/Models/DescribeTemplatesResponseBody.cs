// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public long? PageCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F3F88C96-CA6E-573E-B8F7-5BE83A1A0BCF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Templates")]
        [Validation(Required=false)]
        public List<DescribeTemplatesResponseBodyTemplates> Templates { get; set; }
        public class DescribeTemplatesResponseBodyTemplates : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://example.com/callback">http://example.com/callback</a></para>
            /// </summary>
            [NameInMap("Callback")]
            [Validation(Required=false)]
            public string Callback { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2018-12-10T10:00:00Z</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>hls</para>
            /// </summary>
            [NameInMap("FileFormat")]
            [Validation(Required=false)]
            public string FileFormat { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>osspath/record/{StreamName}/{EscapedStartTime}_{EscapedEndTime}</para>
            /// </summary>
            [NameInMap("Flv")]
            [Validation(Required=false)]
            public string Flv { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>osspath/record/{StreamName}/{EscapedStartTime}_{EscapedEndTime}</para>
            /// </summary>
            [NameInMap("HlsM3u8")]
            [Validation(Required=false)]
            public string HlsM3u8 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>osspath/record/{StreamName}/{UnixTimestamp}_{Sequence}</para>
            /// </summary>
            [NameInMap("HlsTs")]
            [Validation(Required=false)]
            public string HlsTs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>323*****998-cn-qingdao</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public long? Interval { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>osspath/snapshot/{AppName}/{StreamName}/{UnixTimestamp}_ondemand.jpg</para>
            /// </summary>
            [NameInMap("JpgOnDemand")]
            [Validation(Required=false)]
            public string JpgOnDemand { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>osspath/snapshot/{AppName}/{StreamName}.jpg</para>
            /// </summary>
            [NameInMap("JpgOverwrite")]
            [Validation(Required=false)]
            public string JpgOverwrite { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>osspath/snapshot/{AppName}/{StreamName}/{UnixTimestamp}.jpg</para>
            /// </summary>
            [NameInMap("JpgSequence")]
            [Validation(Required=false)]
            public string JpgSequence { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>osspath/record/{StreamName}/{EscapedStartTime}_{EscapedEndTime}</para>
            /// </summary>
            [NameInMap("Mp4")]
            [Validation(Required=false)]
            public string Mp4 { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>my_oss_bucket</para>
            /// </summary>
            [NameInMap("OssBucket")]
            [Validation(Required=false)]
            public string OssBucket { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>oss-cn-qingdao.aliyuncs.com</para>
            /// </summary>
            [NameInMap("OssEndpoint")]
            [Validation(Required=false)]
            public string OssEndpoint { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>my_prefix</para>
            /// </summary>
            [NameInMap("OssFilePrefix")]
            [Validation(Required=false)]
            public string OssFilePrefix { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-qingdao</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Retention")]
            [Validation(Required=false)]
            public long? Retention { get; set; }

            [NameInMap("TransConfigs")]
            [Validation(Required=false)]
            public List<DescribeTemplatesResponseBodyTemplatesTransConfigs> TransConfigs { get; set; }
            public class DescribeTemplatesResponseBodyTemplatesTransConfigs : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>25</para>
                /// </summary>
                [NameInMap("Fps")]
                [Validation(Required=false)]
                public long? Fps { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Gop")]
                [Validation(Required=false)]
                public long? Gop { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>720</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public long? Height { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>sd</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>800</para>
                /// </summary>
                [NameInMap("VideoBitrate")]
                [Validation(Required=false)]
                public long? VideoBitrate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>h264</para>
                /// </summary>
                [NameInMap("VideoCodec")]
                [Validation(Required=false)]
                public string VideoCodec { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1280</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public long? Width { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>399788187729597430-cn-qingdao</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>auto</para>
            /// </summary>
            [NameInMap("Trigger")]
            [Validation(Required=false)]
            public string Trigger { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>record</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
