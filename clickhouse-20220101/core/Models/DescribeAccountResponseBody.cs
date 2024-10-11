// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20220101.Models
{
    public class DescribeAccountResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAccountResponseBodyData Data { get; set; }
        public class DescribeAccountResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Account")]
            [Validation(Required=false)]
            public string Account { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cd0289a263bf4146a2e00888321178234b65e8c050142074ad05683e3749****</para>
            /// </summary>
            [NameInMap("PasswordSha256Hex")]
            [Validation(Required=false)]
            public string PasswordSha256Hex { get; set; }

            [NameInMap("PrivilegeDescription")]
            [Validation(Required=false)]
            public string PrivilegeDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Super</para>
            /// </summary>
            [NameInMap("PrivilegeType")]
            [Validation(Required=false)]
            public string PrivilegeType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>92016D5B-899D-5B77-A8A7-EFE523D4C80A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
