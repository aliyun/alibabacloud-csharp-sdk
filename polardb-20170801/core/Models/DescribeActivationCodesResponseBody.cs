// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeActivationCodesResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeActivationCodesResponseBodyItems> Items { get; set; }
        public class DescribeActivationCodesResponseBodyItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-10-16 16:46:20</para>
            /// </summary>
            [NameInMap("ActivateAt")]
            [Validation(Required=false)]
            public string ActivateAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testCode</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2054-10-16 16:46:20</para>
            /// </summary>
            [NameInMap("ExpireAt")]
            [Validation(Required=false)]
            public string ExpireAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-10-16 16:46:20</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-10-16 16:46:20</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12:34:56:78:98:00</para>
            /// </summary>
            [NameInMap("MacAddress")]
            [Validation(Required=false)]
            public string MacAddress { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testName</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234567890123456</para>
            /// </summary>
            [NameInMap("SystemIdentifier")]
            [Validation(Required=false)]
            public string SystemIdentifier { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>65D7ACE6-4A61-4B6E-B357-8CB24A******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
