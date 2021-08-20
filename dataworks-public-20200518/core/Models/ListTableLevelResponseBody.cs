// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListTableLevelResponseBody : TeaModel {
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("TableLevelInfo")]
        [Validation(Required=false)]
        public ListTableLevelResponseBodyTableLevelInfo TableLevelInfo { get; set; }
        public class ListTableLevelResponseBodyTableLevelInfo : TeaModel {
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
            [NameInMap("LevelList")]
            [Validation(Required=false)]
            public List<ListTableLevelResponseBodyTableLevelInfoLevelList> LevelList { get; set; }
            public class ListTableLevelResponseBodyTableLevelInfoLevelList : TeaModel {
                public int? LevelType { get; set; }
                public string Description { get; set; }
                public string Name { get; set; }
                public long? ProjectId { get; set; }
                public long? LevelId { get; set; }
            }
        };

    }

}
