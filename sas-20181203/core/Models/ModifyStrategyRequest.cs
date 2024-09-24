// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyStrategyRequest : TeaModel {
        /// <summary>
        /// <para>The type of the baseline check policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>custom</b>: a custom baseline check policy</description></item>
        /// <item><description><b>common</b>: a standard baseline check policy</description></item>
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
        /// <para>The new interval of the baseline check. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: every 2 days</description></item>
        /// <item><description><b>3</b>: every 4 days</description></item>
        /// <item><description><b>7</b>: every 8 days</description></item>
        /// <item><description><b>30</b>: every 31 days</description></item>
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
        /// <para>The new time range during which the baseline check starts. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: The baseline check starts within the time range from 00:00 to 06:00.</description></item>
        /// <item><description><b>6</b>: The baseline check starts within the time range from 06:00 to 12:00.</description></item>
        /// <item><description><b>12</b>: The baseline check starts within the time range from 12:00 to 18:00.</description></item>
        /// <item><description><b>18</b>: The baseline check starts within the time range from 18:00 to 24:00.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is deprecated.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>18</para>
        /// </summary>
        [NameInMap("CycleStartTime")]
        [Validation(Required=false)]
        public string CycleStartTime { get; set; }

        /// <summary>
        /// <para>The time when the baseline check based on the baseline check policy ends. Specify the time in the hh:mm:ss format.</para>
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
        /// <para>The new name of the baseline check policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testStrategy</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The custom configurations of the baseline. The value of this parameter is in the JSON format and contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>typeName</b>: the name of the baseline.</para>
        /// </description></item>
        /// <item><description><para><b>checkDetails</b>: the details of the baseline. The value is in the JSON format.</para>
        /// <list type="bullet">
        /// <item><description><para><b>checkId</b>: the ID of the check item.</para>
        /// </description></item>
        /// <item><description><para><b>rules</b>: the rule configurations. The value is in the JSON format.</para>
        /// <list type="bullet">
        /// <item><description><para><b>ruleId</b>: the ID of the rule.</para>
        /// </description></item>
        /// <item><description><para><b>paramList</b>: the list of parameters in the rule. The value is in the JSON format.</para>
        /// <list type="bullet">
        /// <item><description><b>paramName</b>: the name of the parameter.</description></item>
        /// <item><description><b>value</b>: the value of the parameter.</description></item>
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
        /// <para>The subtype of the baselines. You can call the <a href="~~DescribeRiskType~~">DescribeRiskType</a> operation to query the subtypes of baselines.</para>
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
        /// <para>The time when the baseline check based on the baseline check policy starts. Specify the time in the hh:mm:ss format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00:01:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The method that is used to apply the baseline check policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>groupId</b>: asset groups</description></item>
        /// <item><description><b>uuid</b>: assets</description></item>
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
