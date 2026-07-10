// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DeployApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>The API status or POP error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: success.</description></item>
        /// <item><description><b>3xx</b>: redirection.</description></item>
        /// <item><description><b>4xx</b>: request error.</description></item>
        /// <item><description><b>5xx</b>: server error.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeployApplicationResponseBodyData Data { get; set; }
        public class DeployApplicationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7171a6ca-d1cd-4928-8642-7d5cfe69****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The returned change order ID, which is used to query the task execution status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>01db03d3-3ee9-48b3-b3d0-dfce2d88****</para>
            /// </summary>
            [NameInMap("ChangeOrderId")]
            [Validation(Required=false)]
            public string ChangeOrderId { get; set; }

            /// <summary>
            /// <para>Indicates whether the change published by a Resource Access Management (RAM) user requires approval. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: approval is required.</description></item>
            /// <item><description><b>false</b>: approval is not required.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsNeedApproval")]
            [Validation(Required=false)]
            public bool? IsNeedApproval { get; set; }

        }

        /// <summary>
        /// <para>The error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the request is successful, the <b>ErrorCode</b> field is not returned.</description></item>
        /// <item><description>If the request fails, the <b>ErrorCode</b> field is returned. For more information, see the <b>Error codes</b> section in this topic.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>空</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The additional information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the request is successful, <b>success</b> is returned.</description></item>
        /// <item><description>If the request fails, a specific error code is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01CF26C7-00A3-4AA6-BA76-7E95F2A3***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the application deployment is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: the deployment is successful.</description></item>
        /// <item><description><b>false</b>: the deployment failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID, which is used to query the details of a request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac1a0b2215622246421415014e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
