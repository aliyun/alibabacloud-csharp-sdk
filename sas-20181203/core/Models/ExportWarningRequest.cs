// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ExportWarningRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the baseline issue is handled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Y</b>: The issue is handled.</description></item>
        /// <item><description><b>N</b>: The issue is not handled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>N</para>
        /// </summary>
        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        /// <summary>
        /// <para>The type of the export task. Set the value to <b>hc_check_warning</b>, which indicates exporting baseline check results.</para>
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
        /// <para>You can call the <a href="~~DescribeAllGroups~~">DescribeAllGroups</a> operation to obtain the ID of the server group.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>13007754</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>Specifies the export method for weak password baseline check results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Weak passwords are masked before export.</description></item>
        /// <item><description><b>1</b>: Weak passwords are exported in plaintext.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IsCleartextPwd")]
        [Validation(Required=false)]
        public int? IsCleartextPwd { get; set; }

        /// <summary>
        /// <para>Specifies whether to export the baseline check results in summary mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: The results are not exported in summary mode.</description></item>
        /// <item><description><b>1</b>: The results are exported in summary mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsSummaryExport")]
        [Validation(Required=false)]
        public int? IsSummaryExport { get; set; }

        /// <summary>
        /// <para>Specifies the language type for the request and response messages. Default value: <b>zh</b>. Valid values:</para>
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
        /// <para>The IDs of the risk items in the baseline check results. Separate multiple risk item IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>123,124</para>
        /// </summary>
        [NameInMap("RiskIds")]
        [Validation(Required=false)]
        public string RiskIds { get; set; }

        /// <summary>
        /// <para>The risk levels of the baselines. Separate multiple risk levels with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>high</b>: High</description></item>
        /// <item><description><b>medium</b>: Medium</description></item>
        /// <item><description><b>low</b>: Low</description></item>
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
        /// <para>The source IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The statuses of the risk items in the baseline check results. Separate multiple status values with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>3</b>: Passed</description></item>
        /// <item><description><b>1</b>: Failed</description></item>
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
        /// <para>Specifies the baseline subtypes to which the baseline check results to be exported belong. Separate multiple subtypes with commas (,).</para>
        /// <remarks>
        /// <para>The value is the <b>TypeName</b> field under the <b>SubTypes</b> field returned by the <a href="~~DescribeRiskType~~">DescribeRiskType</a> operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>hc_middleware_ack_master</para>
        /// </summary>
        [NameInMap("SubTypeNames")]
        [Validation(Required=false)]
        public string SubTypeNames { get; set; }

        /// <summary>
        /// <para>Specifies the baseline type to which the baseline check results to be exported belong.</para>
        /// <remarks>
        /// <para>The value is the <b>TypeName</b> field returned by the <a href="~~DescribeRiskType~~">DescribeRiskType</a> operation. If both <b>TypeName</b> and <b>TypeNames</b> are specified, only <b>TypeName</b> takes effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>hc_container</para>
        /// </summary>
        [NameInMap("TypeName")]
        [Validation(Required=false)]
        public string TypeName { get; set; }

        /// <summary>
        /// <para>Specifies the baseline types to which the baseline check results to be exported belong. Separate multiple types with commas (,).</para>
        /// <remarks>
        /// <para>The value is the <b>TypeName</b> field returned by the <a href="~~DescribeRiskType~~">DescribeRiskType</a> operation. If both <b>TypeName</b> and <b>TypeNames</b> are specified, only <b>TypeName</b> takes effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>hc_container,cis</para>
        /// </summary>
        [NameInMap("TypeNames")]
        [Validation(Required=false)]
        public string TypeNames { get; set; }

        /// <summary>
        /// <para>The UUIDs of the server assets for which you want to export the baseline check results. Separate multiple UUIDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>inet-7c676676-06fa-442e-90fb-b802e****,inet-7c676676-06fa-442e-90fb-b****</para>
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
