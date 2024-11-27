// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListAuthorizedDatabasesForUserResponseBody : TeaModel {
        [NameInMap("Databases")]
        [Validation(Required=false)]
        public List<ListAuthorizedDatabasesForUserResponseBodyDatabases> Databases { get; set; }
        public class ListAuthorizedDatabasesForUserResponseBodyDatabases : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>254****</para>
            /// </summary>
            [NameInMap("DbId")]
            [Validation(Required=false)]
            public string DbId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MYSQL</para>
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>product</para>
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>235****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Logic")]
            [Validation(Required=false)]
            public bool? Logic { get; set; }

            [NameInMap("PermissionDetail")]
            [Validation(Required=false)]
            public ListAuthorizedDatabasesForUserResponseBodyDatabasesPermissionDetail PermissionDetail { get; set; }
            public class ListAuthorizedDatabasesForUserResponseBodyDatabasesPermissionDetail : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>DATABASE</para>
                /// </summary>
                [NameInMap("DsType")]
                [Validation(Required=false)]
                public string DsType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-12-06 10:00:00</para>
                /// </summary>
                [NameInMap("ExpireDate")]
                [Validation(Required=false)]
                public string ExpireDate { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CORRECT</para>
                /// </summary>
                [NameInMap("PermType")]
                [Validation(Required=false)]
                public string PermType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>poc_testdb</para>
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>poc</para>
            /// </summary>
            [NameInMap("SearchName")]
            [Validation(Required=false)]
            public string SearchName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>51****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>012AE0B5-4B52-532F-BD7C-1EE9F182089B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
