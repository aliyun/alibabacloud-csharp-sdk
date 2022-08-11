// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetExtensionResponseBody : TeaModel {
        [NameInMap("Extension")]
        [Validation(Required=false)]
        public GetExtensionResponseBodyExtension Extension { get; set; }
        public class GetExtensionResponseBodyExtension : TeaModel {
            [NameInMap("BindEventList")]
            [Validation(Required=false)]
            public List<GetExtensionResponseBodyExtensionBindEventList> BindEventList { get; set; }
            public class GetExtensionResponseBodyExtensionBindEventList : TeaModel {
                public string EventCode { get; set; }
                public string EventName { get; set; }
            }
            [NameInMap("DetailUrl")]
            [Validation(Required=false)]
            public string DetailUrl { get; set; }
            [NameInMap("EventCategoryList")]
            [Validation(Required=false)]
            public List<GetExtensionResponseBodyExtensionEventCategoryList> EventCategoryList { get; set; }
            public class GetExtensionResponseBodyExtensionEventCategoryList : TeaModel {
                public string CategoryCode { get; set; }
                public string CategoryName { get; set; }
            }
            [NameInMap("ExtensionCode")]
            [Validation(Required=false)]
            public string ExtensionCode { get; set; }
            [NameInMap("ExtensionDesc")]
            [Validation(Required=false)]
            public string ExtensionDesc { get; set; }
            [NameInMap("ExtensionName")]
            [Validation(Required=false)]
            public string ExtensionName { get; set; }
            [NameInMap("HelpDocUrl")]
            [Validation(Required=false)]
            public string HelpDocUrl { get; set; }
            [NameInMap("OptionSetting")]
            [Validation(Required=false)]
            public string OptionSetting { get; set; }
            [NameInMap("ParameterSetting")]
            [Validation(Required=false)]
            public string ParameterSetting { get; set; }
            [NameInMap("ProjectTesting")]
            [Validation(Required=false)]
            public long? ProjectTesting { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
