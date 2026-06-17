// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeNetworkInstanceRelationListResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the network instances.</para>
        /// </summary>
        [NameInMap("NetworkInstanceList")]
        [Validation(Required=false)]
        public List<DescribeNetworkInstanceRelationListResponseBodyNetworkInstanceList> NetworkInstanceList { get; set; }
        public class DescribeNetworkInstanceRelationListResponseBodyNetworkInstanceList : TeaModel {
            /// <summary>
            /// <para>The associated CEN instance.</para>
            /// </summary>
            [NameInMap("AssociatedCen")]
            [Validation(Required=false)]
            public List<DescribeNetworkInstanceRelationListResponseBodyNetworkInstanceListAssociatedCen> AssociatedCen { get; set; }
            public class DescribeNetworkInstanceRelationListResponseBodyNetworkInstanceListAssociatedCen : TeaModel {
                /// <summary>
                /// <para>The ID of the network instance connection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tr-attach-b92yqn***</para>
                /// </summary>
                [NameInMap("AttachmentId")]
                [Validation(Required=false)]
                public string AttachmentId { get; set; }

                /// <summary>
                /// <para>The name of the network instance connection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>att-test1</para>
                /// </summary>
                [NameInMap("AttachmentName")]
                [Validation(Required=false)]
                public string AttachmentName { get; set; }

                /// <summary>
                /// <para>The ID of the CEN instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cen-sdij1***</para>
                /// </summary>
                [NameInMap("CenId")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                /// <summary>
                /// <para>The name of the CEN instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("CenName")]
                [Validation(Required=false)]
                public string CenName { get; set; }

                /// <summary>
                /// <para>The type of the transit router. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Basic</b>: Basic Edition transit router.</para>
                /// </description></item>
                /// <item><description><para><b>Enterprise</b>: Enterprise Edition transit router.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Enterprise</para>
                /// </summary>
                [NameInMap("TransitRouterType")]
                [Validation(Required=false)]
                public string TransitRouterType { get; set; }

            }

            /// <summary>
            /// <para>The connection type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cen</para>
            /// </summary>
            [NameInMap("ConnectType")]
            [Validation(Required=false)]
            public string ConnectType { get; set; }

            /// <summary>
            /// <para>The ID of the network instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2vcwfqbrh4kr****</para>
            /// </summary>
            [NameInMap("NetworkInstanceId")]
            [Validation(Required=false)]
            public string NetworkInstanceId { get; set; }

            /// <summary>
            /// <para>The name of the network instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-test</para>
            /// </summary>
            [NameInMap("NetworkInstanceName")]
            [Validation(Required=false)]
            public string NetworkInstanceName { get; set; }

            /// <summary>
            /// <para>The type of the network instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("NetworkInstanceType")]
            [Validation(Required=false)]
            public string NetworkInstanceType { get; set; }

            /// <summary>
            /// <para>The list of peer network instances.</para>
            /// </summary>
            [NameInMap("PeerNetworkInstanceList")]
            [Validation(Required=false)]
            public List<DescribeNetworkInstanceRelationListResponseBodyNetworkInstanceListPeerNetworkInstanceList> PeerNetworkInstanceList { get; set; }
            public class DescribeNetworkInstanceRelationListResponseBodyNetworkInstanceListPeerNetworkInstanceList : TeaModel {
                /// <summary>
                /// <para>The associated CEN instance.</para>
                /// </summary>
                [NameInMap("AssociatedCen")]
                [Validation(Required=false)]
                public List<DescribeNetworkInstanceRelationListResponseBodyNetworkInstanceListPeerNetworkInstanceListAssociatedCen> AssociatedCen { get; set; }
                public class DescribeNetworkInstanceRelationListResponseBodyNetworkInstanceListPeerNetworkInstanceListAssociatedCen : TeaModel {
                    /// <summary>
                    /// <para>The ID of the network instance connection.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>tr-attach-b9dyqn***</para>
                    /// </summary>
                    [NameInMap("AttachmentId")]
                    [Validation(Required=false)]
                    public string AttachmentId { get; set; }

                    /// <summary>
                    /// <para>The name of the network instance connection.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>att-test2</para>
                    /// </summary>
                    [NameInMap("AttachmentName")]
                    [Validation(Required=false)]
                    public string AttachmentName { get; set; }

                    /// <summary>
                    /// <para>The ID of the CEN instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cen-sdij1***</para>
                    /// </summary>
                    [NameInMap("CenId")]
                    [Validation(Required=false)]
                    public string CenId { get; set; }

                    /// <summary>
                    /// <para>The name of the CEN instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("CenName")]
                    [Validation(Required=false)]
                    public string CenName { get; set; }

                    /// <summary>
                    /// <para>The version of the transit router. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>Basic</b>: Basic Edition transit router.</para>
                    /// </description></item>
                    /// <item><description><para><b>Enterprise</b>: Enterprise Edition transit router.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Enterprise</para>
                    /// </summary>
                    [NameInMap("TransitRouterType")]
                    [Validation(Required=false)]
                    public string TransitRouterType { get; set; }

                }

                /// <summary>
                /// <para>The ID of the network instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-dsf232d****</para>
                /// </summary>
                [NameInMap("NetworkInstanceId")]
                [Validation(Required=false)]
                public string NetworkInstanceId { get; set; }

                /// <summary>
                /// <para>The name of the network instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-test</para>
                /// </summary>
                [NameInMap("NetworkInstanceName")]
                [Validation(Required=false)]
                public string NetworkInstanceName { get; set; }

                /// <summary>
                /// <para>The type of the network instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc</para>
                /// </summary>
                [NameInMap("NetworkInstanceType")]
                [Validation(Required=false)]
                public string NetworkInstanceType { get; set; }

                /// <summary>
                /// <para>The region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shenzhen</para>
                /// </summary>
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

            }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>284FF89D-4F70-546F-8EF6-77E0A530****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
