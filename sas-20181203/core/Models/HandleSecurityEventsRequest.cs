// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class HandleSecurityEventsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to add multiple alert events to the whitelist at a time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("MarkBatch")]
        [Validation(Required=false)]
        public string MarkBatch { get; set; }

        /// <summary>
        /// <para>The whitelist rule. The value of this parameter is in the JSON format and contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>field</b>: The field based on which alert events are added to the whitelist.</para>
        /// </description></item>
        /// <item><description><para><b>operate</b>: The method that is used to added alert events to the whitelist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>notContains</b>: does not contain</description></item>
        /// <item><description><b>contains</b>: contains</description></item>
        /// <item><description><b>regex</b>: matches by regular expression</description></item>
        /// <item><description><b>strEqual</b>: equals</description></item>
        /// <item><description><b>strNotEqual</b>: does not equal</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>fieldValue</b>: The value of the field based on which alert events are added to the whitelist.</para>
        /// </description></item>
        /// <item><description><para><b>uuid</b>: The application scope of the whitelist rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>part</b>: the current asset</description></item>
        /// <item><description><b>ALL</b>: all assets</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeSecurityEventOperations~~">DescribeSecurityEventOperations</a> operation to obtain the fields that you can specify for <b>field</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;uuid&quot;:&quot;part&quot;,&quot;field&quot;:&quot;gmtModified&quot;,&quot;operate&quot;:&quot;contains&quot;,&quot;fieldValue&quot;:&quot;asd&quot;},{&quot;uuid&quot;:&quot;part&quot;,&quot;field&quot;:&quot;loginUser&quot;,&quot;operate&quot;:&quot;contains&quot;,&quot;fieldValue&quot;:&quot;vff&quot;}]</para>
        /// </summary>
        [NameInMap("MarkMissParam")]
        [Validation(Required=false)]
        public string MarkMissParam { get; set; }

        /// <summary>
        /// <para>The operation that you want to perform to handle the alert events. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>block_ip</b>: blocks the source IP address.</description></item>
        /// <item><description><b>advance_mark_mis_info</b>: adds the alert events to the whitelist.</description></item>
        /// <item><description><b>ignore</b>: ignores the alert events.</description></item>
        /// <item><description><b>manual_handled</b>: marks the alert events as manually handled.</description></item>
        /// <item><description><b>kill_process</b>: terminates the malicious process.</description></item>
        /// <item><description><b>cleanup</b>: performs in-depth virus detection and removal.</description></item>
        /// <item><description><b>kill_and_quara</b>: kills the malicious processes and quarantines the source file.</description></item>
        /// <item><description><b>disable_malicious_defense</b>: stops the container on which the alerting files or processes exist.</description></item>
        /// <item><description><b>client_problem_check</b>: performs troubleshooting.</description></item>
        /// <item><description><b>quara</b>: quarantines the source file of the malicious process.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>block_ip</para>
        /// </summary>
        [NameInMap("OperationCode")]
        [Validation(Required=false)]
        public string OperationCode { get; set; }

        /// <summary>
        /// <para>The configuration of the operation that you want to perform to handle the alert events.</para>
        /// <remarks>
        /// <para> If you set OperationCode to <c>kill_and_quara</c> or <c>block_ip</c>, you must specify OperationParams. If you set OperationCode to other values, you can leave OperationParams empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("OperationParams")]
        [Validation(Required=false)]
        public string OperationParams { get; set; }

        /// <summary>
        /// <para>The remarks of the handling operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>remark test.</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the member in the resource directory.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain the IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>16670360956*****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>The IDs of the alert events.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;909361&quot;]</para>
        /// </summary>
        [NameInMap("SecurityEventIds")]
        [Validation(Required=false)]
        public List<string> SecurityEventIds { get; set; }

        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.2.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
