// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribePhysicalConnectionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: <b>10</b>. Valid values: <b>1</b> to <b>50</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PhysicalConnectionSet")]
        [Validation(Required=false)]
        public DescribePhysicalConnectionsResponseBodyPhysicalConnectionSet PhysicalConnectionSet { get; set; }
        public class DescribePhysicalConnectionsResponseBodyPhysicalConnectionSet : TeaModel {
            [NameInMap("PhysicalConnectionType")]
            [Validation(Required=false)]
            public List<DescribePhysicalConnectionsResponseBodyPhysicalConnectionSetPhysicalConnectionType> PhysicalConnectionType { get; set; }
            public class DescribePhysicalConnectionsResponseBodyPhysicalConnectionSetPhysicalConnectionType : TeaModel {
                [NameInMap("AccessPointId")]
                [Validation(Required=false)]
                public string AccessPointId { get; set; }

                [NameInMap("AccessPointType")]
                [Validation(Required=false)]
                public string AccessPointType { get; set; }

                [NameInMap("AdDetailLocation")]
                [Validation(Required=false)]
                public string AdDetailLocation { get; set; }

                [NameInMap("AdLocation")]
                [Validation(Required=false)]
                public string AdLocation { get; set; }

                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public long? Bandwidth { get; set; }

                [NameInMap("BusinessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                [NameInMap("CircuitCode")]
                [Validation(Required=false)]
                public string CircuitCode { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EnabledTime")]
                [Validation(Required=false)]
                public string EnabledTime { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("ExpectSpec")]
                [Validation(Required=false)]
                public string ExpectSpec { get; set; }

                [NameInMap("HasReservationData")]
                [Validation(Required=false)]
                public string HasReservationData { get; set; }

                [NameInMap("LineOperator")]
                [Validation(Required=false)]
                public string LineOperator { get; set; }

                [NameInMap("LoaStatus")]
                [Validation(Required=false)]
                public string LoaStatus { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("OpticalModuleModel")]
                [Validation(Required=false)]
                public string OpticalModuleModel { get; set; }

                [NameInMap("OrderMode")]
                [Validation(Required=false)]
                public string OrderMode { get; set; }

                [NameInMap("ParentPhysicalConnectionAliUid")]
                [Validation(Required=false)]
                public long? ParentPhysicalConnectionAliUid { get; set; }

                [NameInMap("ParentPhysicalConnectionId")]
                [Validation(Required=false)]
                public string ParentPhysicalConnectionId { get; set; }

                [NameInMap("PeerLocation")]
                [Validation(Required=false)]
                public string PeerLocation { get; set; }

                [NameInMap("PhysicalConnectionId")]
                [Validation(Required=false)]
                public string PhysicalConnectionId { get; set; }

                [NameInMap("PortNumber")]
                [Validation(Required=false)]
                public string PortNumber { get; set; }

                [NameInMap("PortType")]
                [Validation(Required=false)]
                public string PortType { get; set; }

                [NameInMap("ProductType")]
                [Validation(Required=false)]
                public string ProductType { get; set; }

                [NameInMap("QosId")]
                [Validation(Required=false)]
                public string QosId { get; set; }

                [NameInMap("RedundantPhysicalConnectionId")]
                [Validation(Required=false)]
                public string RedundantPhysicalConnectionId { get; set; }

                [NameInMap("ReservationActiveTime")]
                [Validation(Required=false)]
                public string ReservationActiveTime { get; set; }

                [NameInMap("ReservationInternetChargeType")]
                [Validation(Required=false)]
                public string ReservationInternetChargeType { get; set; }

                [NameInMap("ReservationOrderType")]
                [Validation(Required=false)]
                public string ReservationOrderType { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribePhysicalConnectionsResponseBodyPhysicalConnectionSetPhysicalConnectionTypeTags Tags { get; set; }
                public class DescribePhysicalConnectionsResponseBodyPhysicalConnectionSetPhysicalConnectionTypeTags : TeaModel {
                    [NameInMap("tags")]
                    [Validation(Required=false)]
                    public List<DescribePhysicalConnectionsResponseBodyPhysicalConnectionSetPhysicalConnectionTypeTagsTags> Tags { get; set; }
                    public class DescribePhysicalConnectionsResponseBodyPhysicalConnectionSetPhysicalConnectionTypeTagsTags : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("VirtualPhysicalConnectionCount")]
                [Validation(Required=false)]
                public int? VirtualPhysicalConnectionCount { get; set; }

                [NameInMap("VlanId")]
                [Validation(Required=false)]
                public string VlanId { get; set; }

                [NameInMap("VpconnStatus")]
                [Validation(Required=false)]
                public string VpconnStatus { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0E6D0EC4-7C91-53E2-9F65-64BF713114B0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
