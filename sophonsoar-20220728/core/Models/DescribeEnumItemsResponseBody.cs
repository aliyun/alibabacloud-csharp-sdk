// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeEnumItemsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the enumeration item.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeEnumItemsResponseBodyData> Data { get; set; }
        public class DescribeEnumItemsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The key of the enumeration item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>system_xxxxx_process_book</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the enumeration item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>system_xxxxx_process_book</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E7698CFB-4E1C-5840-8EC9-691B86729E94</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
