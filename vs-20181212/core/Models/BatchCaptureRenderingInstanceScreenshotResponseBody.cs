// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class BatchCaptureRenderingInstanceScreenshotResponseBody : TeaModel {
        /// <summary>
        /// <para>The dry run result.</para>
        /// </summary>
        [NameInMap("Datatest")]
        [Validation(Required=false)]
        public BatchCaptureRenderingInstanceScreenshotResponseBodyDatatest Datatest { get; set; }
        public class BatchCaptureRenderingInstanceScreenshotResponseBodyDatatest : TeaModel {
            /// <summary>
            /// <para>The dry run result.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public BatchCaptureRenderingInstanceScreenshotResponseBodyDatatestResult Result { get; set; }
            public class BatchCaptureRenderingInstanceScreenshotResponseBodyDatatestResult : TeaModel {
                /// <summary>
                /// <para>The number of successful instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SuccessCount")]
                [Validation(Required=false)]
                public long? SuccessCount { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of failed instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FailedCount")]
        [Validation(Required=false)]
        public long? FailedCount { get; set; }

        /// <summary>
        /// <para>The list of instances for which screenshots failed.</para>
        /// </summary>
        [NameInMap("FailedItems")]
        [Validation(Required=false)]
        public List<BatchCaptureRenderingInstanceScreenshotResponseBodyFailedItems> FailedItems { get; set; }
        public class BatchCaptureRenderingInstanceScreenshotResponseBodyFailedItems : TeaModel {
            /// <summary>
            /// <para>The error code of the failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("ErrCode")]
            [Validation(Required=false)]
            public string ErrCode { get; set; }

            /// <summary>
            /// <para>The error message of the failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Not Applied</para>
            /// </summary>
            [NameInMap("ErrMessage")]
            [Validation(Required=false)]
            public string ErrMessage { get; set; }

            /// <summary>
            /// <para>The instance ID of the cloud application service instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>render-072da95539d3402da90353b244191722</para>
            /// </summary>
            [NameInMap("RenderingInstanceId")]
            [Validation(Required=false)]
            public string RenderingInstanceId { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of successful instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public long? SuccessCount { get; set; }

        /// <summary>
        /// <para>The list of successful instances.</para>
        /// </summary>
        [NameInMap("SuccessItems")]
        [Validation(Required=false)]
        public List<BatchCaptureRenderingInstanceScreenshotResponseBodySuccessItems> SuccessItems { get; set; }
        public class BatchCaptureRenderingInstanceScreenshotResponseBodySuccessItems : TeaModel {
            /// <summary>
            /// <para>The time when the screenshot was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-05-19T14:46:37+08:00</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The download URL of the screenshot.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://testts-1.oss-cn-beijing.aliyuncs.com/app/test-zip-file.zip">https://testts-1.oss-cn-beijing.aliyuncs.com/app/test-zip-file.zip</a></para>
            /// </summary>
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// <para>The instance ID of the cloud application service instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>render-1ada8cd82783407b99fa202826fc6447</para>
            /// </summary>
            [NameInMap("RenderingInstanceId")]
            [Validation(Required=false)]
            public string RenderingInstanceId { get; set; }

        }

    }

}
