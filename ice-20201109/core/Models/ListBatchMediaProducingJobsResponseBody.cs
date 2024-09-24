// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListBatchMediaProducingJobsResponseBody : TeaModel {
        [NameInMap("EditingBatchJobList")]
        [Validation(Required=false)]
        public List<ListBatchMediaProducingJobsResponseBodyEditingBatchJobList> EditingBatchJobList { get; set; }
        public class ListBatchMediaProducingJobsResponseBodyEditingBatchJobList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-06-09T06:38:09Z</para>
            /// </summary>
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public string CompleteTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-06-09T06:36:48Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;MediaConfig&quot;: {
            ///       &quot;Volume&quot;: 0
            ///   },
            ///   &quot;SpeechConfig&quot;: {
            ///       &quot;Volume&quot;: 1
            ///   },
            ///  &quot;BackgroundMusicConfig&quot;: {
            ///       &quot;Volume&quot;: 0.3
            ///   }
            /// }</para>
            /// </summary>
            [NameInMap("EditingConfig")]
            [Validation(Required=false)]
            public string EditingConfig { get; set; }

            [NameInMap("Extend")]
            [Validation(Required=false)]
            public string Extend { get; set; }

            [NameInMap("InputConfig")]
            [Validation(Required=false)]
            public string InputConfig { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><b><b><b>7ecbee4c6d9b8474498e</b></b></b></para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Script</para>
            /// </summary>
            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-06-09T06:37:58Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;MediaURL&quot;: &quot;<a href="http://xxx.oss-cn-shanghai.aliyuncs.com/xxx_%7Bindex%7D.mp4">http://xxx.oss-cn-shanghai.aliyuncs.com/xxx_{index}.mp4</a>&quot;,
            ///   &quot;Count&quot;: 20,
            ///   &quot;MaxDuration&quot;: 15,
            ///   &quot;Width&quot;: 1080,
            ///   &quot;Height&quot;: 1920,
            ///   &quot;Video&quot;: {&quot;Crf&quot;: 27}
            /// }</para>
            /// </summary>
            [NameInMap("OutputConfig")]
            [Validation(Required=false)]
            public string OutputConfig { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Finished</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8EqYpQbZ6Eh7+Zz8DxVYoQ==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>3B-0E1A-586A-AC29-742247</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
