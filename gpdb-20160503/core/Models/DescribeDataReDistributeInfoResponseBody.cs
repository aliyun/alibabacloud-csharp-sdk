// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDataReDistributeInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The data redistribution information.</para>
        /// </summary>
        [NameInMap("DataReDistributeInfo")]
        [Validation(Required=false)]
        public DescribeDataReDistributeInfoResponseBodyDataReDistributeInfo DataReDistributeInfo { get; set; }
        public class DescribeDataReDistributeInfoResponseBodyDataReDistributeInfo : TeaModel {
            /// <summary>
            /// <para>The execution information. If an error occurs, the error message is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>redistributing</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The progress of data redistribution. Unit: %.</para>
            /// 
            /// <b>Example:</b>
            /// <para>33</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public long? Progress { get; set; }

            /// <summary>
            /// <para>The estimated remaining time for data redistribution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:01:28</para>
            /// </summary>
            [NameInMap("RemainTime")]
            [Validation(Required=false)]
            public string RemainTime { get; set; }

            /// <summary>
            /// <para>This parameter is not supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The status of data redistribution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The execution type. The value <b>immediate</b> is returned, indicating immediate execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>immediate</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04836A02-ADC9-1AA7-AC36-DE5E048BF505</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
