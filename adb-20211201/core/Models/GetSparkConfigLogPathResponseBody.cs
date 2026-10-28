// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetSparkConfigLogPathResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried Spark log configuration.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSparkConfigLogPathResponseBodyData Data { get; set; }
        public class GetSparkConfigLogPathResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The default log path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://aliyun-oa-adb-spark-1111-oss-cn-hanghzou/spark-logs</para>
            /// </summary>
            [NameInMap("DefaultLogPath")]
            [Validation(Required=false)]
            public string DefaultLogPath { get; set; }

            /// <summary>
            /// <para>Indicates whether a log path exists.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsLogPathExists")]
            [Validation(Required=false)]
            public bool? IsLogPathExists { get; set; }

            /// <summary>
            /// <para>The last modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1675654361000</para>
            /// </summary>
            [NameInMap("ModifiedTimestamp")]
            [Validation(Required=false)]
            public string ModifiedTimestamp { get; set; }

            /// <summary>
            /// <para>The account ID of the modifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10130223128xxx</para>
            /// </summary>
            [NameInMap("ModifiedUid")]
            [Validation(Required=false)]
            public string ModifiedUid { get; set; }

            /// <summary>
            /// <para>The recorded log path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test/spark-logs/</para>
            /// </summary>
            [NameInMap("RecordedLogPath")]
            [Validation(Required=false)]
            public string RecordedLogPath { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1919-xxx-ssdfsdff</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
