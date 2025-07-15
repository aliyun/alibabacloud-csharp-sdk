// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeRtcCloudRecordingFilesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b><b>58-5876-</b></b>-83CA-B56278</b>****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TaskInfo")]
        [Validation(Required=false)]
        public DescribeRtcCloudRecordingFilesResponseBodyTaskInfo TaskInfo { get; set; }
        public class DescribeRtcCloudRecordingFilesResponseBodyTaskInfo : TeaModel {
            [NameInMap("RecordFileList")]
            [Validation(Required=false)]
            public DescribeRtcCloudRecordingFilesResponseBodyTaskInfoRecordFileList RecordFileList { get; set; }
            public class DescribeRtcCloudRecordingFilesResponseBodyTaskInfoRecordFileList : TeaModel {
                [NameInMap("HlsFileList")]
                [Validation(Required=false)]
                public List<string> HlsFileList { get; set; }

                [NameInMap("Mp3FileList")]
                [Validation(Required=false)]
                public List<string> Mp3FileList { get; set; }

                [NameInMap("Mp4FileList")]
                [Validation(Required=false)]
                public List<string> Mp4FileList { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><b><b><b>73-8501-</b></b>-8ac1-72295a</b>****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
