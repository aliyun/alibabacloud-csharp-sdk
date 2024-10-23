// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListUserBasicInfosRequest : TeaModel {
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
        /// <para>The number of entries to return. If a response is truncated because it reaches the value of <c>MaxItems</c>, the value of <c>IsTruncated</c> will be <c>true</c>.</para>
        /// <para>Valid values: 1 to 1000. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxItems")]
        [Validation(Required=false)]
        public int? MaxItems { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tag value.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListUserBasicInfosRequestTag> Tag { get; set; }
        public class ListUserBasicInfosRequestTag : TeaModel {
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
