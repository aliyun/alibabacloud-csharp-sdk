// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ExportWarningRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the baseline risks are handled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Y</b>: yes</description></item>
        /// <item><description><b>N</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>N</para>
        /// </summary>
        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        /// <summary>
        /// <para>The type of the export task. Set the value to <b>hc_check_warning</b>, which indicates tasks to export baseline check results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hc_check_warning</para>
        /// </summary>
        [NameInMap("ExportType")]
        [Validation(Required=false)]
        public string ExportType { get; set; }

        /// <summary>
        /// <para>The ID of the server group.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeAllGroups~~">DescribeAllGroups</a> operation to query the IDs of server groups.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>13007754</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>The export method of the results for the weak password baseline check. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: exports the check results after it is masked.</description></item>
        /// <item><description><b>1</b>: exports the check results in plaintext.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IsCleartextPwd")]
        [Validation(Required=false)]
        public int? IsCleartextPwd { get; set; }

        /// <summary>
        /// <para>Specifies whether the baseline check results are aggregated and exported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: no</description></item>
        /// <item><description><b>1</b>: yes</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsSummaryExport")]
        [Validation(Required=false)]
        public int? IsSummaryExport { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
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
        /// <para>The ID of the risk item in the baseline check results. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>123,124</para>
        /// </summary>
        [NameInMap("RiskIds")]
        [Validation(Required=false)]
        public string RiskIds { get; set; }

        /// <summary>
        /// <para>The severity of the baseline check item. Separate multiple severities with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>high</b></description></item>
        /// <item><description><b>medium</b></description></item>
        /// <item><description><b>low</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>high,medium</para>
        /// </summary>
        [NameInMap("RiskLevels")]
        [Validation(Required=false)]
        public string RiskLevels { get; set; }

        /// <summary>
        /// <para>The name of the baseline.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba Cloud Standard - Windows 2016/2019  Security Baseline</para>
        /// </summary>
        [NameInMap("RiskName")]
        [Validation(Required=false)]
        public string RiskName { get; set; }

        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The status of the check item in the baseline check results. Separate multiple statuses with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>3</b>: passed</description></item>
        /// <item><description><b>1</b>: failed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1,3</para>
        /// </summary>
        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public string StatusList { get; set; }

        /// <summary>
        /// <para>The ID of the baseline check policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public long? StrategyId { get; set; }

        /// <summary>
        /// <para>The subtypes of the baselines based on which baseline checks are performed. Separate multiple subtypes with commas (,).</para>
        /// <remarks>
        /// <para>You must set the value of this parameter to the value of the <b>TypeName</b> parameter that is contained in the <b>SubTypes</b> parameter. You can call the <a href="~~DescribeRiskType~~">DescribeRiskType</a> operation to obtain the value of the TypeName parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>hc_middleware_ack_master</para>
        /// </summary>
        [NameInMap("SubTypeNames")]
        [Validation(Required=false)]
        public string SubTypeNames { get; set; }

        /// <summary>
        /// <para>The type of the baseline based on which baseline checks are performed.</para>
        /// <remarks>
        /// <para>You must set the value of this parameter to the value of the <b>TypeName</b> parameter that is returned by calling the <a href="~~DescribeRiskType~~">DescribeRiskType</a> operation. If both the <b>TypeName</b> and <b>TypeNames</b> parameters are specified, only the <b>TypeName</b> parameter takes effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>hc_container</para>
        /// </summary>
        [NameInMap("TypeName")]
        [Validation(Required=false)]
        public string TypeName { get; set; }

        /// <summary>
        /// <para>The types of the baselines based on which baseline checks are performed. Separate multiple types with commas (,).</para>
        /// <remarks>
        /// <para>You must set the value of this parameter to the value of the <b>TypeName</b> parameter that is returned by calling the <a href="~~DescribeRiskType~~">DescribeRiskType</a> operation. If both the <b>TypeName</b> and <b>TypeNames</b> parameters are specified, only the <b>TypeName</b> parameter takes effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>hc_container,cis</para>
        /// </summary>
        [NameInMap("TypeNames")]
        [Validation(Required=false)]
        public string TypeNames { get; set; }

        /// <summary>
        /// <para>The UUID of the server whose baseline check results you want to export. Separate multiple UUIDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>inet-7c676676-06fa-442e-90fb-b802e****,inet-7c676676-06fa-442e-90fb-b****</para>
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
