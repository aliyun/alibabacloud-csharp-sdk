// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDataServiceFolderResponseBody : TeaModel {
        /// <summary>
        /// <para>The folder details.</para>
        /// </summary>
        [NameInMap("Folder")]
        [Validation(Required=false)]
        public GetDataServiceFolderResponseBodyFolder Folder { get; set; }
        public class GetDataServiceFolderResponseBodyFolder : TeaModel {
            /// <summary>
            /// <para>The creation time of the folder.</para>
            /// <para>The format is <c>yyyy-MM-dd\\&quot;T\\&quot;HH:mm:ssZ</c>. Example: <c>2020-09-24T18:37:51+0800</c>. The time zone offset in this example is <c>+0800</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-09-24T18:37:51+0800</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The folder ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("FolderId")]
            [Validation(Required=false)]
            public long? FolderId { get; set; }

            /// <summary>
            /// <para>The folder name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test1</para>
            /// </summary>
            [NameInMap("FolderName")]
            [Validation(Required=false)]
            public string FolderName { get; set; }

            /// <summary>
            /// <para>The ID of the workflow to which the folder belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds_1234</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The modification time of the folder.</para>
            /// <para>The format is <c>yyyy-MM-dd\\&quot;T\\&quot;HH:mm:ssZ</c>. Example: <c>2020-09-24T18:37:51+0800</c>. The time zone offset in this example is <c>+0800</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-09-24T18:37:51+0800</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The parent folder ID. The ID of the root folder under a workflow is 0, and the ID of a user-created folder is greater than 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public long? ParentId { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The tenant ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10002</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
