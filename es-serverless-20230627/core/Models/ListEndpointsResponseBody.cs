// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Es_serverless20230627.Models
{
    public class ListEndpointsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>D6030CE6-9FEB-5B2F-84AC-3ADE3CBA89E5</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListEndpointsResponseBodyResult> Result { get; set; }
        public class ListEndpointsResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Pending</para>
            /// </summary>
            [NameInMap("connectionStatus")]
            [Validation(Required=false)]
            public string ConnectionStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1701259721</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public int? Created { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ep-bp1i522d<b><b>a3.epsrv-bp1f</b></b>gei.cn-hangzhou.privatelink.aliyuncs.com</para>
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>essep-2f46b743f60****</para>
            /// </summary>
            [NameInMap("endpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            [NameInMap("endpointZones")]
            [Validation(Required=false)]
            public List<ListEndpointsResponseBodyResultEndpointZones> EndpointZones { get; set; }
            public class ListEndpointsResponseBodyResultEndpointZones : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>vsw-bp194pz9iez****</para>
                /// </summary>
                [NameInMap("vSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou-k</para>
                /// </summary>
                [NameInMap("zoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ep-bp1id41dd116e52e****</para>
            /// </summary>
            [NameInMap("resourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("securityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1701259721</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public int? Updated { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc-uf6gykvwcirp886ef****</para>
            /// </summary>
            [NameInMap("vpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
