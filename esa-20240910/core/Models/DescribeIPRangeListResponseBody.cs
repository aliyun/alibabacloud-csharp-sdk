// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeIPRangeListResponseBody : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public List<DescribeIPRangeListResponseBodyContent> Content { get; set; }
        public class DescribeIPRangeListResponseBodyContent : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>172.16.0.0/12</para>
            /// </summary>
            [NameInMap("Cidr")]
            [Validation(Required=false)]
            public string Cidr { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>IPv4</para>
            /// </summary>
            [NameInMap("IpType")]
            [Validation(Required=false)]
            public string IpType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CB1A380B-09F0-41BB-A198-72F8FD6DA2FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
