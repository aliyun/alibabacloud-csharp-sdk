// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20230601.Models
{
    public class SearchEnterpriseDataResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<SearchEnterpriseDataResponseBodyData> Data { get; set; }
        public class SearchEnterpriseDataResponseBodyData : TeaModel {
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            [NameInMap("DataName")]
            [Validation(Required=false)]
            public string DataName { get; set; }

            [NameInMap("Score")]
            [Validation(Required=false)]
            public string Score { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("TitlePath")]
            [Validation(Required=false)]
            public string TitlePath { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
