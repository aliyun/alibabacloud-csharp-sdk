// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListMetaDBResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the metadatabases.</para>
        /// </summary>
        [NameInMap("DatabaseInfo")]
        [Validation(Required=false)]
        public ListMetaDBResponseBodyDatabaseInfo DatabaseInfo { get; set; }
        public class ListMetaDBResponseBodyDatabaseInfo : TeaModel {
            /// <summary>
            /// <para>The metadatabases.</para>
            /// </summary>
            [NameInMap("DbList")]
            [Validation(Required=false)]
            public List<ListMetaDBResponseBodyDatabaseInfoDbList> DbList { get; set; }
            public class ListMetaDBResponseBodyDatabaseInfoDbList : TeaModel {
                /// <summary>
                /// <para>The timestamp at which the metadatabase was created. You can convert the timestamp to the date based on the time zone that you use.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1388776825</para>
                /// </summary>
                [NameInMap("CreateTimeStamp")]
                [Validation(Required=false)]
                public long? CreateTimeStamp { get; set; }

                /// <summary>
                /// <para>The URL of the metadatabase.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hdfs://localhost:777/user/hadoop/test.txt</para>
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// <para>The timestamp at which the metadatabase was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1388776837</para>
                /// </summary>
                [NameInMap("ModifiedTimeStamp")]
                [Validation(Required=false)]
                public long? ModifiedTimeStamp { get; set; }

                /// <summary>
                /// <para>The name of the metadatabase.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The owner ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1232</para>
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public string OwnerId { get; set; }

                /// <summary>
                /// <para>The type of the metadatabase.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HIVE</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The UUID of the metadatabase.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32342</para>
                /// </summary>
                [NameInMap("UUID")]
                [Validation(Required=false)]
                public string UUID { get; set; }

            }

            /// <summary>
            /// <para>The total number of the metadatabases returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
