// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QuerySoundCodeLabelBatchFailedResultResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QuerySoundCodeLabelBatchFailedResultResponseData Data { get; set; }
        public class QuerySoundCodeLabelBatchFailedResultResponseData : TeaModel {
            [NameInMap("Items")]
            [Validation(Required=true)]
            public List<QuerySoundCodeLabelBatchFailedResultResponseDataItems> Items { get; set; }
            public class QuerySoundCodeLabelBatchFailedResultResponseDataItems : TeaModel {
                [NameInMap("ErrorMessage")]
                [Validation(Required=true)]
                public string ErrorMessage { get; set; }

                [NameInMap("Label")]
                [Validation(Required=true)]
                public string Label { get; set; }

                [NameInMap("ResultCode")]
                [Validation(Required=true)]
                public string ResultCode { get; set; }

            }

        }

    }

}
