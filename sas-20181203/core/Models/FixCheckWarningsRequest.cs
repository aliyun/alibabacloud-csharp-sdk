// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class FixCheckWarningsRequest : TeaModel {
        /// <summary>
        /// <para>The parameters of the baseline check items to fix. The following parameters are included:</para>
        /// <list type="bullet">
        /// <item><description><b>checkId</b>: The ID of the check item.</description></item>
        /// <item><description><b>rules</b>: The fix rules (in array format).<list type="bullet">
        /// <item><description><b>value</b>: Specifies whether the fix method is selected. Valid values: <b>0</b> (not selected), <b>1</b> (selected).</description></item>
        /// <item><description><b>ruleId</b>: The ID of the fix method.</description></item>
        /// <item><description><b>paramList</b>: The list of fix methods (in array format).<br>      • <b>paramName</b>: The name of the fix method.<br>      • <b>value</b>: The value of the fix method.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;checkId&quot;:8,&quot;rules&quot;:[{&quot;ruleId&quot;:&quot;rule.ssh_Idle.interval&quot;,&quot;value&quot;:1,&quot;paramList&quot;:[{&quot;paramName&quot;:&quot;range_val&quot;,&quot;value&quot;:&quot;600&quot;},{&quot;paramName&quot;:&quot;range_val&quot;,&quot;value&quot;:&quot;600&quot;}]},{&quot;ruleId&quot;:&quot;rule.ssh_Idle.count&quot;,&quot;value&quot;:1,&quot;paramList&quot;:[{&quot;paramName&quot;:&quot;range_val&quot;,&quot;value&quot;:&quot;3&quot;}]}]}]</para>
        /// </summary>
        [NameInMap("CheckParams")]
        [Validation(Required=false)]
        public string CheckParams { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The retention period of the snapshot to create when performing the baseline fix operation. Valid values: 1 to 365. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RetentionDays")]
        [Validation(Required=false)]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// <para>The ID of the risk item.</para>
        /// <remarks>
        /// <para>To query the check item information for a specified risk item and a specified server, you must provide the risk item ID. You can call the <a href="~~DescribeCheckWarningSummary~~">DescribeCheckWarningSummary</a> operation to obtain the ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10354</para>
        /// </summary>
        [NameInMap("RiskId")]
        [Validation(Required=false)]
        public long? RiskId { get; set; }

        /// <summary>
        /// <para>The name of the snapshot to create when performing the baseline fix operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas_fix_2024-12-04</para>
        /// </summary>
        [NameInMap("SnapshotName")]
        [Validation(Required=false)]
        public string SnapshotName { get; set; }

        /// <summary>
        /// <para>The IP address of the access source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>165.225.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The unique ID of the asset instance to fix. You can call the <a href="~~DescribeWarningMachines~~">DescribeWarningMachines</a> operation to obtain the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75a417dda5f25edb5bed8f208a9a****,c7e10fd794262a1510d5648f9e5d****</para>
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
