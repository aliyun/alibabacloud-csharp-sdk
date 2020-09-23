// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListTableLevelResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=true)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=true)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("TableLevelInfo")]
        [Validation(Required=true)]
        public ListTableLevelResponseTableLevelInfo TableLevelInfo { get; set; }
        public class ListTableLevelResponseTableLevelInfo : TeaModel {
            [NameInMap("TotalCount")]
            [Validation(Required=true)]
            public long TotalCount { get; set; }
            [NameInMap("LevelList")]
            [Validation(Required=true)]
            public List<ListTableLevelResponseTableLevelInfoLevelList> LevelList { get; set; }
            public class ListTableLevelResponseTableLevelInfoLevelList : TeaModel {
                public long LevelId { get; set; }
                public string Name { get; set; }
                public long ProjectId { get; set; }
                public int? LevelType { get; set; }
                public string Description { get; set; }
            }
        };

    }

}
