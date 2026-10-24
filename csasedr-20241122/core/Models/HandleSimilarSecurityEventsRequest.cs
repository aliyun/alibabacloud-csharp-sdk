// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CsasEdr20241122.Models
{
    public class HandleSimilarSecurityEventsRequest : TeaModel {
        /// <summary>
        /// <para>The JSON array string used to add advanced whitelist or precise defense whitelist rules. This parameter applies only to scenarios where the OperationCode is <c>advance_mark_mis_info</c> or <c>defense_mark_mis_info</c>. Do not pass this parameter for other operations.</para>
        /// <para>Each rule includes the following fields:</para>
        /// <list type="bullet">
        /// <item><description><c>field</c>: The matching field, which is obtained from the FiledName field in the MarkFieldsSource returned by the DescribeSecurityEventOperations operation.</description></item>
        /// <item><description><c>fieldValue</c>: The user-defined matching value, which does not need to equal the original field value of the current alert.</description></item>
        /// <item><description><c>operate</c>: The matching operator, which must be included in the list returned by the SupportedMisType corresponding to the field. Do not use a common fixed enumeration to replace the supported scope of the current field.</description></item>
        /// <item><description><c>assetScope</c>: The effective scope object of the whitelist rule, which includes matchMode (the scope mode) and the corresponding matchTargetIds (the list of scope targets).</description></item>
        /// </list>
        /// <para>The assetScope field specifies the effective scope of the rule. If you only process alerts and do not add whitelist rules, you can leave this parameter empty or pass an empty array string <c>[]</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;field&quot;:&quot;processPath&quot;,&quot;fieldValue&quot;:&quot;/tmp/evil&quot;,&quot;operate&quot;:&quot;strEqual&quot;,&quot;assetScope&quot;:{&quot;matchMode&quot;:&quot;DeviceGroupNormal&quot;,&quot;matchTargetIds&quot;:[&quot;device-group-1&quot;]}}]</para>
        /// </summary>
        [NameInMap("MarkMissParam")]
        [Validation(Required=false)]
        public string MarkMissParam { get; set; }

        /// <summary>
        /// <para>The operation code for processing endpoint alerts. The allowed operations for the code are as follows:</para>
        /// <list type="bullet">
        /// <item><description><c>advance_mark_mis_info</c>: Adds the alert to the advanced whitelist.</description></item>
        /// <item><description><c>defense_mark_mis_info</c>: Adds the alert to the precise defense whitelist.</description></item>
        /// <item><description><c>mark_mis_info</c>: Marks the alert as a false positive and adds it to the common whitelist.</description></item>
        /// <item><description><c>rm_mark_mis_info</c>: Removes the alert from the common or advanced whitelist.</description></item>
        /// <item><description><c>rm_defense_mark_mis_info</c>: Removes the alert from the precise defense whitelist.</description></item>
        /// <item><description><c>ignore</c>: Ignores the alert.</description></item>
        /// <item><description><c>manual_handled</c>: Marks the alert as manually handled.</description></item>
        /// <item><description><c>cancle_manual</c>: Cancels the manually handled status of the alert.</description></item>
        /// </list>
        /// <para>The preceding set is not a fixed list of operations that can be performed on every alert. The actual available operations are also restricted by conditions such as feature switches, dynamic whitelists, alert operation configurations, and the current status. Before calling this operation, call the DescribeSecurityEventOperations operation to query the currently available operations for the alert and check UserCanOperate. Use only the OperationCode values that are allowed in the query results.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ignore</para>
        /// </summary>
        [NameInMap("OperationCode")]
        [Validation(Required=false)]
        public string OperationCode { get; set; }

        /// <summary>
        /// <para>The operation parameters, represented as a JSON object string. If this parameter is not passed or an empty string is passed, the backend processes it as <c>{}</c>. The specific parameters must correspond to the OperationCode and are subject to the OperationParams returned by the DescribeSecurityEventOperations operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("OperationParams")]
        [Validation(Required=false)]
        public string OperationParams { get; set; }

        /// <summary>
        /// <para>The remark for the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>remark test.</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The ID of the similar alert query task. You can obtain the ID by calling the CreateSimilarSecurityEventsQueryTask operation. The task must belong to the current calling account and must be a similar alert query task. Before calling this operation, call the DescribeSecurityEventOperationStatus operation to query the TaskStatus. Wait until the status reaches DataRetrieved before initiating the processing. The New or RetrievingData status indicates that data extraction is not complete.</para>
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
