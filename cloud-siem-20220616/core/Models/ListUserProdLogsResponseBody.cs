// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListUserProdLogsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListUserProdLogsResponseBodyData> Data { get; set; }
        public class ListUserProdLogsResponseBodyData : TeaModel {
            [NameInMap("DisplayLine")]
            [Validation(Required=false)]
            public string DisplayLine { get; set; }

            [NameInMap("Displayed")]
            [Validation(Required=false)]
            public bool? Displayed { get; set; }

            [NameInMap("Imported")]
            [Validation(Required=false)]
            public bool? Imported { get; set; }

            [NameInMap("IsDeleted")]
            [Validation(Required=false)]
            public int? IsDeleted { get; set; }

            [NameInMap("MainUserId")]
            [Validation(Required=false)]
            public long? MainUserId { get; set; }

            [NameInMap("SourceLogCode")]
            [Validation(Required=false)]
            public string SourceLogCode { get; set; }

            [NameInMap("SourceLogInfo")]
            [Validation(Required=false)]
            public string SourceLogInfo { get; set; }

            [NameInMap("SourceProdCode")]
            [Validation(Required=false)]
            public string SourceProdCode { get; set; }

            [NameInMap("SubUserId")]
            [Validation(Required=false)]
            public long? SubUserId { get; set; }

            [NameInMap("SubUserName")]
            [Validation(Required=false)]
            public string SubUserName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
