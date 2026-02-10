// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListRemoteADBDataSourcesResponseBody : TeaModel {
        [NameInMap("DataSourceItems")]
        [Validation(Required=false)]
        public ListRemoteADBDataSourcesResponseBodyDataSourceItems DataSourceItems { get; set; }
        public class ListRemoteADBDataSourcesResponseBodyDataSourceItems : TeaModel {
            [NameInMap("RemoteDataSources")]
            [Validation(Required=false)]
            public List<ListRemoteADBDataSourcesResponseBodyDataSourceItemsRemoteDataSources> RemoteDataSources { get; set; }
            public class ListRemoteADBDataSourcesResponseBodyDataSourceItemsRemoteDataSources : TeaModel {
                [NameInMap("DataSourceName")]
                [Validation(Required=false)]
                public string DataSourceName { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("LocalDatabase")]
                [Validation(Required=false)]
                public string LocalDatabase { get; set; }

                [NameInMap("LocalInstanceName")]
                [Validation(Required=false)]
                public string LocalInstanceName { get; set; }

                [NameInMap("ManagerUserName")]
                [Validation(Required=false)]
                public string ManagerUserName { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("RemoteDatabase")]
                [Validation(Required=false)]
                public string RemoteDatabase { get; set; }

                [NameInMap("RemoteInstanceName")]
                [Validation(Required=false)]
                public string RemoteInstanceName { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e9d60eb1-e90d-4bc6-a470-c8b767460858</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90000</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public int? TaskId { get; set; }

    }

}
