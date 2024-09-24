// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyUsageNewestResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ItemCount")]
        [Validation(Required=false)]
        public int? ItemCount { get; set; }

        [NameInMap("NewestStatisticItems")]
        [Validation(Required=false)]
        public List<DescribePropertyUsageNewestResponseBodyNewestStatisticItems> NewestStatisticItems { get; set; }
        public class DescribePropertyUsageNewestResponseBodyNewestStatisticItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1566178646000</para>
            /// </summary>
            [NameInMap("Create")]
            [Validation(Required=false)]
            public long? Create { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>root</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
