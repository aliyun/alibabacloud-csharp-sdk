// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListMetaDBResponseBody : TeaModel {
        [NameInMap("DatabaseInfo")]
        [Validation(Required=false)]
        public ListMetaDBResponseBodyDatabaseInfo DatabaseInfo { get; set; }
        public class ListMetaDBResponseBodyDatabaseInfo : TeaModel {
            [NameInMap("DbList")]
            [Validation(Required=false)]
            public List<ListMetaDBResponseBodyDatabaseInfoDbList> DbList { get; set; }
            public class ListMetaDBResponseBodyDatabaseInfoDbList : TeaModel {
                public long? CreateTimeStamp { get; set; }
                public string Location { get; set; }
                public long? ModifiedTimeStamp { get; set; }
                public string Name { get; set; }
                public string OwnerId { get; set; }
                public string Type { get; set; }
                public string UUID { get; set; }
            }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
