// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeContainerGroupedFieldDetailRequest : TeaModel {
        /// <summary>
        /// <para>The conditions for searching assets. This parameter is in JSON format. Separate multiple conditions with commas (,). Example: <c>[{&quot;name&quot;:&quot;riskStatus&quot;,&quot;value&quot;:&quot;YES&quot;},{&quot;name&quot;:&quot;riskLevel&quot;,&quot;value&quot;:&quot;2&quot;}]</c>.</para>
        /// <remarks>
        /// <para>You can search for assets by conditions such as instance ID, instance name, VPC ID, region, and public IP address. Call <a href="~~DescribeCriteria~~">DescribeCriteria</a> to query the supported search conditions.</para>
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
        /// <para>The search item. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>pod</b>: pod.</description></item>
        /// <item><description><b>appName</b>: application name.</description></item>
        /// <item><description><b>clusterId</b>: cluster ID.</description></item>
        /// <item><description><b>namespace</b>: namespace.</description></item>
        /// <item><description><b>image</b>: image.</description></item>
        /// <item><description><b>containerScan</b>: container scan.</description></item>
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
