// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeDBInstanceEndpointResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDBInstanceEndpointResponseBodyData Data { get; set; }
        public class DescribeDBInstanceEndpointResponseBodyData : TeaModel {
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceEndpointResponseBodyDataItems> Items { get; set; }
            public class DescribeDBInstanceEndpointResponseBodyDataItems : TeaModel {
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public DescribeDBInstanceEndpointResponseBodyDataItemsEndpoint Endpoint { get; set; }
                public class DescribeDBInstanceEndpointResponseBodyDataItemsEndpoint : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10.21.1.82</para>
                    /// </summary>
                    [NameInMap("Address")]
                    [Validation(Required=false)]
                    public string Address { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>mdb.shard.4x.large.d</para>
                    /// </summary>
                    [NameInMap("Class")]
                    [Validation(Required=false)]
                    public string Class { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>epg-bp14wgzai7flglwdtkxfa</para>
                    /// </summary>
                    [NameInMap("EndpointGroupId")]
                    [Validation(Required=false)]
                    public long? EndpointGroupId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2899</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>True</para>
                    /// </summary>
                    [NameInMap("IsDefault")]
                    [Validation(Required=false)]
                    public bool? IsDefault { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>instance</para>
                    /// </summary>
                    [NameInMap("Kind")]
                    [Validation(Required=false)]
                    public string Kind { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>VPC</para>
                    /// </summary>
                    [NameInMap("NetType")]
                    [Validation(Required=false)]
                    public string NetType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ReadType")]
                    [Validation(Required=false)]
                    public string ReadType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>sas-app</para>
                    /// </summary>
                    [NameInMap("TargetName")]
                    [Validation(Required=false)]
                    public string TargetName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>3522367</para>
                    /// </summary>
                    [NameInMap("TunnelId")]
                    [Validation(Required=false)]
                    public long? TunnelId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>TXT</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("UserVisible")]
                    [Validation(Required=false)]
                    public bool? UserVisible { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>vsw-2ze51hh6s8tsjgy19g5eu</para>
                    /// </summary>
                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="http://100.100.100.200/latest/meta-data">http://100.100.100.200/latest/meta-data</a></para>
                    /// </summary>
                    [NameInMap("Vip")]
                    [Validation(Required=false)]
                    public string Vip { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>vpc-bp1s9j8s4h4uqejp9k2z3</para>
                    /// </summary>
                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>vport</para>
                    /// </summary>
                    [NameInMap("Vport")]
                    [Validation(Required=false)]
                    public long? Vport { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><c>curl uUys2ThR.popscan.xaliyun.com</c></para>
                    /// </summary>
                    [NameInMap("ZoneId")]
                    [Validation(Required=false)]
                    public string ZoneId { get; set; }

                }

                [NameInMap("RealServer")]
                [Validation(Required=false)]
                public List<DescribeDBInstanceEndpointResponseBodyDataItemsRealServer> RealServer { get; set; }
                public class DescribeDBInstanceEndpointResponseBodyDataItemsRealServer : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>False</para>
                    /// </summary>
                    [NameInMap("Activated")]
                    [Validation(Required=false)]
                    public bool? Activated { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>dds.cs.mid</para>
                    /// </summary>
                    [NameInMap("Class")]
                    [Validation(Required=false)]
                    public string Class { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>172.29.32.166</para>
                    /// </summary>
                    [NameInMap("Ip")]
                    [Validation(Required=false)]
                    public string Ip { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>3306</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public string Port { get; set; }

                    [NameInMap("ReplicaId")]
                    [Validation(Required=false)]
                    public long? ReplicaId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>255</para>
                    /// </summary>
                    [NameInMap("Weight")]
                    [Validation(Required=false)]
                    public long? Weight { get; set; }

                }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxdds</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>A501A191-BD70-5E50-98A9-C2A486A82****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
