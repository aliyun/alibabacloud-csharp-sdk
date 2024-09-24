// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetBatchMediaProducingJobResponseBody : TeaModel {
        [NameInMap("EditingBatchJob")]
        [Validation(Required=false)]
        public GetBatchMediaProducingJobResponseBodyEditingBatchJob EditingBatchJob { get; set; }
        public class GetBatchMediaProducingJobResponseBodyEditingBatchJob : TeaModel {
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public string CompleteTime { get; set; }

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

            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;ErrorCode&quot;: &quot;InvalidMaterial.NotFound&quot;,
            ///     &quot;ErrorMessage&quot;: &quot;The specified clips id not found:[\&quot;<b><b>30d0b5e871eebb2ff7f6c75a</b></b>\&quot;]&quot;
            /// }</para>
            /// </summary>
            [NameInMap("Extend")]
            [Validation(Required=false)]
            public string Extend { get; set; }

            [NameInMap("InputConfig")]
            [Validation(Required=false)]
            public string InputConfig { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><b><b>b6b2750d4308892ac3330238</b></b></para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }

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

            [NameInMap("SubJobList")]
            [Validation(Required=false)]
            public List<GetBatchMediaProducingJobResponseBodyEditingBatchJobSubJobList> SubJobList { get; set; }
            public class GetBatchMediaProducingJobResponseBodyEditingBatchJobSubJobList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>InvalidMaterial.NotFound</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>The specified clips id not found:[&quot;<b><b>30d0b5e871eebb2ff7f6c75a</b></b>&quot;]</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><b><b>8e81933d44e3ae69e2f81485</b></b></para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><b><b>1470b11171ee9d19e7e6c66a</b></b></para>
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>http:/xxx.oss-cn-shanghai.aliyuncs.com/xxx_0.mp4</para>
                /// </summary>
                [NameInMap("MediaURL")]
                [Validation(Required=false)]
                public string MediaURL { get; set; }

                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public string ProjectId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;NotifyAddress&quot;:&quot;<a href="http://xx.xx.xxx%22%7D">http://xx.xx.xxx&quot;}</a></para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b>36-3C1E-4417-BDB2-1E034F</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
