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
        /// <para>The ID of the request. The ID is a unique identifier that Alibaba Cloud generates for the request and can be used to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16AA5B62-A3C1-520B-B289-4BD971CC17AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The collection of statistics results.</para>
        /// </summary>
        [NameInMap("TopStatisticItems")]
        [Validation(Required=false)]
        public List<DescribePropertyUsageTopResponseBodyTopStatisticItems> TopStatisticItems { get; set; }
        public class DescribePropertyUsageTopResponseBodyTopStatisticItems : TeaModel {
            /// <summary>
            /// <para>The count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The statistics item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>openssl</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The Asset Fingerprints type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>port</b>: port</description></item>
        /// <item><description><b>process</b>: process</description></item>
        /// <item><description><b>software</b>: software</description></item>
        /// <item><description><b>user</b>: account</description></item>
        /// <item><description><b>sca</b>: middleware.</description></item>
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
