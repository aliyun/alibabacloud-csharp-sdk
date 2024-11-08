// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class SearchInventoryRequest : TeaModel {
        /// <summary>
        /// <para>The information about aggregators. You can use one or more aggregators to query the aggregate information of an instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ACS:Application.Name</description></item>
        /// <item><description>ACS:Application.Version</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ACS:Application.Name</para>
        /// </summary>
        [NameInMap("Aggregator")]
        [Validation(Required=false)]
        public List<string> Aggregator { get; set; }

        /// <summary>
        /// <para>The filter rules for the component.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<SearchInventoryRequestFilter> Filter { get; set; }
        public class SearchInventoryRequestFilter : TeaModel {
            /// <summary>
            /// <para>The name of the component property. Valid values of N: 1 to 5. Different components have different property names. You can call the <a href="https://api.aliyun.com/#/?product=oos%5C&version=2019-06-01%5C&api=GetInventorySchema">GetInventorySchema</a> operation to query the property names of different components. For example, the ACS:InstanceInformation component has the InstanceId property. Therefore, you can set this parameter to ACS:InstanceInformation.InstanceId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACS:InstanceInformation.InstanceId</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The comparison operator that is used to filter property values. Valid values of N: 1 to 5. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Equal</description></item>
            /// <item><description>NotEqual</description></item>
            /// <item><description>BeginWith</description></item>
            /// <item><description>LessThan</description></item>
            /// <item><description>GreaterThan</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Equal</para>
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// <para>The property values to query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp1cpoxxxxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gAAAAABfTgv5ewUWmNdJ3g7JVLvX70sPH90GZOVGC</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
