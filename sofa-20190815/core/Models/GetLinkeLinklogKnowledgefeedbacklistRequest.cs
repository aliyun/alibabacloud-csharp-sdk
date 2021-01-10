// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeLinklogKnowledgefeedbacklistRequest : TeaModel {
        [NameInMap("Begin")]
        [Validation(Required=false)]
        public long? Begin { get; set; }

        [NameInMap("BeginText")]
        [Validation(Required=false)]
        public string BeginText { get; set; }

        [NameInMap("DataRepeatList")]
        [Validation(Required=false)]
        public List<string> DataRepeatList { get; set; }

        [NameInMap("End")]
        [Validation(Required=false)]
        public long? End { get; set; }

        [NameInMap("EndText")]
        [Validation(Required=false)]
        public string EndText { get; set; }

        [NameInMap("Feedback")]
        [Validation(Required=false)]
        public string Feedback { get; set; }

        [NameInMap("FieldsRepeatList")]
        [Validation(Required=false)]
        public List<string> FieldsRepeatList { get; set; }

        [NameInMap("ListRepeatList")]
        [Validation(Required=false)]
        public List<string> ListRepeatList { get; set; }

        [NameInMap("StoreIds")]
        [Validation(Required=false)]
        public long? StoreIds { get; set; }

    }

}
