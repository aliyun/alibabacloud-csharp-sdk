// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ModifyRemoteADBDataSourceResponseBody : TeaModel {
        /// <summary>
        /// <para>Returns the successfully modified data sharing service data.</para>
        /// </summary>
        [NameInMap("DataSourceItem")]
        [Validation(Required=false)]
        public ModifyRemoteADBDataSourceResponseBodyDataSourceItem DataSourceItem { get; set; }
        public class ModifyRemoteADBDataSourceResponseBodyDataSourceItem : TeaModel {
            /// <summary>
            /// <para>Data source name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>db1_gptest1_to_db2_gp-test2</para>
            /// </summary>
            [NameInMap("DataSourceName")]
            [Validation(Required=false)]
            public string DataSourceName { get; set; }

            /// <summary>
            /// <para>Description information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Local database name</para>
            /// 
            /// <b>Example:</b>
            /// <para>db1</para>
            /// </summary>
            [NameInMap("LocalDatabase")]
            [Validation(Required=false)]
            public string LocalDatabase { get; set; }

            /// <summary>
            /// <para>Local instance name</para>
            /// 
            /// <b>Example:</b>
            /// <para>gp-test1</para>
            /// </summary>
            [NameInMap("LocalInstanceName")]
            [Validation(Required=false)]
            public string LocalInstanceName { get; set; }

            /// <summary>
            /// <para>Manager user name</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ManagerUserName")]
            [Validation(Required=false)]
            public string ManagerUserName { get; set; }

            /// <summary>
            /// <para>Region ID where the instance is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>Remote database name</para>
            /// 
            /// <b>Example:</b>
            /// <para>db2</para>
            /// </summary>
            [NameInMap("RemoteDatabase")]
            [Validation(Required=false)]
            public string RemoteDatabase { get; set; }

            /// <summary>
            /// <para>Remote instance name</para>
            /// 
            /// <b>Example:</b>
            /// <para>gp-test2</para>
            /// </summary>
            [NameInMap("RemoteInstanceName")]
            [Validation(Required=false)]
            public string RemoteInstanceName { get; set; }

            /// <summary>
            /// <para>Data source status</para>
            /// 
            /// <b>Example:</b>
            /// <para>creating</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>User name</para>
            /// 
            /// <b>Example:</b>
            /// <para>user1</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

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
