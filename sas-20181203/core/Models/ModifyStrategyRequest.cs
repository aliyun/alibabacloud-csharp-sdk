// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyStrategyRequest : TeaModel {
        /// <summary>
        /// <para>The policy type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>custom</b>: custom policy.</description></item>
        /// <item><description><b>common</b>: standard policy.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>common</para>
        /// </summary>
        [NameInMap("CustomType")]
        [Validation(Required=false)]
        public string CustomType { get; set; }

        /// <summary>
        /// <para>The cycle of the baseline check. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Every 1 day.</description></item>
        /// <item><description><b>3</b>: Every 3 days.</description></item>
        /// <item><description><b>7</b>: Every 7 days.</description></item>
        /// <item><description><b>30</b>: Every 30 days.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CycleDays")]
        [Validation(Required=false)]
        public string CycleDays { get; set; }

        /// <summary>
        /// <para>The start time of the baseline check. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: The baseline check starts between 00:00 and 06:00.</description></item>
        /// <item><description><b>6</b>: The baseline check starts between 06:00 and 12:00.</description></item>
        /// <item><description><b>12</b>: The baseline check starts between 12:00 and 18:00.</description></item>
        /// <item><description><b>18</b>: The baseline check starts between 18:00 and 24:00.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is deprecated.</para>
        /// </remarks>
        /// <para>The value indicates the start hour of the daily check period, in hours.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18</para>
        /// </summary>
        [NameInMap("CycleStartTime")]
        [Validation(Required=false)]
        public string CycleStartTime { get; set; }

        /// <summary>
        /// <para>The end time of the policy execution. Format: hh:mm:ss.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>05:00:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the baseline check policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>245</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The name of the baseline check policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testStrategy</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The custom configuration of baseline check items. The value is in JSON format and contains the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><para><b>typeName</b>: The baseline name.</para>
        /// </description></item>
        /// <item><description><para><b>checkDetails</b>: The check details. The value is in JSON format.</para>
        /// <list type="bullet">
        /// <item><description><para><b>checkId</b>: The ID of the check item.</para>
        /// </description></item>
        /// <item><description><para><b>rules</b>: The policy configuration. The value is in JSON format.</para>
        /// <list type="bullet">
        /// <item><description><para><b>ruleId</b>: The ID of the policy configuration.</para>
        /// </description></item>
        /// <item><description><para><b>paramList</b>: The collection of policy parameter settings. The value is in JSON format.</para>
        /// <list type="bullet">
        /// <item><description><b>paramName</b>: The parameter name.</description></item>
        /// <item><description><b>value</b>: The parameter settings value.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;typeName&quot;:&quot;hc_centos_6_custom&quot;,&quot;checkDetails&quot;:[{&quot;checkId&quot;:4,&quot;rules&quot;:[{&quot;ruleId&quot;:&quot;pass_min_days_login_defs.must.cus&quot;,&quot;paramList&quot;:[{&quot;paramName&quot;:&quot;range_val&quot;,&quot;value&quot;:&quot;7&quot;}]}]}]}]</para>
        /// </summary>
        [NameInMap("RiskCustomParams")]
        [Validation(Required=false)]
        public string RiskCustomParams { get; set; }

        /// <summary>
        /// <para>The subtype of the check item. You can call the <a href="~~DescribeRiskType~~">DescribeRiskType</a> operation to obtain the subtype.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hc_exploit_redis</para>
        /// </summary>
        [NameInMap("RiskSubTypeName")]
        [Validation(Required=false)]
        public string RiskSubTypeName { get; set; }

        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.X.X</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The start time of the policy execution. Format: hh:mm:ss.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00:01:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The scan method of the policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>groupId</b>: group-based scan.</description></item>
        /// <item><description><b>uuid</b>: asset-based scan.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>groupId</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
