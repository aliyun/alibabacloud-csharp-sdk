// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeApsJobDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("APSJobDetail")]
        [Validation(Required=false)]
        public DescribeApsJobDetailResponseBodyAPSJobDetail APSJobDetail { get; set; }
        public class DescribeApsJobDetailResponseBodyAPSJobDetail : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("DbList")]
            [Validation(Required=false)]
            public string DbList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>amv-******</para>
            /// </summary>
            [NameInMap("DestinationEndpointInstanceID")]
            [Validation(Required=false)]
            public string DestinationEndpointInstanceID { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("DestinationEndpointRegion")]
            [Validation(Required=false)]
            public string DestinationEndpointRegion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("PartitionList")]
            [Validation(Required=false)]
            public string PartitionList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pc-*******</para>
            /// </summary>
            [NameInMap("SourceEndpointInstanceID")]
            [Validation(Required=false)]
            public string SourceEndpointInstanceID { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("SourceEndpointRegion")]
            [Validation(Required=false)]
            public string SourceEndpointRegion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TargetTableMode")]
            [Validation(Required=false)]
            public string TargetTableMode { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b><b>-E606-4A42-BF6D-</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
