// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CsasEdr20241122.Models
{
    public class HandleSecurityEventsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to add to the whitelist in batches. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Yes.</description></item>
        /// <item><description>false: No.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("MarkBatch")]
        [Validation(Required=false)]
        public bool? MarkBatch { get; set; }

        /// <summary>
        /// <para>The JSON array string used when adding an advanced whitelist or precise defense whitelist rule. This parameter applies only when OperationCode is set to <c>advance_mark_mis_info</c> or <c>defense_mark_mis_info</c>. Do not pass this parameter for other operations.</para>
        /// <para>Each rule contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><c>field</c>: The matching field, which is obtained from the FiledName in MarkFieldsSource returned by DescribeSecurityEventOperations.</description></item>
        /// <item><description><c>fieldValue</c>: The user-defined matching value, which does not need to be equal to the original field value of the current alert.</description></item>
        /// <item><description><c>operate</c>: The matching operator, which must belong to the SupportedMisType list returned for the field. Do not use a general fixed enumeration instead of the supported range for the current field.</description></item>
        /// <item><description><c>assetScope</c>: The effective scope object of the whitelist rule, which includes matchMode (scope mode) and the corresponding matchTargetIds (scope target list).</description></item>
        /// </list>
        /// <para>The assetScope parameter specifies the effective scope of the rule. If you only handle the alert and do not add a whitelist rule, you can omit this parameter or pass an empty array string <c>[]</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;field&quot;:&quot;processPath&quot;,&quot;fieldValue&quot;:&quot;/tmp/evil&quot;,&quot;operate&quot;:&quot;strEqual&quot;,&quot;assetScope&quot;:{&quot;matchMode&quot;:&quot;DeviceGroupNormal&quot;,&quot;matchTargetIds&quot;:[&quot;device-group-1&quot;]}}]</para>
        /// </summary>
        [NameInMap("MarkMissParam")]
        [Validation(Required=false)]
        public string MarkMissParam { get; set; }

        /// <summary>
        /// <para>The operation code for handling the endpoint alert. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>advance_mark_mis_info: Adds to the advanced whitelist.</description></item>
        /// <item><description>defense_mark_mis_info: Adds to the precise defense whitelist.</description></item>
        /// <item><description>mark_mis_info: Marks as a false positive (standard whitelisting).</description></item>
        /// <item><description>rm_mark_mis_info: Removes from the standard or advanced whitelist.</description></item>
        /// <item><description>rm_defense_mark_mis_info: Removes from the precise defense whitelist.</description></item>
        /// <item><description>ignore: Ignores the alert.</description></item>
        /// <item><description>manual_handled: Marks as manually handled.</description></item>
        /// <item><description>cancle_manual: Cancels the manually handled status.
        /// The preceding list is not a fixed set of operations that can be performed on every alert. The actual available operations are also restricted by feature switches, dynamic whitelists, alert operation configurations, and the current status. Before you call this operation, call DescribeSecurityEventOperations to query the currently available operations for the alert and check UserCanOperate. Use only the OperationCode values that are allowed in the query result.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ignore</para>
        /// </summary>
        [NameInMap("OperationCode")]
        [Validation(Required=false)]
        public string OperationCode { get; set; }

        /// <summary>
        /// <para>The operation parameters, represented as a JSON object string. If this parameter is not passed or an empty string is passed, the backend processes it as <c>{}</c>. The specific parameters must correspond to the OperationCode and are subject to the OperationParams returned by DescribeSecurityEventOperations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("OperationParams")]
        [Validation(Required=false)]
        public string OperationParams { get; set; }

        /// <summary>
        /// <para>The remark for the handling operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>remark test.</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The IDs of the security alert events to handle.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SecurityEventIds")]
        [Validation(Required=false)]
        public List<long?> SecurityEventIds { get; set; }

    }

}
