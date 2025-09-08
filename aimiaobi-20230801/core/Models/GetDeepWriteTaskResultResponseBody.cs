// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetDeepWriteTaskResultResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>DataNotExists</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDeepWriteTaskResultResponseBodyData Data { get; set; }
        public class GetDeepWriteTaskResultResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://aimiaobi-service-pre-hangzhou.oss-cn-hangzhou.aliyuncs.com/aimiaobi/deep-write-workspace/142***1/dbaaebd1-eb1b-41e8-9b99-******-result.zip?Expire=1111">https://aimiaobi-service-pre-hangzhou.oss-cn-hangzhou.aliyuncs.com/aimiaobi/deep-write-workspace/142***1/dbaaebd1-eb1b-41e8-9b99-******-result.zip?Expire=1111</a></para>
            /// </summary>
            [NameInMap("ArtifactUrl")]
            [Validation(Required=false)]
            public string ArtifactUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>f8707efa-c30e-407f-a611-50871aa68952</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>错误消息</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
