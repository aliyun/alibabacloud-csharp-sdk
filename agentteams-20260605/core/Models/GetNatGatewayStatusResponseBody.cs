// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class GetNatGatewayStatusResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetNatGatewayStatusResponseBodyData Data { get; set; }
        public class GetNatGatewayStatusResponseBodyData : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("NatGatewayConfigured")]
            [Validation(Required=false)]
            public bool? NatGatewayConfigured { get; set; }

            [NameInMap("NatGateways")]
            [Validation(Required=false)]
            public List<GetNatGatewayStatusResponseBodyDataNatGateways> NatGateways { get; set; }
            public class GetNatGatewayStatusResponseBodyDataNatGateways : TeaModel {
                [NameInMap("NatGatewayId")]
                [Validation(Required=false)]
                public string NatGatewayId { get; set; }

                [NameInMap("SnatConfigured")]
                [Validation(Required=false)]
                public bool? SnatConfigured { get; set; }

                [NameInMap("SnatTableId")]
                [Validation(Required=false)]
                public string SnatTableId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("SnatConfigured")]
            [Validation(Required=false)]
            public bool? SnatConfigured { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("ZoneCidrCovered")]
            [Validation(Required=false)]
            public bool? ZoneCidrCovered { get; set; }

            [NameInMap("ZoneCidrs")]
            [Validation(Required=false)]
            public List<GetNatGatewayStatusResponseBodyDataZoneCidrs> ZoneCidrs { get; set; }
            public class GetNatGatewayStatusResponseBodyDataZoneCidrs : TeaModel {
                [NameInMap("CidrBlock")]
                [Validation(Required=false)]
                public string CidrBlock { get; set; }

                [NameInMap("Covered")]
                [Validation(Required=false)]
                public bool? Covered { get; set; }

                [NameInMap("NatGatewayId")]
                [Validation(Required=false)]
                public string NatGatewayId { get; set; }

                [NameInMap("SnatEntryId")]
                [Validation(Required=false)]
                public string SnatEntryId { get; set; }

                [NameInMap("SnatSourceCidr")]
                [Validation(Required=false)]
                public string SnatSourceCidr { get; set; }

                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>req-xxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
