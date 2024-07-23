// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeGadInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the global active database cluster.</para>
        /// </summary>
        [NameInMap("GadInstances")]
        [Validation(Required=false)]
        public List<DescribeGadInstancesResponseBodyGadInstances> GadInstances { get; set; }
        public class DescribeGadInstancesResponseBodyGadInstances : TeaModel {
            /// <summary>
            /// <para>The time when the global active database cluster was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-10-21T02:57:08Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The name of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GadTest</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The information about each node in the cluster.</para>
            /// </summary>
            [NameInMap("GadInstanceMembers")]
            [Validation(Required=false)]
            public List<DescribeGadInstancesResponseBodyGadInstancesGadInstanceMembers> GadInstanceMembers { get; set; }
            public class DescribeGadInstancesResponseBodyGadInstancesGadInstanceMembers : TeaModel {
                /// <summary>
                /// <para>The ID of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-bp1npi2j8********</para>
                /// </summary>
                [NameInMap("DBInstanceID")]
                [Validation(Required=false)]
                public string DBInstanceID { get; set; }

                /// <summary>
                /// <para>A JSON array that consists of the details about the Data Transmission Service (DTS) synchronization task.</para>
                /// <remarks>
                /// <para> Each unit node (secondary node) synchronizes data from the central node (primary node) by using DTS. This parameter contains the synchronization link ID and request ID of DTS.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;dtsInstanceId\&quot;:\&quot;dtsm9t107c********\&quot;,\&quot;dtsRequestId\&quot;:\&quot;190F0C6C-4BE6-5676-989B-DBDE6D34CD9C\&quot;}</para>
                /// </summary>
                [NameInMap("DtsInstance")]
                [Validation(Required=false)]
                public string DtsInstance { get; set; }

                /// <summary>
                /// <para>The database engine that is run by the node.</para>
                /// <remarks>
                /// <para> The value of this parameter is fixed as <b>mysql</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>mysql</para>
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// <para>The database engine version that is run by the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8.0</para>
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// <para>The ID of the region where the node resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The resource group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmy*****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The type of the node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>CENTRAL</b>: The node is a central node. Each global active database cluster has only one central node. All unit nodes synchronize data from the central node.</description></item>
                /// <item><description><b>UNIT</b>: The node is a unit node. Each global active database cluster can have up to 10 unit nodes. All unit nodes synchronize data from the central node.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CENTRAL</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <para>The node status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>activation</b>: The node is running.</description></item>
                /// <item><description><b>creating</b>: The node is being created.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>activation</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The ID of the global active database cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gad-rm-bp1npi2j8********</para>
            /// </summary>
            [NameInMap("GadInstanceName")]
            [Validation(Required=false)]
            public string GadInstanceName { get; set; }

            /// <summary>
            /// <para>The time when the most recent modification was made to the global active database cluster. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-10-21T03:01:20Z</para>
            /// </summary>
            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }

            /// <summary>
            /// <para>The database engine that is run by the global active database cluster.</para>
            /// <remarks>
            /// <para> The value of this parameter is fixed as <b>mysql</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>mysql</para>
            /// </summary>
            [NameInMap("Service")]
            [Validation(Required=false)]
            public string Service { get; set; }

            /// <summary>
            /// <para>The status of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>activation</b>: The cluster is running.</description></item>
            /// <item><description><b>creating</b>: The cluster is being created.</description></item>
            /// <item><description><b>replica_adding</b>: Nodes are being added to the cluster.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>activation</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>76AF0609-4195-5DFC-BC78-3AD76FF872BB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
