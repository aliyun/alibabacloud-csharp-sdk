// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeRecordingsResponseBody : TeaModel {
        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6nbCQ7ar+fECeh1IuWQXi39R5eoJ68zWp99mTAKRRNRhw==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The screen recording files.</para>
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
            /// <para>The end time of the recording.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-10T07:26:06Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The end user IDs.</para>
            /// </summary>
            [NameInMap("EndUserIds")]
            [Validation(Required=false)]
            public List<string> EndUserIds { get; set; }

            /// <summary>
            /// <para>The file path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg-4w5nk44zo5yl129dd/1mk78dugw344.mp4</para>
            /// </summary>
            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            /// <summary>
            /// <para>The policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg-6dn811rzrwh9ws4z6</para>
            /// </summary>
            [NameInMap("PolicyGroupId")]
            [Validation(Required=false)]
            public string PolicyGroupId { get; set; }

            /// <summary>
            /// <para>The size of the screen recording file. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1742845</para>
            /// </summary>
            [NameInMap("RecordingSize")]
            [Validation(Required=false)]
            public int? RecordingSize { get; set; }

            /// <summary>
            /// <para>The type of event that triggers the recording.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>byaction_cmd_ft: triggered by copy-paste or file transfer events.</description></item>
            /// <item><description>period: triggered at scheduled intervals.</description></item>
            /// <item><description>session: triggered by session lifecycle monitoring.</description></item>
            /// <item><description>byaction_commands: triggered by copy-paste only.</description></item>
            /// <item><description>alltime: continuous recording.</description></item>
            /// <item><description>byaction_file_transfer: triggered by file transfer only.</description></item>
            /// </list>
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
            /// <para>The start time of the recording.</para>
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
