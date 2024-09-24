// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAssetsScaProcessNumResponseBody : TeaModel {
        /// <summary>
        /// <para>The statistical results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeAssetsScaProcessNumResponseBodyData> Data { get; set; }
        public class DescribeAssetsScaProcessNumResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of Java processes.</para>
            /// <remarks>
            /// <para> If no processes exist on the asset, no statistical result is returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The UUID of the asset.</para>
            /// <remarks>
            /// <para> If no processes exist on the asset, no statistical result is returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>6690a46c-0edb-4663-a641-3629d1a9****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACF97412-FD09-4D1F-994F-34DF12BREF20</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
