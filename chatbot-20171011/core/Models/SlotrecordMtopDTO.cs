// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class SlotrecordMtopDTO : TeaModel {
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("IsArray")]
        [Validation(Required=false)]
        public bool? IsArray { get; set; }

        [NameInMap("IsNecessary")]
        [Validation(Required=false)]
        public bool? IsNecessary { get; set; }

        [NameInMap("LifeSpan")]
        [Validation(Required=false)]
        public int? LifeSpan { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Question")]
        [Validation(Required=false)]
        public List<string> Question { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<TagMtopDTO> Tags { get; set; }

        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
