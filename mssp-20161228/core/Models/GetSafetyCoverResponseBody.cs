// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mssp20161228.Models
{
    public class GetSafetyCoverResponseBody : TeaModel {
        /// <summary>
        /// <para>API return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>404</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Data query result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSafetyCoverResponseBodyData Data { get; set; }
        public class GetSafetyCoverResponseBodyData : TeaModel {
            /// <summary>
            /// <para>CFW protection coverage.</para>
            /// </summary>
            [NameInMap("CfwProtection")]
            [Validation(Required=false)]
            public GetSafetyCoverResponseBodyDataCfwProtection CfwProtection { get; set; }
            public class GetSafetyCoverResponseBodyDataCfwProtection : TeaModel {
                /// <summary>
                /// <para>Number of unprotected items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("NoProtectionCount")]
                [Validation(Required=false)]
                public long? NoProtectionCount { get; set; }

                /// <summary>
                /// <para>Number of protected items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("ProtectionCount")]
                [Validation(Required=false)]
                public long? ProtectionCount { get; set; }

                /// <summary>
                /// <para>Year-over-year protection rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>35.00</para>
                /// </summary>
                [NameInMap("ProtectionGrowthRate")]
                [Validation(Required=false)]
                public string ProtectionGrowthRate { get; set; }

                /// <summary>
                /// <para>Protection rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50.00</para>
                /// </summary>
                [NameInMap("ProtectionRate")]
                [Validation(Required=false)]
                public string ProtectionRate { get; set; }

                /// <summary>
                /// <para>Total quantity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            /// <summary>
            /// <para>ECS protection coverage.</para>
            /// </summary>
            [NameInMap("EcsProtection")]
            [Validation(Required=false)]
            public GetSafetyCoverResponseBodyDataEcsProtection EcsProtection { get; set; }
            public class GetSafetyCoverResponseBodyDataEcsProtection : TeaModel {
                /// <summary>
                /// <para>Number of unprotected items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("NoProtectionCount")]
                [Validation(Required=false)]
                public long? NoProtectionCount { get; set; }

                /// <summary>
                /// <para>Number of protected items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("ProtectionCount")]
                [Validation(Required=false)]
                public long? ProtectionCount { get; set; }

                /// <summary>
                /// <para>Year-over-year growth in protection rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>35.00</para>
                /// </summary>
                [NameInMap("ProtectionGrowthRate")]
                [Validation(Required=false)]
                public string ProtectionGrowthRate { get; set; }

                /// <summary>
                /// <para>Protection rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50.00</para>
                /// </summary>
                [NameInMap("ProtectionRate")]
                [Validation(Required=false)]
                public string ProtectionRate { get; set; }

                /// <summary>
                /// <para>Total number of items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            /// <summary>
            /// <para>WAF protection coverage.</para>
            /// </summary>
            [NameInMap("WafProtection")]
            [Validation(Required=false)]
            public GetSafetyCoverResponseBodyDataWafProtection WafProtection { get; set; }
            public class GetSafetyCoverResponseBodyDataWafProtection : TeaModel {
                /// <summary>
                /// <para>Number of unprotected items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("NoProtectionCount")]
                [Validation(Required=false)]
                public long? NoProtectionCount { get; set; }

                /// <summary>
                /// <para>Number of protected items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("ProtectionCount")]
                [Validation(Required=false)]
                public long? ProtectionCount { get; set; }

                /// <summary>
                /// <para>Year-over-year growth in protection rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>35.00</para>
                /// </summary>
                [NameInMap("ProtectionGrowthRate")]
                [Validation(Required=false)]
                public string ProtectionGrowthRate { get; set; }

                /// <summary>
                /// <para>Protection rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50.00</para>
                /// </summary>
                [NameInMap("ProtectionRate")]
                [Validation(Required=false)]
                public string ProtectionRate { get; set; }

                /// <summary>
                /// <para>Total number of items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

        }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Message of the response result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>system error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>564f8bb9-df3c-42a0-877a-b35d48f66603</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether the call was successful:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Call succeeded.</description></item>
        /// <item><description><b>false</b>: Call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
