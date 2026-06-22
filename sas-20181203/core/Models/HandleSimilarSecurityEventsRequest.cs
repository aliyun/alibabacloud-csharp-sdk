// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class HandleSimilarSecurityEventsRequest : TeaModel {
        /// <summary>
        /// <para>The rule for adding items to the whitelist. For example, to add a whitelist rule based on file MD5 where the file contains the string &quot;a&quot;, set this parameter to {&quot;field&quot;:&quot;md5&quot;,&quot;operate&quot;:&quot;contains&quot;,&quot;fieldValue&quot;:&quot;aa&quot;}.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;field&quot;:&quot;md5&quot;,&quot;operate&quot;:&quot;contains&quot;,&quot;fieldValue&quot;:&quot;aa&quot;}</para>
        /// </summary>
        [NameInMap("MarkMissParam")]
        [Validation(Required=false)]
        public string MarkMissParam { get; set; }

        /// <summary>
        /// <para>The type of operation for batch processing alert events of the same type.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeSecurityEventOperations~~">DescribeSecurityEventOperations</a> operation to obtain this parameter.</para>
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
        /// <para>The configuration of the sub-operation for handling alerting events. The value is in JSON format.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>OperationCode</b> is set to <b>kill_and_quara</b>, <b>block_ip</b>, or <b>virus_quara</b>. For other values of <b>OperationCode</b>, this parameter can be left empty.</para>
        /// </remarks>
        /// <remarks>
        /// <para>When <b>OperationCode</b> is set to <b>block_ip</b>, the following field is included:</para>
        /// <list type="bullet">
        /// <item><description><b>expireTime</b>: the lock expiration time. Unit: milliseconds.</description></item>
        /// </list>
        /// <para>When <b>OperationCode</b> is set to <b>kill_and_quara</b>, the following field is included:</para>
        /// <list type="bullet">
        /// <item><description><b>subOperation</b>: the method used to scan and remove threats. Valid values:<list type="bullet">
        /// <item><description><b>killAndQuaraFileByMd5andPath</b>: terminates the process and moves the file to the quarantined file.</description></item>
        /// <item><description><b>killByMd5andPath</b>: terminates the running process.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>When <b>OperationCode</b> is set to <b>virus_quara</b>, the following field is included:</para>
        /// <list type="bullet">
        /// <item><description><b>subOperation</b>: the method used to scan and remove threats. Valid values:<list type="bullet">
        /// <item><description><b>quaraFileByMd5andPath</b>: moves the source file of the process to the quarantined file.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;expireTime&quot;:1646208726195}</para>
        /// </summary>
        [NameInMap("OperationParams")]
        [Validation(Required=false)]
        public string OperationParams { get; set; }

        /// <summary>
        /// <para>The remarks for the operation.</para>
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
        /// <para>The IP address of the access source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The ID of the task that batch processes all alert events of the same type.</para>
        /// <remarks>
        /// <para>Call the <a href="~~CreateSimilarSecurityEventsQueryTask~~">CreateSimilarSecurityEventsQueryTask</a> operation to obtain this parameter.</para>
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
