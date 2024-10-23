// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListUsersRequest : TeaModel {
        /// <summary>
        /// <para>The <c>marker</c>. If part of a previous response is truncated, you can use this parameter to obtain the truncated part.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EXAMPLE</para>
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <para>The number of entries per page. If a response is truncated because it reaches the value of <c>MaxItems</c>, the value of <c>IsTruncated</c> will be true.</para>
        /// <para>Valid values: 1 to 1000. Default value: 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MaxItems")]
        [Validation(Required=false)]
        public int? MaxItems { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags. A maximum number of 20 tags are supported.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListUsersRequestTag> Tag { get; set; }
        public class ListUsersRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N.</para>
            /// <para>Valid values of N: 1 to 20. N must be consecutive.</para>
            /// 
            /// <b>Example:</b>
            /// <para>operator</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N.</para>
            /// <para>Valid values of N: 1 to 20. N must be consecutive.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alice</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
