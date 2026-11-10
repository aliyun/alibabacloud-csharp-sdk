// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeTransitRouterPolicyTablesResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If NextToken is empty, no subsequent query is required.</description></item>
        /// <item><description>If NextToken is returned, the value indicates the token for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dd20****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The policy route tables.</para>
        /// </summary>
        [NameInMap("PolicyTables")]
        [Validation(Required=false)]
        public List<DescribeTransitRouterPolicyTablesResponseBodyPolicyTables> PolicyTables { get; set; }
        public class DescribeTransitRouterPolicyTablesResponseBodyPolicyTables : TeaModel {
            /// <summary>
            /// <para>The network instance attachments associated with the policy route table.</para>
            /// </summary>
            [NameInMap("Attachments")]
            [Validation(Required=false)]
            public List<string> Attachments { get; set; }

            /// <summary>
            /// <para>The time when the policy route table was created.</para>
            /// <para>The time is displayed in the ISO 8601 standard in the YYYY-MM-DDThh:mmZ format. The time is displayed in UTC.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-10-22T07:44Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The description of the policy route table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>descriptiontest</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the policy route table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nametest</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The policy routing table instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ptbl-44m0p68spvlrqq****</para>
            /// </summary>
            [NameInMap("PolicyTableId")]
            [Validation(Required=false)]
            public string PolicyTableId { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The status of the policy route table. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Creating: The policy route table is being created.</para>
            /// </description></item>
            /// <item><description><para>Active: The policy route table is running.</para>
            /// </description></item>
            /// <item><description><para>Deleting: The policy route table is being deleted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tags added to the policy route table.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeTransitRouterPolicyTablesResponseBodyPolicyTablesTags> Tags { get; set; }
            public class DescribeTransitRouterPolicyTablesResponseBodyPolicyTablesTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tagtest</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tagtest</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The ID of the Enterprise Edition transit router.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-uf654ttymmljlvh2x****</para>
            /// </summary>
            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2BFA6822-240E-4E27-B4C8-AA400EF7474D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
