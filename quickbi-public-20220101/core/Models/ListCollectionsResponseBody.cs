// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListCollectionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>162A632E-0A88-51CF-98F8-94FDEE82DB7D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListCollectionsResponseBodyResult> Result { get; set; }
        public class ListCollectionsResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>12373</para>
            /// </summary>
            [NameInMap("FavoriteId")]
            [Validation(Required=false)]
            public int? FavoriteId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>fe67f61a35a94b7da1a34ba174a7****</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>95296e95-ca89-4c7d-8af9-dedf0ad0****</para>
            /// </summary>
            [NameInMap("WorksId")]
            [Validation(Required=false)]
            public string WorksId { get; set; }

            [NameInMap("WorksName")]
            [Validation(Required=false)]
            public string WorksName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dashboardOfflineQuery</para>
            /// </summary>
            [NameInMap("WorksType")]
            [Validation(Required=false)]
            public string WorksType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>9337d121-a78f-4c1b-a8bc-f81de117****</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

            [NameInMap("WorkspaceName")]
            [Validation(Required=false)]
            public string WorkspaceName { get; set; }

        }

        /// <summary>
        /// <para>The primary key ID of the favorite record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
