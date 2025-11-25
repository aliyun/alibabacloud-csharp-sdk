// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeConfiguredDestinationIPResponseBody : TeaModel {
        [NameInMap("Destinations")]
        [Validation(Required=false)]
        public List<DescribeConfiguredDestinationIPResponseBodyDestinations> Destinations { get; set; }
        public class DescribeConfiguredDestinationIPResponseBodyDestinations : TeaModel {
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.1.1.1</para>
            /// </summary>
            [NameInMap("DestinationIP")]
            [Validation(Required=false)]
            public string DestinationIP { get; set; }

            [NameInMap("DestinationISP")]
            [Validation(Required=false)]
            public string DestinationISP { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shenzhen</para>
            /// </summary>
            [NameInMap("DestinationRegion")]
            [Validation(Required=false)]
            public string DestinationRegion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1534408189</para>
            /// </summary>
            [NameInMap("OperationTime")]
            [Validation(Required=false)]
            public int? OperationTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F0AE91F8-E6C5-50D4-983F-FC53672****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
