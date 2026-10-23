// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDiagnosticReportsRequest : TeaModel {
        /// <summary>
        /// <para>The number of entries per page for a paging query. Maximum value: 100.</para>
        /// <para>Default value:</para>
        /// <list type="bullet">
        /// <item><description>If no Settings are specified, the default value is 10.</description></item>
        /// <item><description>If the Settings value is greater than 100, the default value is 100.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The query token. Set the value to the <c>NextToken</c> value returned from the previous call. You do not need to specify this parameter for the first call.</para>
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
        /// <para>The list of diagnostic report IDs.</para>
        /// </summary>
        [NameInMap("ReportIds")]
        [Validation(Required=false)]
        public List<string> ReportIds { get; set; }

        /// <summary>
        /// <para>The list of resource IDs. A maximum of 100 IDs are supported.</para>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public List<string> ResourceIds { get; set; }

        /// <summary>
        /// <para>The severity level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Unknown: The initial state, which indicates that the diagnosis has not started or the diagnostic program exited abnormally, and no diagnostic conclusion is available.</description></item>
        /// <item><description>Normal: The diagnosis is normal and no issues are found.</description></item>
        /// <item><description>Info: Associated information is available, which may be related to an exception.</description></item>
        /// <item><description>Warn: Associated information is available, which may cause an exception.</description></item>
        /// <item><description>Critical: A critical exception exists.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("Severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// <para>The report status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>InProgress: The diagnosis is in progress.</description></item>
        /// <item><description>Failed: The diagnosis failed.</description></item>
        /// <item><description>Finished: The diagnosis is finished.</description></item>
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
