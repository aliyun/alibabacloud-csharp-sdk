// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class FixCheckWarningsRequest : TeaModel {
        /// <summary>
        /// <para>The parameters for the baseline risk item that you want to fix.</para>
        /// <list type="bullet">
        /// <item><description><para><b>checkId</b>: the ID of the check item that corresponds to the baseline risk item.</para>
        /// </description></item>
        /// <item><description><para><b>rules</b>: an array that consists of the rules applied to fixes.</para>
        /// <list type="bullet">
        /// <item><description><b>value</b>: specifies whether a fix method is selected. Valid values: <b>0</b> and <b>1</b>. The value 0 indicates that no fix method is selected and the value 1 indicates that a fix method is selected.</description></item>
        /// <item><description><b>ruleId</b>: the ID of the fix method.</description></item>
        /// <item><description><b>paramList</b>: an array that consists of the details about the fix method.\
        /// • <b>paramName</b>: the name of the fix method.\
        /// • <b>value</b>: the value of the fix method.</description></item>
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
        /// <para>The language of the content within the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The ID of the baseline risk item.</para>
        /// <remarks>
        /// <para> To query specified baseline risk items and the check items of a specified server, you must provide the IDs of the baseline risk items. You can call the <a href="~~DescribeCheckWarningSummary~~">DescribeCheckWarningSummary</a> operation to query the IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10354</para>
        /// </summary>
        [NameInMap("RiskId")]
        [Validation(Required=false)]
        public long? RiskId { get; set; }

        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>165.225.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The UUID of the asset for which you want to fix the baseline risk item. You can call the <a href="~~DescribeWarningMachines~~">DescribeWarningMachines</a> operation to query the UUIDs of assets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75a417dda5f25edb5bed8f208a9a****,c7e10fd794262a1510d5648f9e5d****</para>
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
