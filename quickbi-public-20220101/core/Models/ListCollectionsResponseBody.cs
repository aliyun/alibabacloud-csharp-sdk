// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListCollectionsResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>162A632E-0A88-51CF-98F8-94FDEE82DB7D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Details of the list of reports favored by the user.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListCollectionsResponseBodyResult> Result { get; set; }
        public class ListCollectionsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The primary key ID of the favorite record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12373</para>
            /// </summary>
            [NameInMap("FavoriteId")]
            [Validation(Required=false)]
            public int? FavoriteId { get; set; }

            /// <summary>
            /// <para>The user ID of the work owner. This refers to the UserID in Quick BI, not the Alibaba Cloud UID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fe67f61a35a94b7da1a34ba174a7****</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// <para>The ID of the work.</para>
            /// 
            /// <b>Example:</b>
            /// <para>95296e95-ca89-4c7d-8af9-dedf0ad0****</para>
            /// </summary>
            [NameInMap("WorksId")]
            [Validation(Required=false)]
            public string WorksId { get; set; }

            /// <summary>
            /// <para>The name of the work.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("WorksName")]
            [Validation(Required=false)]
            public string WorksName { get; set; }

            /// <summary>
            /// <para>The type of the work. Possible values:</para>
            /// <list type="bullet">
            /// <item><description>DATAPRODUCT: Data Portal</description></item>
            /// <item><description>PAGE: Dashboard</description></item>
            /// <item><description>REPORT: Spreadsheet</description></item>
            /// <item><description>dataForm: Data Entry Form</description></item>
            /// <item><description>dashboardOfflineQuery: Self-service Data Extraction</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>dashboardOfflineQuery</para>
            /// </summary>
            [NameInMap("WorksType")]
            [Validation(Required=false)]
            public string WorksType { get; set; }

            /// <summary>
            /// <para>Workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9337d121-a78f-4c1b-a8bc-f81de117****</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

            /// <summary>
            /// <para>Workspace Name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
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
