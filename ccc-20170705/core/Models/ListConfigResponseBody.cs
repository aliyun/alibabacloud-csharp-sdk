// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ListConfigResponseBody : TeaModel {
        [NameInMap("ConfigItems")]
        [Validation(Required=false)]
        public ListConfigResponseBodyConfigItems ConfigItems { get; set; }
        public class ListConfigResponseBodyConfigItems : TeaModel {
            [NameInMap("ConfigItem")]
            [Validation(Required=false)]
            public List<ListConfigResponseBodyConfigItemsConfigItem> ConfigItem { get; set; }
            public class ListConfigResponseBodyConfigItemsConfigItem : TeaModel {
                public string Value { get; set; }
                public string Name { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
