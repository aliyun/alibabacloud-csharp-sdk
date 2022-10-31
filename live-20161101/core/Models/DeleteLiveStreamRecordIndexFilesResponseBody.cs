// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DeleteLiveStreamRecordIndexFilesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RecordDeleteInfoList")]
        [Validation(Required=false)]
        public DeleteLiveStreamRecordIndexFilesResponseBodyRecordDeleteInfoList RecordDeleteInfoList { get; set; }
        public class DeleteLiveStreamRecordIndexFilesResponseBodyRecordDeleteInfoList : TeaModel {
            [NameInMap("RecordDeleteInfo")]
            [Validation(Required=false)]
            public List<DeleteLiveStreamRecordIndexFilesResponseBodyRecordDeleteInfoListRecordDeleteInfo> RecordDeleteInfo { get; set; }
            public class DeleteLiveStreamRecordIndexFilesResponseBodyRecordDeleteInfoListRecordDeleteInfo : TeaModel {
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("RecordId")]
                [Validation(Required=false)]
                public string RecordId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
