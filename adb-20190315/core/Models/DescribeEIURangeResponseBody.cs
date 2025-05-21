// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeEIURangeResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried information about the number of EIUs.</para>
        /// </summary>
        [NameInMap("EIUInfo")]
        [Validation(Required=false)]
        public DescribeEIURangeResponseBodyEIUInfo EIUInfo { get; set; }
        public class DescribeEIURangeResponseBodyEIUInfo : TeaModel {
            [NameInMap("DefaultReservedNodeSize")]
            [Validation(Required=false)]
            public string DefaultReservedNodeSize { get; set; }

            /// <summary>
            /// <para>The suggested value for the number of EIUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("DefaultValue")]
            [Validation(Required=false)]
            public string DefaultValue { get; set; }

            /// <summary>
            /// <para>The queried range for the number of EIUs.</para>
            /// </summary>
            [NameInMap("EIURange")]
            [Validation(Required=false)]
            public List<long?> EIURange { get; set; }

            /// <summary>
            /// <para>A reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>none</para>
            /// </summary>
            [NameInMap("MaxValue")]
            [Validation(Required=false)]
            public string MaxValue { get; set; }

            /// <summary>
            /// <para>A reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>none</para>
            /// </summary>
            [NameInMap("MinValue")]
            [Validation(Required=false)]
            public string MinValue { get; set; }

            [NameInMap("ReservedNodeSizeRange")]
            [Validation(Required=false)]
            public List<string> ReservedNodeSizeRange { get; set; }

            /// <summary>
            /// <para>A reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>none</para>
            /// </summary>
            [NameInMap("Step")]
            [Validation(Required=false)]
            public string Step { get; set; }

            /// <summary>
            /// <para>A reserved parameter.</para>
            /// </summary>
            [NameInMap("StorageResourceRange")]
            [Validation(Required=false)]
            public List<string> StorageResourceRange { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D65A809F-34CE-4550-9BC1-0ED21ETG380</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
