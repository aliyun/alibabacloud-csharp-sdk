// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetRumDataForPageResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRumDataForPageResponseBodyData Data { get; set; }
        public class GetRumDataForPageResponseBodyData : TeaModel {
            [NameInMap("Authentication")]
            [Validation(Required=false)]
            public string Authentication { get; set; }

            [NameInMap("Completion")]
            [Validation(Required=false)]
            public string Completion { get; set; }

            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Items { get; set; }

            [NameInMap("Page")]
            [Validation(Required=false)]
            public string Page { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            [NameInMap("Preference")]
            [Validation(Required=false)]
            public string Preference { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public string Total { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
