// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetSmartHandleJobResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("JobResult")]
        [Validation(Required=false)]
        public GetSmartHandleJobResponseBodyJobResult JobResult { get; set; }
        public class GetSmartHandleJobResponseBodyJobResult : TeaModel {
            /// <summary>
            /// <para>智能分析结果</para>
            /// 
            /// <b>Example:</b>
            /// <para>拆条或智能标签信息</para>
            /// </summary>
            [NameInMap("AiResult")]
            [Validation(Required=false)]
            public string AiResult { get; set; }

            /// <summary>
            /// <para>媒资Id</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            [NameInMap("Usage")]
            [Validation(Required=false)]
            public string Usage { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public string Output { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SmartJobInfo")]
        [Validation(Required=false)]
        public GetSmartHandleJobResponseBodySmartJobInfo SmartJobInfo { get; set; }
        public class GetSmartHandleJobResponseBodySmartJobInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-12-26T04:11:10Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试描述</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("InputConfig")]
            [Validation(Required=false)]
            public GetSmartHandleJobResponseBodySmartJobInfoInputConfig InputConfig { get; set; }
            public class GetSmartHandleJobResponseBodySmartJobInfoInputConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>oss://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4 或 <b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
                /// </summary>
                [NameInMap("InputFile")]
                [Validation(Required=false)]
                public string InputFile { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ASR</para>
            /// </summary>
            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-12-26T04:11:10Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            [NameInMap("OutputConfig")]
            [Validation(Required=false)]
            public GetSmartHandleJobResponseBodySmartJobInfoOutputConfig OutputConfig { get; set; }
            public class GetSmartHandleJobResponseBodySmartJobInfoOutputConfig : TeaModel {
                /// <summary>
                /// <para>OSS Bucket</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-bucket</para>
                /// </summary>
                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                /// <summary>
                /// <para>OSS Object</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-object</para>
                /// </summary>
                [NameInMap("Object")]
                [Validation(Required=false)]
                public string Object { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试标题</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>userid。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1974526429******</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Finished</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;user&quot;:&quot;data&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
