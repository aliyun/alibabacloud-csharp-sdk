// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeOutgoingTagResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>B532203E-813B-5BEB-B75B-315E1D08****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TagList")]
        [Validation(Required=false)]
        public List<DescribeOutgoingTagResponseBodyTagList> TagList { get; set; }
        public class DescribeOutgoingTagResponseBodyTagList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Trusted</para>
            /// </summary>
            [NameInMap("ClassId")]
            [Validation(Required=false)]
            public string ClassId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public int? RiskLevel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test describe</para>
            /// </summary>
            [NameInMap("TagDescribe")]
            [Validation(Required=false)]
            public string TagDescribe { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tag-6833388d18cc****</para>
            /// </summary>
            [NameInMap("TagId")]
            [Validation(Required=false)]
            public string TagId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test tag</para>
            /// </summary>
            [NameInMap("TagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
