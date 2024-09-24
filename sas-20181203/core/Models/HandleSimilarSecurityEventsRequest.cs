// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class HandleSimilarSecurityEventsRequest : TeaModel {
        /// <summary>
        /// <para>The whitelist rule. For example, if you want to add a file that contains the string a to the whitelist based on the MD5 hash value, set this parameter to {&quot;field&quot;:&quot;md5&quot;,&quot;operate&quot;:&quot;contains&quot;,&quot;fieldValue&quot;:&quot;aa&quot;}.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;field&quot;:&quot;md5&quot;,&quot;operate&quot;:&quot;contains&quot;,&quot;fieldValue&quot;:&quot;aa&quot;}</para>
        /// </summary>
        [NameInMap("MarkMissParam")]
        [Validation(Required=false)]
        public string MarkMissParam { get; set; }

        /// <summary>
        /// <para>The operation that you want to perform to handle the alert events.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeSecurityEventOperations~~">DescribeSecurityEventOperations</a> operation to query the operations.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>offline_handled</para>
        /// </summary>
        [NameInMap("OperationCode")]
        [Validation(Required=false)]
        public string OperationCode { get; set; }

        /// <summary>
        /// <para>The configuration of the operation that you want to perform to handle the alert events. The value of this parameter is in the JSON format.</para>
        /// <remarks>
        /// <para> If you set <b>OperationCode</b> to <b>kill_and_quara</b>, <b>block_ip</b>, or <b>virus_quara</b>, you must specify OperationParams. If you set <b>OperationCode</b> to other values, you can leave OperationParams empty. If you set <b>OperationCode</b> to <b>block_ip</b>, the value of OperationParams must consist of the following fields:</para>
        /// </remarks>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><b>expireTime</b>: the end time of locking. Unit: milliseconds.</description></item>
        /// </list>
        /// </remarks>
        /// <remarks>
        /// <para> If you set <b>OperationCode</b> to <b>kill_and_quara</b>, the value of OperationParams must consist of the following fields:</para>
        /// </remarks>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><b>subOperation</b>: the method of detection and removal. Valid values:</description></item>
        /// </list>
        /// </remarks>
        /// <remarks>
        /// <pre><c>*   **killAndQuaraFileByMd5andPath**: terminates the process and quarantines the source file of the process.
        /// *   **killByMd5andPath**: terminates the running process.
        /// </c></pre>
        /// </remarks>
        /// <remarks>
        /// <para> If you set <b>OperationCode</b> to <b>virus_quara</b>, the value of OperationParams consists of the following fields:</para>
        /// </remarks>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><b>subOperation</b>: the method of detection and removal. Valid values:</description></item>
        /// </list>
        /// </remarks>
        /// <remarks>
        /// <pre><c>*   **quaraFileByMd5andPath**: quarantines the source file of the process.
        /// </c></pre>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;expireTime&quot;:1646208726195}</para>
        /// </summary>
        [NameInMap("OperationParams")]
        [Validation(Required=false)]
        public string OperationParams { get; set; }

        /// <summary>
        /// <para>The remark of the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>remark test.</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The ID of the task that handles the alert events at a time.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~CreateSimilarSecurityEventsQueryTask~~">CreateSimilarSecurityEventsQueryTask</a> operation to query the IDs of tasks.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>666038</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
