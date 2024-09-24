// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyUsageTopResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of fingerprints.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ItemCount")]
        [Validation(Required=false)]
        public int? ItemCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16AA5B62-A3C1-520B-B289-4BD971CC17AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The statistical results.</para>
        /// </summary>
        [NameInMap("TopStatisticItems")]
        [Validation(Required=false)]
        public List<DescribePropertyUsageTopResponseBodyTopStatisticItems> TopStatisticItems { get; set; }
        public class DescribePropertyUsageTopResponseBodyTopStatisticItems : TeaModel {
            /// <summary>
            /// <para>The quantity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The statistical item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>openssl</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The type of the asset fingerprint. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><b>port</b>: port</description></item>
        /// <item><description><b>process</b>: process</description></item>
        /// <item><description><b>software</b>: software</description></item>
        /// <item><description><b>user</b>: account</description></item>
        /// <item><description><b>sca</b>: middleware</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sca</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
