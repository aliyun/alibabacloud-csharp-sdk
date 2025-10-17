// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterEndpointsZonalResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDBClusterEndpointsZonalResponseBodyItems> Items { get; set; }
        public class DescribeDBClusterEndpointsZonalResponseBodyItems : TeaModel {
            [NameInMap("AddressItems")]
            [Validation(Required=false)]
            public List<DescribeDBClusterEndpointsZonalResponseBodyItemsAddressItems> AddressItems { get; set; }
            public class DescribeDBClusterEndpointsZonalResponseBodyItemsAddressItems : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>********.rwlb.polardb-pg-public.rds.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("DashboardUsed")]
                [Validation(Required=false)]
                public bool? DashboardUsed { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>192.<em><b>.</b></em>.***</para>
                /// </summary>
                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Private</para>
                /// </summary>
                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1521</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><em><b>.</b></em>.**.com</para>
                /// </summary>
                [NameInMap("PrivateZoneConnectionString")]
                [Validation(Required=false)]
                public string PrivateZoneConnectionString { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vpc-***************</para>
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vsw-************</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pe-*************</para>
                /// </summary>
                [NameInMap("VpcInstanceId")]
                [Validation(Required=false)]
                public string VpcInstanceId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("AutoAddNewNodes")]
            [Validation(Required=false)]
            public string AutoAddNewNodes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pc-bp1s826a1up******</para>
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("DBEndpointDescription")]
            [Validation(Required=false)]
            public string DBEndpointDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pe-*************</para>
            /// </summary>
            [NameInMap("DBEndpointId")]
            [Validation(Required=false)]
            public string DBEndpointId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;DistributedTransaction\&quot;:\&quot;off\&quot;,\&quot;ConsistLevel\&quot;:\&quot;0\&quot;,\&quot;LoadBalanceStrategy\&quot;:\&quot;load\&quot;,\&quot;MasterAcceptReads\&quot;:\&quot;on\&quot;}</para>
            /// </summary>
            [NameInMap("EndpointConfig")]
            [Validation(Required=false)]
            public string EndpointConfig { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Custom</para>
            /// </summary>
            [NameInMap("EndpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Reader1</para>
            /// </summary>
            [NameInMap("NodeWithRoles")]
            [Validation(Required=false)]
            public string NodeWithRoles { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pi-<em><b><b><b><b><b><b><b>,pi-</b></b></b></b></b></b></b></em></para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public string Nodes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PolarSccTimeoutAction")]
            [Validation(Required=false)]
            public string PolarSccTimeoutAction { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("PolarSccWaitTimeout")]
            [Validation(Required=false)]
            public string PolarSccWaitTimeout { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ReadOnly</para>
            /// </summary>
            [NameInMap("ReadWriteMode")]
            [Validation(Required=false)]
            public string ReadWriteMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("SccMode")]
            [Validation(Required=false)]
            public string SccMode { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2DC120BF-6EBA-4C63-BE99-B09F9E******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
