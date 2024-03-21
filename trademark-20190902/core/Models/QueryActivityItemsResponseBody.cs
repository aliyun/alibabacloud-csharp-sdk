// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20190902.Models
{
    public class QueryActivityItemsResponseBody : TeaModel {
        [NameInMap("Module")]
        [Validation(Required=false)]
        public QueryActivityItemsResponseBodyModule Module { get; set; }
        public class QueryActivityItemsResponseBodyModule : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public string Data { get; set; }

            [NameInMap("FloorDisplayInfos")]
            [Validation(Required=false)]
            public QueryActivityItemsResponseBodyModuleFloorDisplayInfos FloorDisplayInfos { get; set; }
            public class QueryActivityItemsResponseBodyModuleFloorDisplayInfos : TeaModel {
                [NameInMap("floor")]
                [Validation(Required=false)]
                public List<QueryActivityItemsResponseBodyModuleFloorDisplayInfosFloor> Floor { get; set; }
                public class QueryActivityItemsResponseBodyModuleFloorDisplayInfosFloor : TeaModel {
                    [NameInMap("Icon")]
                    [Validation(Required=false)]
                    public string Icon { get; set; }

                    [NameInMap("Index")]
                    [Validation(Required=false)]
                    public int? Index { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("SubTitles")]
                    [Validation(Required=false)]
                    public QueryActivityItemsResponseBodyModuleFloorDisplayInfosFloorSubTitles SubTitles { get; set; }
                    public class QueryActivityItemsResponseBodyModuleFloorDisplayInfosFloorSubTitles : TeaModel {
                        [NameInMap("subFloor")]
                        [Validation(Required=false)]
                        public List<QueryActivityItemsResponseBodyModuleFloorDisplayInfosFloorSubTitlesSubFloor> SubFloor { get; set; }
                        public class QueryActivityItemsResponseBodyModuleFloorDisplayInfosFloorSubTitlesSubFloor : TeaModel {
                            [NameInMap("Icon")]
                            [Validation(Required=false)]
                            public string Icon { get; set; }

                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            [NameInMap("Title")]
                            [Validation(Required=false)]
                            public string Title { get; set; }

                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                    }

                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

            }

            [NameInMap("FloorItems")]
            [Validation(Required=false)]
            public string FloorItems { get; set; }

        }

    }

}
