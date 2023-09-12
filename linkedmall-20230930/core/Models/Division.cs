// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class Division : TeaModel {
        [NameInMap("divisionCode")]
        [Validation(Required=false)]
        public long? DivisionCode { get; set; }

        [NameInMap("divisionLevel")]
        [Validation(Required=false)]
        public long? DivisionLevel { get; set; }

        [NameInMap("divisionName")]
        [Validation(Required=false)]
        public string DivisionName { get; set; }

        [NameInMap("parentId")]
        [Validation(Required=false)]
        public long? ParentId { get; set; }

        [NameInMap("pinyin")]
        [Validation(Required=false)]
        public string Pinyin { get; set; }

    }

}
