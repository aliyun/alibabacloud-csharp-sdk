// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class DescribeServiceLinkedRoleStatusResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeServiceLinkedRoleStatusResponseBodyData Data { get; set; }
        public class DescribeServiceLinkedRoleStatusResponseBodyData : TeaModel {
            [NameInMap("Body")]
            [Validation(Required=false)]
            public DescribeServiceLinkedRoleStatusResponseBodyDataBody Body { get; set; }
            public class DescribeServiceLinkedRoleStatusResponseBodyDataBody : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>7F14E3C8-A6AA-5D3C-B7E0-ABA2AC171EFC</para>
                /// </summary>
                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                [NameInMap("RoleStatus")]
                [Validation(Required=false)]
                public DescribeServiceLinkedRoleStatusResponseBodyDataBodyRoleStatus RoleStatus { get; set; }
                public class DescribeServiceLinkedRoleStatusResponseBodyDataBodyRoleStatus : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public bool? Status { get; set; }

                }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EF972A16-95FB-5EF2-9CED-208A74DEF040</para>
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
