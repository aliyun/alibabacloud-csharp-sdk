// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListDsMenusResponseBody : TeaModel {
        [NameInMap("Ext")]
        [Validation(Required=false)]
        public string Ext { get; set; }

        [NameInMap("Menus")]
        [Validation(Required=false)]
        public List<ListDsMenusResponseBodyMenus> Menus { get; set; }
        public class ListDsMenusResponseBodyMenus : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("TitleEn")]
            [Validation(Required=false)]
            public string TitleEn { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
