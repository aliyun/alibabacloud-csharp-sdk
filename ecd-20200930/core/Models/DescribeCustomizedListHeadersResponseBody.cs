// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeCustomizedListHeadersResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of table headers.</para>
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public List<DescribeCustomizedListHeadersResponseBodyHeaders> Headers { get; set; }
        public class DescribeCustomizedListHeadersResponseBodyHeaders : TeaModel {
            /// <summary>
            /// <para>The display type of the table header. You can invoke <a href="https://help.aliyun.com/document_detail/452324.html">ModifyCustomizedListHeaders</a> to change it.</para>
            /// 
            /// <b>Example:</b>
            /// <para>display</para>
            /// </summary>
            [NameInMap("DisplayType")]
            [Validation(Required=false)]
            public string DisplayType { get; set; }

            /// <summary>
            /// <para>The key of the table header.</para>
            /// 
            /// <b>Example:</b>
            /// <para>system_data_disk</para>
            /// </summary>
            [NameInMap("HeaderKey")]
            [Validation(Required=false)]
            public string HeaderKey { get; set; }

            /// <summary>
            /// <para>The name of the table header.</para>
            /// 
            /// <b>Example:</b>
            /// <para>System disk/Data disk</para>
            /// </summary>
            [NameInMap("HeaderName")]
            [Validation(Required=false)]
            public string HeaderName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
