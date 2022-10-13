// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListTableLevelResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TableLevelInfo")]
        [Validation(Required=false)]
        public ListTableLevelResponseBodyTableLevelInfo TableLevelInfo { get; set; }
        public class ListTableLevelResponseBodyTableLevelInfo : TeaModel {
            [NameInMap("LevelList")]
            [Validation(Required=false)]
            public List<ListTableLevelResponseBodyTableLevelInfoLevelList> LevelList { get; set; }
            public class ListTableLevelResponseBodyTableLevelInfoLevelList : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("LevelId")]
                [Validation(Required=false)]
                public long? LevelId { get; set; }

                [NameInMap("LevelType")]
                [Validation(Required=false)]
                public int? LevelType { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

            }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

    }

}
