// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetDataQualityScanRunLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The task log information.</para>
        /// </summary>
        [NameInMap("LogSegment")]
        [Validation(Required=false)]
        public GetDataQualityScanRunLogResponseBodyLogSegment LogSegment { get; set; }
        public class GetDataQualityScanRunLogResponseBodyLogSegment : TeaModel {
            /// <summary>
            /// <para>The task log.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running on Serverless_resource_group_xxxxx
            /// Begin to check rule ***</para>
            /// </summary>
            [NameInMap("Log")]
            [Validation(Required=false)]
            public string Log { get; set; }

            /// <summary>
            /// <para>The starting offset of the next log segment. A value of -1 indicates that all logs have been read.</para>
            /// 
            /// <b>Example:</b>
            /// <para>512000</para>
            /// </summary>
            [NameInMap("NextOffset")]
            [Validation(Required=false)]
            public long? NextOffset { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc14115***159376359</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
