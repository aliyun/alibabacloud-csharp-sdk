// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListMetaDBResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("DatabaseInfo")]
        [Validation(Required=true)]
        public ListMetaDBResponseDatabaseInfo DatabaseInfo { get; set; }
        public class ListMetaDBResponseDatabaseInfo : TeaModel {
            [NameInMap("TotalCount")]
            [Validation(Required=true)]
            public long TotalCount { get; set; }
            [NameInMap("DbList")]
            [Validation(Required=true)]
            public List<ListMetaDBResponseDatabaseInfoDbList> DbList { get; set; }
            public class ListMetaDBResponseDatabaseInfoDbList : TeaModel {
                public string Name { get; set; }
                public string Type { get; set; }
                public string OwnerId { get; set; }
                public string Location { get; set; }
                public long CreateTimeStamp { get; set; }
                public long ModifiedTimeStamp { get; set; }
                public string UUID { get; set; }
            }
        };

    }

}
