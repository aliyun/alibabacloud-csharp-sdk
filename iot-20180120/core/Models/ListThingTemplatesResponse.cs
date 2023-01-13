// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListThingTemplatesResponse : TeaModel {
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
        public List<ListThingTemplatesResponseData> Data { get; set; }
        public class ListThingTemplatesResponseData : TeaModel {
            [NameInMap("CategoryKey")]
            [Validation(Required=true)]
            public string CategoryKey { get; set; }

            [NameInMap("CategoryName")]
            [Validation(Required=true)]
            public string CategoryName { get; set; }

        }

    }

}
