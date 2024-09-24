// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeContainerGroupedFieldDetailRequest : TeaModel {
        /// <summary>
        /// <para>The search conditions that are used to query assets. The value of this parameter is in the JSON format. Separate multiple search conditions with commas (,). Example: <c>[{&quot;name&quot;:&quot;riskStatus&quot;,&quot;value&quot;:&quot;YES&quot;},{&quot;name&quot;:&quot;riskLevel&quot;,&quot;value&quot;:&quot;2&quot;}]</c>.</para>
        /// <remarks>
        /// <para> Supported search conditions include the instance ID, instance name, virtual private cloud (VPC) ID, region, and public IP address. You can call the <a href="~~DescribeCriteria~~">DescribeCriteria</a> operation to query the supported search conditions.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;name\&quot;:\&quot;clusterId\&quot;,\&quot;value\&quot;:\&quot;cfd26658431084c73a48dd97328ba8acf\&quot;}]</para>
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// <para>The filter condition for a grouping and aggregation query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>pod</b></description></item>
        /// <item><description><b>appName</b></description></item>
        /// <item><description><b>clusterId</b></description></item>
        /// <item><description><b>namespace</b></description></item>
        /// <item><description><b>image</b></description></item>
        /// <item><description><b>containerScan</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pod</para>
        /// </summary>
        [NameInMap("GroupField")]
        [Validation(Required=false)]
        public string GroupField { get; set; }

    }

}
