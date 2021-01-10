// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListDTXAppsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDTXAppsResponseBodyData> Data { get; set; }
        public class ListDTXAppsResponseBodyData : TeaModel {
            [NameInMap("ActionMode")]
            [Validation(Required=false)]
            public long? ActionMode { get; set; }

            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("ExceptionTotal")]
            [Validation(Required=false)]
            public long? ExceptionTotal { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("TodayTotal")]
            [Validation(Required=false)]
            public long? TodayTotal { get; set; }

            [NameInMap("Initiator")]
            [Validation(Required=false)]
            public List<string> Initiator { get; set; }

            [NameInMap("Participator")]
            [Validation(Required=false)]
            public List<string> Participator { get; set; }

        }

    }

}
