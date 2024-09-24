// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class SetSparkAppLogRootPathResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SetSparkAppLogRootPathResponseBodyData Data { get; set; }
        public class SetSparkAppLogRootPathResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The recommended default OSS log path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://path/to/log</para>
            /// </summary>
            [NameInMap("DefaultLogPath")]
            [Validation(Required=false)]
            public string DefaultLogPath { get; set; }

            /// <summary>
            /// <para>Indicates whether an OSS log path exists.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsLogPathExists")]
            [Validation(Required=false)]
            public bool? IsLogPathExists { get; set; }

            /// <summary>
            /// <para>The time when the modification was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1675236908</para>
            /// </summary>
            [NameInMap("ModifiedTimestamp")]
            [Validation(Required=false)]
            public string ModifiedTimestamp { get; set; }

            /// <summary>
            /// <para>The modifier ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1111111</para>
            /// </summary>
            [NameInMap("ModifiedUid")]
            [Validation(Required=false)]
            public string ModifiedUid { get; set; }

            /// <summary>
            /// <para>The OSS log path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://path/to/log</para>
            /// </summary>
            [NameInMap("RecordedLogPath")]
            [Validation(Required=false)]
            public string RecordedLogPath { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D65A809F-34CE-4550-9BC1-0ED21ETG380</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
