// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class ListDatabasesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of databases.</para>
        /// </summary>
        [NameInMap("DatabaseList")]
        [Validation(Required=false)]
        public List<ListDatabasesResponseBodyDatabaseList> DatabaseList { get; set; }
        public class ListDatabasesResponseBodyDatabaseList : TeaModel {
            /// <summary>
            /// <para>Indicates whether the table is a foreign table. \<c>true\\</c>: The table is a foreign table. \<c>false\\</c>: The table is not a foreign table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("External")]
            [Validation(Required=false)]
            public bool? External { get; set; }

            /// <summary>
            /// <para>The database name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my_db</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The permission model. For more information, see <a href="https://help.aliyun.com/document_detail/198734.html">Hologres permission models</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SPM</para>
            /// </summary>
            [NameInMap("PermissionModel")]
            [Validation(Required=false)]
            public string PermissionModel { get; set; }

            /// <summary>
            /// <para>The permission.</para>
            /// 
            /// <b>Example:</b>
            /// <para>developer</para>
            /// </summary>
            [NameInMap("Privilege")]
            [Validation(Required=false)]
            public string Privilege { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0C4935F5-6217-569A-902F-931B2F3E28BA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
