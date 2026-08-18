// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class DescribeCloudCenterInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the region in which the instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The Security Center SDK request.</para>
        /// </summary>
        [NameInMap("SdkRequest")]
        [Validation(Required=false)]
        public DescribeCloudCenterInstancesRequestSdkRequest SdkRequest { get; set; }
        public class DescribeCloudCenterInstancesRequestSdkRequest : TeaModel {
            /// <summary>
            /// <para>The search conditions for assets. This parameter is in JSON format. Note that the parameter names are case-sensitive.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;contactIds\&quot;:[\&quot;job-658854766790086656\&quot;,\&quot;job-658854801112113152\&quot;]}</para>
            /// </summary>
            [NameInMap("Criteria")]
            [Validation(Required=false)]
            public string Criteria { get; set; }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The asset vendor. Separate multiple asset vendors with commas (,). Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>0,10,13</para>
            /// </summary>
            [NameInMap("Flags")]
            [Validation(Required=false)]
            public string Flags { get; set; }

            /// <summary>
            /// <para>The importance level of the asset. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Importance")]
            [Validation(Required=false)]
            public int? Importance { get; set; }

            /// <summary>
            /// <para>The language of the response. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>zh</para>
            /// </summary>
            [NameInMap("Lang")]
            [Validation(Required=false)]
            public string Lang { get; set; }

            /// <summary>
            /// <para>The logical relationship between multiple search conditions. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>AND</para>
            /// </summary>
            [NameInMap("LogicalExp")]
            [Validation(Required=false)]
            public string LogicalExp { get; set; }

            /// <summary>
            /// <para>The type of asset to query. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("MachineTypes")]
            [Validation(Required=false)]
            public string MachineTypes { get; set; }

            /// <summary>
            /// <para>The pagination token used to retrieve the next page of results. If no more results are available, this field is not returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AAAAAZak7VOTMl2OSt/xmc4J6gbg4Z5eXuWnrvKgOsGARL76TVbKERXHXKNFurqjtfDdRw==</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>Specifies whether to internationalize the default group name <b>Ungrouped</b>. Default value: <b>false</b>. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NoGroupTrace")]
            [Validation(Required=false)]
            public bool? NoGroupTrace { get; set; }

            /// <summary>
            /// <para>The number of assets to display per page in a paged query. Default value: 20, which indicates that 20 asset records are displayed per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>99</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            /// <summary>
            /// <para>The ID of the member accounts in the resource folder.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1587359978118481</para>
            /// </summary>
            [NameInMap("ResourceDirectoryAccountId")]
            [Validation(Required=false)]
            public string ResourceDirectoryAccountId { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the NextToken method to retrieve the vulnerability list data. If this parameter is used, TotalCount is no longer returned. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("UseNextToken")]
            [Validation(Required=false)]
            public bool? UseNextToken { get; set; }

        }

    }

}
