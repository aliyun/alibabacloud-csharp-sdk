// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeAppRecordingFilesResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeAppRecordingFilesResponseBodyItems> Items { get; set; }
        public class DescribeAppRecordingFilesResponseBodyItems : TeaModel {
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

            [NameInMap("FileCreateTs")]
            [Validation(Required=false)]
            public long? FileCreateTs { get; set; }

            [NameInMap("FileDuration")]
            [Validation(Required=false)]
            public int? FileDuration { get; set; }

            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public int? FileSize { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public int? Region { get; set; }

            [NameInMap("StartTs")]
            [Validation(Required=false)]
            public int? StartTs { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public int? Vendor { get; set; }

        }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCnt")]
        [Validation(Required=false)]
        public int? TotalCnt { get; set; }

    }

}
