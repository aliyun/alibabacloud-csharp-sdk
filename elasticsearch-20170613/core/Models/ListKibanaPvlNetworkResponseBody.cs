// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListKibanaPvlNetworkResponseBody : TeaModel {
        /// <summary>
        /// <para>request id</para>
        /// 
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6FE1D***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListKibanaPvlNetworkResponseBodyResult> Result { get; set; }
        public class ListKibanaPvlNetworkResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-03-07T06:26:28Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ep-bp1tah7zbrwmkjef****</para>
            /// </summary>
            [NameInMap("endpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>es-cn-xxdjfia****-kibana</para>
            /// </summary>
            [NameInMap("endpointName")]
            [Validation(Required=false)]
            public string EndpointName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Connected</para>
            /// </summary>
            [NameInMap("endpointStatus")]
            [Validation(Required=false)]
            public string EndpointStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>es-cn-27a3mul6l***-kibana-internal</para>
            /// </summary>
            [NameInMap("pvlId")]
            [Validation(Required=false)]
            public string PvlId { get; set; }

            [NameInMap("securityGroups")]
            [Validation(Required=false)]
            public List<string> SecurityGroups { get; set; }

            [NameInMap("vSwitchIdsZone")]
            [Validation(Required=false)]
            public List<ListKibanaPvlNetworkResponseBodyResultVSwitchIdsZone> VSwitchIdsZone { get; set; }
            public class ListKibanaPvlNetworkResponseBodyResultVSwitchIdsZone : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>vsw-xdefafns***</para>
                /// </summary>
                [NameInMap("vswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou-e</para>
                /// </summary>
                [NameInMap("zoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc-bp16k1dvzxtma*****</para>
            /// </summary>
            [NameInMap("vpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

    }

}
