// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDiagnosticReportsRequest : TeaModel {
        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100.</para>
        /// <para>Default value:</para>
        /// <list type="bullet">
        /// <item><description>If this parameter is left empty, the default value is 10.</description></item>
        /// <item><description>If you set this parameter to a value that is greater than 100, the default value is 100.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of <c>NextToken</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The IDs of diagnostic reports.</para>
        /// </summary>
        [NameInMap("ReportIds")]
        [Validation(Required=false)]
        public List<string> ReportIds { get; set; }

        /// <summary>
        /// <para>The IDs of resources. You can specify up to 100 resource IDs.</para>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public List<string> ResourceIds { get; set; }

        /// <summary>
        /// <para>The severity level of the diagnostic report. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Unknown: The diagnostic does not start, fails to run, or unexpectedly exits without a diagnosis.</description></item>
        /// <item><description>Normal: No exceptions are detected.</description></item>
        /// <item><description>Info: Diagnostic information is recorded and may be related to exceptions.</description></item>
        /// <item><description>Warn: Diagnostic information is recorded and may indicate exceptions.</description></item>
        /// <item><description>Critical: Critical exceptions are detected.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("Severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// <para>The status of the diagnostic report. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>InProgress</description></item>
        /// <item><description>Failed</description></item>
        /// <item><description>Finished</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Finished</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
