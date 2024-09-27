// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDiagnosticMetricSetsRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries to return on each page. Maximum value: 100.</para>
        /// <para>Default value:</para>
        /// <list type="bullet">
        /// <item><description>If this parameter is left empty, the default value is 10.</description></item>
        /// <item><description>If this parameter is set to a value greater than 100, the default value is 100.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The ID of diagnostic metric set N.</para>
        /// </summary>
        [NameInMap("MetricSetIds")]
        [Validation(Required=false)]
        public List<string> MetricSetIds { get; set; }

        /// <summary>
        /// <para>The query token. Set the value to the <c>NextToken</c> value returned in the last call to the DescribeDiagnosticMetricSets operation. Leave this parameter empty the first time you call this operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID of the diagnostic metric set. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource type supported by the diagnostic metric set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The type of the diagnostic metric set. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>User: user-defined diagnostic metric set</description></item>
        /// <item><description>Common: common diagnostic metric set</description></item>
        /// </list>
        /// <para>Default value: user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>User</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
