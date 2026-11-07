// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ExportZookeeperDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The data overview.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ExportZookeeperDataResponseBodyData Data { get; set; }
        public class ExportZookeeperDataResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The task content.</para>
            /// </summary>
            [NameInMap("ContentMap")]
            [Validation(Required=false)]
            public Dictionary<string, object> ContentMap { get; set; }

            /// <summary>
            /// <para>The time when the task was created. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1631001140913</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The export type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>transactionLog: transaction log</description></item>
            /// <item><description>snapshot: snapshot file</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>snapshot</para>
            /// </summary>
            [NameInMap("ExportType")]
            [Validation(Required=false)]
            public string ExportType { get; set; }

            /// <summary>
            /// <para>The extended information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Extend")]
            [Validation(Required=false)]
            public string Extend { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse-cn-st21ri2****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The associated underlying task ID. This parameter is used only for troubleshooting when a task fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("KubeoneTaskIds")]
            [Validation(Required=false)]
            public string KubeoneTaskIds { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CREATE: creating</description></item>
            /// <item><description>RUNNING: running</description></item>
            /// <item><description>FINISH: completed</description></item>
            /// <item><description>FAILED: failed</description></item>
            /// <item><description>EXPIRE: expired</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FINISH</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the task was updated. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1632979237663</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The dynamic error message, which is used to replace the <b>%s</b> placeholder in the <b>ErrMessage</b> response parameter.</para>
        /// <remarks>
        /// <para>If <b>ErrMessage</b> returns <b>The Value of Input Parameter %s is not valid</b> and <b>DynamicMessage</b> returns <b>DtsJobId</b>, the specified <b>DtsJobId</b> request parameter is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>The specified parameter is invalid.</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-100-000</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// <list type="bullet">
        /// <item><description>If the request succeeds, a success message is returned.</description></item>
        /// <item><description>If the request fails, the cause of the failure is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Request processed successfully</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25EA0A83-9007-4E87-808C-637BE1A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The request result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request succeeded.</description></item>
        /// <item><description><c>false</c>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
