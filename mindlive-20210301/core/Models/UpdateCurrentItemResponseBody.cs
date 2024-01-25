// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MindLive20210301.Models
{
    public class UpdateCurrentItemResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateCurrentItemResponseBodyData Data { get; set; }
        public class UpdateCurrentItemResponseBodyData : TeaModel {
            [NameInMap("ItemBackground")]
            [Validation(Required=false)]
            public UpdateCurrentItemResponseBodyDataItemBackground ItemBackground { get; set; }
            public class UpdateCurrentItemResponseBodyDataItemBackground : TeaModel {
                [NameInMap("DownloadUrl")]
                [Validation(Required=false)]
                public string DownloadUrl { get; set; }

                [NameInMap("FileType")]
                [Validation(Required=false)]
                public string FileType { get; set; }

                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public string ItemId { get; set; }

                [NameInMap("ResourceUuid")]
                [Validation(Required=false)]
                public string ResourceUuid { get; set; }

                [NameInMap("Scope")]
                [Validation(Required=false)]
                public string Scope { get; set; }

            }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
