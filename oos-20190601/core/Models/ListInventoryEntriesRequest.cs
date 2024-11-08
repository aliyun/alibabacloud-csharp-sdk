// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListInventoryEntriesRequest : TeaModel {
        /// <summary>
        /// <para>The filter rules for the component.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<ListInventoryEntriesRequestFilter> Filter { get; set; }
        public class ListInventoryEntriesRequestFilter : TeaModel {
            /// <summary>
            /// <para>The name of the component property. Valid values of N: 1 to 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PlatformName</para>
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
            /// <para>The values of properties. Valid values of the first N: 1 to 5. Valid values of the second N: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1cpoxxxwxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

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
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTRBMDc0NjAtRUJFNy00N0NBLTk3NTctMTJDQzA</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the component. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ACS:InstanceInformation</description></item>
        /// <item><description>ACS:Application</description></item>
        /// <item><description>ACS:File</description></item>
        /// <item><description>ACS:Network</description></item>
        /// <item><description>ACS:WindowsRole</description></item>
        /// <item><description>ACS:Service</description></item>
        /// <item><description>ACS:WindowsRegistry</description></item>
        /// <item><description>ACS:WindowsUpdate</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACS:InstanceInformation</para>
        /// </summary>
        [NameInMap("TypeName")]
        [Validation(Required=false)]
        public string TypeName { get; set; }

    }

}
