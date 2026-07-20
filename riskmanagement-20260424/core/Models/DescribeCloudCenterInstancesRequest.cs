// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class DescribeCloudCenterInstancesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SdkRequest")]
        [Validation(Required=false)]
        public DescribeCloudCenterInstancesRequestSdkRequest SdkRequest { get; set; }
        public class DescribeCloudCenterInstancesRequestSdkRequest : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;contactIds\&quot;:[\&quot;job-658854766790086656\&quot;,\&quot;job-658854801112113152\&quot;]}</para>
            /// </summary>
            [NameInMap("Criteria")]
            [Validation(Required=false)]
            public string Criteria { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0,10,13</para>
            /// </summary>
            [NameInMap("Flags")]
            [Validation(Required=false)]
            public string Flags { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Importance")]
            [Validation(Required=false)]
            public int? Importance { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>zh</para>
            /// </summary>
            [NameInMap("Lang")]
            [Validation(Required=false)]
            public string Lang { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AND</para>
            /// </summary>
            [NameInMap("LogicalExp")]
            [Validation(Required=false)]
            public string LogicalExp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("MachineTypes")]
            [Validation(Required=false)]
            public string MachineTypes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AAAAAZak7VOTMl2OSt/xmc4J6gbg4Z5eXuWnrvKgOsGARL76TVbKERXHXKNFurqjtfDdRw==</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NoGroupTrace")]
            [Validation(Required=false)]
            public bool? NoGroupTrace { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>99</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1587359978118481</para>
            /// </summary>
            [NameInMap("ResourceDirectoryAccountId")]
            [Validation(Required=false)]
            public string ResourceDirectoryAccountId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("UseNextToken")]
            [Validation(Required=false)]
            public bool? UseNextToken { get; set; }

        }

    }

}
