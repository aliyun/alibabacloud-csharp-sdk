// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeRecordingsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination token for the next query. If NextToken is empty, no more results exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6nbCQ7ar+fECeh1IuWQXi39R5eoJ68zWp99mTAKRRNRhw==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The collection of cloud computer screen recording information.</para>
        /// </summary>
        [NameInMap("Recordings")]
        [Validation(Required=false)]
        public List<DescribeRecordingsResponseBodyRecordings> Recordings { get; set; }
        public class DescribeRecordingsResponseBodyRecordings : TeaModel {
            /// <summary>
            /// <para>The cloud computer ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-10v0vuvm616sk****</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <para>The cloud computer name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DemoComputer</para>
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            /// <summary>
            /// <para>The end time of the recording. The time is in the ISO 8601 standard in UTC: yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-10T07:26:06Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The list of end user IDs.</para>
            /// </summary>
            [NameInMap("EndUserIds")]
            [Validation(Required=false)]
            public List<string> EndUserIds { get; set; }

            /// <summary>
            /// <para>The file path.</para>
            /// </summary>
            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            /// <summary>
            /// <para>The policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg-6dn811rzrwh9w****</para>
            /// </summary>
            [NameInMap("PolicyGroupId")]
            [Validation(Required=false)]
            public string PolicyGroupId { get; set; }

            /// <summary>
            /// <para>The size of the recording file. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1742845</para>
            /// </summary>
            [NameInMap("RecordingSize")]
            [Validation(Required=false)]
            public int? RecordingSize { get; set; }

            /// <summary>
            /// <para>The recording type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alltime</para>
            /// </summary>
            [NameInMap("RecordingType")]
            [Validation(Required=false)]
            public string RecordingType { get; set; }

            /// <summary>
            /// <para>The download URL of the screen recording file.</para>
            /// </summary>
            [NameInMap("SignedUrl")]
            [Validation(Required=false)]
            public string SignedUrl { get; set; }

            /// <summary>
            /// <para>The start time of the recording. The time is in the ISO 8601 standard in UTC: yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-10T07:26:06Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>327CFE78-1C0D-51AC-A9C6-BCEDF0DD44D6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
