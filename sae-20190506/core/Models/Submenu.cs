// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class Submenu : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<SubmenuItems> Items { get; set; }
        public class SubmenuItems : TeaModel {
            [NameInMap("DefaultSelected")]
            [Validation(Required=false)]
            public bool? DefaultSelected { get; set; }

            [NameInMap("ItemDesc")]
            [Validation(Required=false)]
            public string ItemDesc { get; set; }

            [NameInMap("ItemType")]
            [Validation(Required=false)]
            public string ItemType { get; set; }

            [NameInMap("RelatingItems")]
            [Validation(Required=false)]
            public List<string> RelatingItems { get; set; }

        }

        [NameInMap("SubmenuDesc")]
        [Validation(Required=false)]
        public string SubmenuDesc { get; set; }

        [NameInMap("SubmenuType")]
        [Validation(Required=false)]
        public string SubmenuType { get; set; }

        [NameInMap("Submenus")]
        [Validation(Required=false)]
        public List<Submenu> Submenus { get; set; }

    }

}
