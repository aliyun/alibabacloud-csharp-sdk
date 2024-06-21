// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeAppRecordingFilesShrinkRequest : TeaModel {
        /// <summary>
        /// APP ID。
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        [NameInMap("EndTs")]
        [Validation(Required=false)]
        public long? EndTs { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("StartTs")]
        [Validation(Required=false)]
        public long? StartTs { get; set; }

        [NameInMap("TaskIds")]
        [Validation(Required=false)]
        public string TaskIdsShrink { get; set; }

    }

}
