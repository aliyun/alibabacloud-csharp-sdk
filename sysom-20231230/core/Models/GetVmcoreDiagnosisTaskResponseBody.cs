// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetVmcoreDiagnosisTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetVmcoreDiagnosisTaskResponseBodyData Data { get; set; }
        public class GetVmcoreDiagnosisTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-12-02T17:36:12</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>result</para>
            /// </summary>
            [NameInMap("diagnoseResult")]
            [Validation(Required=false)]
            public string DiagnoseResult { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>error message</para>
            /// </summary>
            [NameInMap("errorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>bbe94a98-4192-4172-b856-95777e0a55d7</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("taskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vmcore</para>
            /// </summary>
            [NameInMap("taskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            [NameInMap("urls")]
            [Validation(Required=false)]
            public GetVmcoreDiagnosisTaskResponseBodyDataUrls Urls { get; set; }
            public class GetVmcoreDiagnosisTaskResponseBodyDataUrls : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://bucket-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/debuginfo-common/file/path">https://bucket-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/debuginfo-common/file/path</a></para>
                /// </summary>
                [NameInMap("debuginfoCommonUrl")]
                [Validation(Required=false)]
                public string DebuginfoCommonUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://bucket-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/debuginfo/file/path">https://bucket-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/debuginfo/file/path</a></para>
                /// </summary>
                [NameInMap("debuginfoUrl")]
                [Validation(Required=false)]
                public string DebuginfoUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://bucket-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/dmesg/file/path">https://bucket-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/dmesg/file/path</a></para>
                /// </summary>
                [NameInMap("dmesgUrl")]
                [Validation(Required=false)]
                public string DmesgUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://bucket-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/vmcore/file/path">https://bucket-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/vmcore/file/path</a></para>
                /// </summary>
                [NameInMap("vmcoreUrl")]
                [Validation(Required=false)]
                public string VmcoreUrl { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SysomOpenAPIException: SysomOpenAPI.InvalidParameter Invalid params, should be json string or dict</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D693121-C925-5154-8DF6-C09A8B369822</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
