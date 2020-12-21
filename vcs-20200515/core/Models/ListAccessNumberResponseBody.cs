// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ListAccessNumberResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAccessNumberResponseBodyData> Data { get; set; }
        public class ListAccessNumberResponseBodyData : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public string Item { get; set; }

            [NameInMap("Count")]
            [Validation(Required=false)]
            public string Count { get; set; }

            [NameInMap("Percent")]
            [Validation(Required=false)]
            public string Percent { get; set; }

        }

    }

}
