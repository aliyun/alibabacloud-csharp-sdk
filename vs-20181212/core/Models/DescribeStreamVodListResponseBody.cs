// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeStreamVodListResponseBody : TeaModel {
        /// <summary>
        /// <para>VOD record list</para>
        /// </summary>
        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<DescribeStreamVodListResponseBodyRecords> Records { get; set; }
        public class DescribeStreamVodListResponseBodyRecords : TeaModel {
            /// <summary>
            /// <para>VOD record end time (unix timestamp, unit: seconds)</para>
            /// 
            /// <b>Example:</b>
            /// <para>1634873413</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>VOD record start time (unix timestamp, unit: seconds)</para>
            /// 
            /// <b>Example:</b>
            /// <para>1639077653</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// <para>Request ID of this task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
