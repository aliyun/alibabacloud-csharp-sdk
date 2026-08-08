// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BDRC20230808.Models
{
    public class ListCrossAccountsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCrossAccountsResponseBodyData Data { get; set; }
        public class ListCrossAccountsResponseBodyData : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<ListCrossAccountsResponseBodyDataContent> Content { get; set; }
            public class ListCrossAccountsResponseBodyDataContent : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1773738311</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MANUAL</para>
                /// </summary>
                [NameInMap("ManagementMode")]
                [Validation(Required=false)]
                public string ManagementMode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>r-***</para>
                /// </summary>
                [NameInMap("ParentTargetId")]
                [Validation(Required=false)]
                public string ParentTargetId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123***7890</para>
                /// </summary>
                [NameInMap("TargetId")]
                [Validation(Required=false)]
                public string TargetId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ACCOUNT</para>
                /// </summary>
                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>eKDyCM0zFQ5op7jVMWmNNA==</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5B2F09BF-CEBD-5A7E-AC01-E7F86169A5E5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
