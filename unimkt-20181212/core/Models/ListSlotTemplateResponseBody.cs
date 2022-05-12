// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class ListSlotTemplateResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public List<ListSlotTemplateResponseBodyModel> Model { get; set; }
        public class ListSlotTemplateResponseBodyModel : TeaModel {
            [NameInMap("AccessStatus")]
            [Validation(Required=false)]
            public string AccessStatus { get; set; }

            [NameInMap("AccessWay")]
            [Validation(Required=false)]
            public string AccessWay { get; set; }

            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("ExtInfo")]
            [Validation(Required=false)]
            public string ExtInfo { get; set; }

            [NameInMap("FirstScene")]
            [Validation(Required=false)]
            public string FirstScene { get; set; }

            [NameInMap("KeyWords")]
            [Validation(Required=false)]
            public string KeyWords { get; set; }

            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            [NameInMap("MediaName")]
            [Validation(Required=false)]
            public string MediaName { get; set; }

            [NameInMap("MediaStatus")]
            [Validation(Required=false)]
            public string MediaStatus { get; set; }

            [NameInMap("MediaType")]
            [Validation(Required=false)]
            public string MediaType { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            [NameInMap("SecondScene")]
            [Validation(Required=false)]
            public string SecondScene { get; set; }

            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
