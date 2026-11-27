// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeAppRecordingFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>List of recording files.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeAppRecordingFilesResponseBodyItems> Items { get; set; }
        public class DescribeAppRecordingFilesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>User-defined bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rtc-bucket</para>
            /// </summary>
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            /// <summary>
            /// <para>Channel ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testchannelId</para>
            /// </summary>
            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

            /// <summary>
            /// <para>Recording file creation timestamp, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1712376032000</para>
            /// </summary>
            [NameInMap("FileCreateTs")]
            [Validation(Required=false)]
            public long? FileCreateTs { get; set; }

            /// <summary>
            /// <para>Recording file duration, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("FileDuration")]
            [Validation(Required=false)]
            public int? FileDuration { get; set; }

            /// <summary>
            /// <para>Path where the recording file is stored. Use the SDK of your cloud provider&quot;s Object Storage Service to access the file. For Alibaba Cloud OSS, see <a href="https://help.aliyun.com/zh/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects">here</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>record/appid/12_task_local1/1712279809158_1712279844691/playlist.mp4</para>
            /// </summary>
            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            /// <summary>
            /// <para>Recording file size, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public int? FileSize { get; set; }

            /// <summary>
            /// <para>See region used in the recording task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public int? Region { get; set; }

            /// <summary>
            /// <para>Recording task start timestamp, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1712376012000</para>
            /// </summary>
            [NameInMap("StartTs")]
            [Validation(Required=false)]
            public long? StartTs { get; set; }

            /// <summary>
            /// <para>Recording task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test001</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>See vendor used when starting the recording task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public int? Vendor { get; set; }

        }

        /// <summary>
        /// <para>Page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>Number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CF8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCnt")]
        [Validation(Required=false)]
        public int? TotalCnt { get; set; }

    }

}
