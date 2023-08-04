// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds_data20220330.Models
{
    public class Selector : TeaModel {
        [NameInMap("Eq")]
        [Validation(Required=false)]
        public string Eq { get; set; }

        [NameInMap("Ge")]
        [Validation(Required=false)]
        public string Ge { get; set; }

        [NameInMap("Gt")]
        [Validation(Required=false)]
        public string Gt { get; set; }

        [NameInMap("Le")]
        [Validation(Required=false)]
        public string Le { get; set; }

        [NameInMap("Like")]
        [Validation(Required=false)]
        public string Like { get; set; }

        [NameInMap("Lt")]
        [Validation(Required=false)]
        public string Lt { get; set; }

        [NameInMap("Ne")]
        [Validation(Required=false)]
        public string Ne { get; set; }

    }

}
