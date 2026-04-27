// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class DescribeUserResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("User")]
        [Validation(Required=false)]
        public DescribeUserResponseBodyUser User { get; set; }
        public class DescribeUserResponseBodyUser : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:alex@test-email.com">alex@test-email.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>alex</para>
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            [NameInMap("ExternalInfo")]
            [Validation(Required=false)]
            public DescribeUserResponseBodyUserExternalInfo ExternalInfo { get; set; }
            public class DescribeUserResponseBodyUserExternalInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>oijjnabsf****</para>
                /// </summary>
                [NameInMap("ExternalId")]
                [Validation(Required=false)]
                public string ExternalId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Alex</para>
                /// </summary>
                [NameInMap("ExternalName")]
                [Validation(Required=false)]
                public string ExternalName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>15412***</para>
                /// </summary>
                [NameInMap("JobNumber")]
                [Validation(Required=false)]
                public string JobNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>OIDC</para>
                /// </summary>
                [NameInMap("SsoType")]
                [Validation(Required=false)]
                public string SsoType { get; set; }

            }

            [NameInMap("Extras")]
            [Validation(Required=false)]
            public Dictionary<string, string> Extras { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-01-01 12:00:00</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("OrgIds")]
            [Validation(Required=false)]
            public List<string> OrgIds { get; set; }

            [NameInMap("OrgPaths")]
            [Validation(Required=false)]
            public List<string> OrgPaths { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1888888****</para>
            /// </summary>
            [NameInMap("Phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            [NameInMap("Properties")]
            [Validation(Required=false)]
            public List<DescribeUserResponseBodyUserProperties> Properties { get; set; }
            public class DescribeUserResponseBodyUserProperties : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>role</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>teacher</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>remark</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>aisdfumj****</para>
            /// </summary>
            [NameInMap("WyId")]
            [Validation(Required=false)]
            public string WyId { get; set; }

        }

    }

}
