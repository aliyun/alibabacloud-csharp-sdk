// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20190902.Models
{
    public class ListAreasResponseBody : TeaModel {
        [NameInMap("Datas")]
        [Validation(Required=false)]
        public List<ListAreasResponseBodyDatas> Datas { get; set; }
        public class ListAreasResponseBodyDatas : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ParentCode")]
            [Validation(Required=false)]
            public string ParentCode { get; set; }

            [NameInMap("SortNum")]
            [Validation(Required=false)]
            public int? SortNum { get; set; }

            [NameInMap("SubArea")]
            [Validation(Required=false)]
            public List<ListAreasResponseBodyDatasSubArea> SubArea { get; set; }
            public class ListAreasResponseBodyDatasSubArea : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ParentCode")]
                [Validation(Required=false)]
                public string ParentCode { get; set; }

                [NameInMap("SortNum")]
                [Validation(Required=false)]
                public int? SortNum { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
