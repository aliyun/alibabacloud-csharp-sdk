// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeInstDbLogInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The time range for log query.</para>
        /// </summary>
        [NameInMap("LogTimeRange")]
        [Validation(Required=false)]
        public DescribeInstDbLogInfoResponseBodyLogTimeRange LogTimeRange { get; set; }
        public class DescribeInstDbLogInfoResponseBodyLogTimeRange : TeaModel {
            /// <summary>
            /// <para>The start time of the query time range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1568267711</para>
            /// </summary>
            [NameInMap("SupportLatestTime")]
            [Validation(Required=false)]
            public long? SupportLatestTime { get; set; }

            /// <summary>
            /// <para>The end time of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1568367711</para>
            /// </summary>
            [NameInMap("SupportOldestTime")]
            [Validation(Required=false)]
            public long? SupportOldestTime { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5438952-70EE-4FA5-87A9-080DB0ASD45F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
