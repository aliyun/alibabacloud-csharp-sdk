// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeNetworkInstanceRelationListResponseBody : TeaModel {
        [NameInMap("NetworkInstanceList")]
        [Validation(Required=false)]
        public List<DescribeNetworkInstanceRelationListResponseBodyNetworkInstanceList> NetworkInstanceList { get; set; }
        public class DescribeNetworkInstanceRelationListResponseBodyNetworkInstanceList : TeaModel {
            [NameInMap("AssociatedCen")]
            [Validation(Required=false)]
            public List<DescribeNetworkInstanceRelationListResponseBodyNetworkInstanceListAssociatedCen> AssociatedCen { get; set; }
            public class DescribeNetworkInstanceRelationListResponseBodyNetworkInstanceListAssociatedCen : TeaModel {
                [NameInMap("AttachmentId")]
                [Validation(Required=false)]
                public string AttachmentId { get; set; }

                [NameInMap("AttachmentName")]
                [Validation(Required=false)]
                public string AttachmentName { get; set; }

                [NameInMap("CenId")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                [NameInMap("CenName")]
                [Validation(Required=false)]
                public string CenName { get; set; }

                [NameInMap("TransitRouterType")]
                [Validation(Required=false)]
                public string TransitRouterType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cen</para>
            /// </summary>
            [NameInMap("ConnectType")]
            [Validation(Required=false)]
            public string ConnectType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc-2vcwfqbrh4kr****</para>
            /// </summary>
            [NameInMap("NetworkInstanceId")]
            [Validation(Required=false)]
            public string NetworkInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc-test</para>
            /// </summary>
            [NameInMap("NetworkInstanceName")]
            [Validation(Required=false)]
            public string NetworkInstanceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("NetworkInstanceType")]
            [Validation(Required=false)]
            public string NetworkInstanceType { get; set; }

            [NameInMap("PeerNetworkInstanceList")]
            [Validation(Required=false)]
            public List<DescribeNetworkInstanceRelationListResponseBodyNetworkInstanceListPeerNetworkInstanceList> PeerNetworkInstanceList { get; set; }
            public class DescribeNetworkInstanceRelationListResponseBodyNetworkInstanceListPeerNetworkInstanceList : TeaModel {
                [NameInMap("AssociatedCen")]
                [Validation(Required=false)]
                public List<DescribeNetworkInstanceRelationListResponseBodyNetworkInstanceListPeerNetworkInstanceListAssociatedCen> AssociatedCen { get; set; }
                public class DescribeNetworkInstanceRelationListResponseBodyNetworkInstanceListPeerNetworkInstanceListAssociatedCen : TeaModel {
                    [NameInMap("AttachmentId")]
                    [Validation(Required=false)]
                    public string AttachmentId { get; set; }

                    [NameInMap("AttachmentName")]
                    [Validation(Required=false)]
                    public string AttachmentName { get; set; }

                    [NameInMap("CenId")]
                    [Validation(Required=false)]
                    public string CenId { get; set; }

                    [NameInMap("CenName")]
                    [Validation(Required=false)]
                    public string CenName { get; set; }

                    [NameInMap("TransitRouterType")]
                    [Validation(Required=false)]
                    public string TransitRouterType { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vpc-dsf232d****</para>
                /// </summary>
                [NameInMap("NetworkInstanceId")]
                [Validation(Required=false)]
                public string NetworkInstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vpc-test</para>
                /// </summary>
                [NameInMap("NetworkInstanceName")]
                [Validation(Required=false)]
                public string NetworkInstanceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vpc</para>
                /// </summary>
                [NameInMap("NetworkInstanceType")]
                [Validation(Required=false)]
                public string NetworkInstanceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-shenzhen</para>
                /// </summary>
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>284FF89D-4F70-546F-8EF6-77E0A530****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
