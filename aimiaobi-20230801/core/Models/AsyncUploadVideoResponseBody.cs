// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class AsyncUploadVideoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public AsyncUploadVideoResponseBodyData Data { get; set; }
        public class AsyncUploadVideoResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("VideoInfos")]
            [Validation(Required=false)]
            public List<AsyncUploadVideoResponseBodyDataVideoInfos> VideoInfos { get; set; }
            public class AsyncUploadVideoResponseBodyDataVideoInfos : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>视频中有一个房子</para>
                /// </summary>
                [NameInMap("VideoExtraInfo")]
                [Validation(Required=false)]
                public string VideoExtraInfo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>60616fad41b171f0bb4b4531948c0102</para>
                /// </summary>
                [NameInMap("VideoId")]
                [Validation(Required=false)]
                public string VideoId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123.mp4</para>
                /// </summary>
                [NameInMap("VideoName")]
                [Validation(Required=false)]
                public string VideoName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://123.mp4">http://123.mp4</a></para>
                /// </summary>
                [NameInMap("VideoUrl")]
                [Validation(Required=false)]
                public string VideoUrl { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>94512A33-8EC1-5452-A793-5C91F18ED2F0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
