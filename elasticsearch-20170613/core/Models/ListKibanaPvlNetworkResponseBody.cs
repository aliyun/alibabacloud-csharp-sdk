// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListKibanaPvlNetworkResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6FE1D***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The array of result objects.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListKibanaPvlNetworkResponseBodyResult> Result { get; set; }
        public class ListKibanaPvlNetworkResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The time when the Kibana private network connection was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-07T06:26:28Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The endpoint ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ep-bp1tah7zbrwmkjef****</para>
            /// </summary>
            [NameInMap("endpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            /// <summary>
            /// <para>The endpoint name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>es-cn-xxdjfia****-kibana</para>
            /// </summary>
            [NameInMap("endpointName")]
            [Validation(Required=false)]
            public string EndpointName { get; set; }

            /// <summary>
            /// <para>The endpoint status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Disconnected: not connected.</para>
            /// </description></item>
            /// <item><description><para>Connected: connected.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Connected</para>
            /// </summary>
            [NameInMap("endpointStatus")]
            [Validation(Required=false)]
            public string EndpointStatus { get; set; }

            /// <summary>
            /// <para>The Kibana private network connection ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>es-cn-27a3mul6l***-kibana-internal</para>
            /// </summary>
            [NameInMap("pvlId")]
            [Validation(Required=false)]
            public string PvlId { get; set; }

            /// <summary>
            /// <para>The list of security groups.</para>
            /// </summary>
            [NameInMap("securityGroups")]
            [Validation(Required=false)]
            public List<string> SecurityGroups { get; set; }

            /// <summary>
            /// <para>The vSwitch and zone information.</para>
            /// </summary>
            [NameInMap("vSwitchIdsZone")]
            [Validation(Required=false)]
            public List<ListKibanaPvlNetworkResponseBodyResultVSwitchIdsZone> VSwitchIdsZone { get; set; }
            public class ListKibanaPvlNetworkResponseBodyResultVSwitchIdsZone : TeaModel {
                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-xdefafns***</para>
                /// </summary>
                [NameInMap("vswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

                /// <summary>
                /// <para>The zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-e</para>
                /// </summary>
                [NameInMap("zoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp16k1dvzxtma*****</para>
            /// </summary>
            [NameInMap("vpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

    }

}
