// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeRecordingsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6nbCQ7ar+fECeh1IuWQXi39R5eoJ68zWp99mTAKRRNRhw==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("Recordings")]
        [Validation(Required=false)]
        public List<DescribeRecordingsResponseBodyRecordings> Recordings { get; set; }
        public class DescribeRecordingsResponseBodyRecordings : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ecd-10v0vuvm616sk****</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DemoComputer</para>
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-04-10T07:26:06Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("EndUserIds")]
            [Validation(Required=false)]
            public List<string> EndUserIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pg-4w5nk44zo5yl129dd/1mk78dugw344.mp4</para>
            /// </summary>
            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pg-6dn811rzrwh9ws4z6</para>
            /// </summary>
            [NameInMap("PolicyGroupId")]
            [Validation(Required=false)]
            public string PolicyGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1742845</para>
            /// </summary>
            [NameInMap("RecordingSize")]
            [Validation(Required=false)]
            public int? RecordingSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>alltime</para>
            /// </summary>
            [NameInMap("RecordingType")]
            [Validation(Required=false)]
            public string RecordingType { get; set; }

            [NameInMap("SignedUrl")]
            [Validation(Required=false)]
            public string SignedUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-04-10T07:26:06Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>327CFE78-1C0D-51AC-A9C6-BCEDF0DD44D6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
