// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class IgnoreHcCheckWarningsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the check item.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/116182.html">DescribeCheckWarnings</a> operation to query the IDs of check items.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>21313</para>
        /// </summary>
        [NameInMap("CheckIds")]
        [Validation(Required=false)]
        public string CheckIds { get; set; }

        /// <summary>
        /// <para>The ID of the alert that is triggered by the check item. Separate multiple IDs with commas (,).</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/116182.html">DescribeCheckWarnings</a> operation to query the IDs of alerts that are triggered by check items.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>98146905,98146907</para>
        /// </summary>
        [NameInMap("CheckWarningIds")]
        [Validation(Required=false)]
        public string CheckWarningIds { get; set; }

        /// <summary>
        /// <para>The reason for the current operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ignore</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>The ID of the risk item that you want to ignore or cancel ignoring.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/116179.html">DescribeCheckWarningSummary</a> operation to query the IDs of risk items.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>51</para>
        /// </summary>
        [NameInMap("RiskId")]
        [Validation(Required=false)]
        public string RiskId { get; set; }

        /// <summary>
        /// <para>The data source. If this parameter is left empty, the server baseline results are queried by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>default</b>: server</description></item>
        /// <item><description><b>agentless</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>agentless</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The type of the operation that you want to perform. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: ignores a risk item</description></item>
        /// <item><description><b>2</b>: cancels ignoring a risk item</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public long? Type { get; set; }

    }

}
