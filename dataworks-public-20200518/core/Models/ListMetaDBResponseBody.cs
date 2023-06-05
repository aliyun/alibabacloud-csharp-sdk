// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListMetaDBResponseBody : TeaModel {
        /// <summary>
        /// The list of metadatabases.
        /// </summary>
        [NameInMap("DatabaseInfo")]
        [Validation(Required=false)]
        public ListMetaDBResponseBodyDatabaseInfo DatabaseInfo { get; set; }
        public class ListMetaDBResponseBodyDatabaseInfo : TeaModel {
            /// <summary>
            /// The timestamp at which the metadatabase was created. You can convert the timestamp to the related date based on the time zone that you use.
            /// </summary>
            [NameInMap("DbList")]
            [Validation(Required=false)]
            public List<ListMetaDBResponseBodyDatabaseInfoDbList> DbList { get; set; }
            public class ListMetaDBResponseBodyDatabaseInfoDbList : TeaModel {
                /// <summary>
                /// The timestamp at which the metadatabase was updated.
                /// </summary>
                [NameInMap("CreateTimeStamp")]
                [Validation(Required=false)]
                public long? CreateTimeStamp { get; set; }

                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// The ID of the metadatabase owner.
                /// </summary>
                [NameInMap("ModifiedTimeStamp")]
                [Validation(Required=false)]
                public long? ModifiedTimeStamp { get; set; }

                /// <summary>
                /// The URL of the metadatabase.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public string OwnerId { get; set; }

                /// <summary>
                /// The universally unique identifier (UUID) of the metadatabase.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The name of the metadatabase.
                /// </summary>
                [NameInMap("UUID")]
                [Validation(Required=false)]
                public string UUID { get; set; }

            }

            /// <summary>
            /// The type of the metadatabase.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// The total number of the metadatabases.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
