// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeRtcCloudRecordingFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>58-5876-</b></b>-83CA-B56278</b>****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task information.</para>
        /// </summary>
        [NameInMap("TaskInfo")]
        [Validation(Required=false)]
        public DescribeRtcCloudRecordingFilesResponseBodyTaskInfo TaskInfo { get; set; }
        public class DescribeRtcCloudRecordingFilesResponseBodyTaskInfo : TeaModel {
            /// <summary>
            /// <para>The list of recording files.</para>
            /// </summary>
            [NameInMap("RecordFileList")]
            [Validation(Required=false)]
            public DescribeRtcCloudRecordingFilesResponseBodyTaskInfoRecordFileList RecordFileList { get; set; }
            public class DescribeRtcCloudRecordingFilesResponseBodyTaskInfoRecordFileList : TeaModel {
                /// <summary>
                /// <para>The array of HLS recording file names.</para>
                /// </summary>
                [NameInMap("HlsFileList")]
                [Validation(Required=false)]
                public List<string> HlsFileList { get; set; }

                /// <summary>
                /// <para>The array of MP3 recording file names.</para>
                /// </summary>
                [NameInMap("Mp3FileList")]
                [Validation(Required=false)]
                public List<string> Mp3FileList { get; set; }

                /// <summary>
                /// <para>The array of MP4 recording file names.</para>
                /// </summary>
                [NameInMap("Mp4FileList")]
                [Validation(Required=false)]
                public List<string> Mp4FileList { get; set; }

                /// <summary>
                /// <para>The array of VOD media resources. When recording to VOD, this is the collection of recording files for each subscribed stream, where each item corresponds to a subscribed stream.</para>
                /// </summary>
                [NameInMap("VodMediaList")]
                [Validation(Required=false)]
                public List<DescribeRtcCloudRecordingFilesResponseBodyTaskInfoRecordFileListVodMediaList> VodMediaList { get; set; }
                public class DescribeRtcCloudRecordingFilesResponseBodyTaskInfoRecordFileListVodMediaList : TeaModel {
                    /// <summary>
                    /// <para>The array of media resource IDs generated during recording.</para>
                    /// </summary>
                    [NameInMap("MediaIds")]
                    [Validation(Required=false)]
                    public List<string> MediaIds { get; set; }

                    /// <summary>
                    /// <para>The array of automatically merged media resource IDs generated after recording ends.</para>
                    /// </summary>
                    [NameInMap("MergedIds")]
                    [Validation(Required=false)]
                    public List<string> MergedIds { get; set; }

                    /// <summary>
                    /// <para>The subscribed stream.</para>
                    /// <list type="bullet">
                    /// <item><description>For stream mixing recording, the value is always Mix.</description></item>
                    /// <item><description>For single-stream recording, the value is Single::{UserId}::{Suffix}.<list type="bullet">
                    /// <item><description>UserId is the UserId corresponding to this stream.</description></item>
                    /// <item><description>Suffix depends on the StreamType and SourceType specified during subscription.<list type="bullet">
                    /// <item><description>When StreamType is 0: if SourceType is 0, Suffix is AV::C. If SourceType is 1, Suffix is AV::S.</description></item>
                    /// <item><description>When StreamType is 1: Suffix can only be A.</description></item>
                    /// <item><description>When StreamType is 2 (not supported for single-stream recording): if SourceType is 0, Suffix is V::C. If SourceType is 1, Suffix is V::S.</description></item>
                    /// </list>
                    /// </description></item>
                    /// </list>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Single::UserA::AV::C</para>
                    /// </summary>
                    [NameInMap("Stream")]
                    [Validation(Required=false)]
                    public string Stream { get; set; }

                }

            }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>RUNNING</description></item>
            /// <item><description>RECOVERING</description></item>
            /// <item><description>STOPPING</description></item>
            /// <item><description>STOPPED.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The task ID passed in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b><b>73-8501-</b></b>-8ac1-72295a</b>****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
