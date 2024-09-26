// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDataServiceFolderResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the folder.</para>
        /// </summary>
        [NameInMap("Folder")]
        [Validation(Required=false)]
        public GetDataServiceFolderResponseBodyFolder Folder { get; set; }
        public class GetDataServiceFolderResponseBodyFolder : TeaModel {
            /// <summary>
            /// <para>The time when the folder was created.</para>
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
            /// <para>The name of the folder.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test1</para>
            /// </summary>
            [NameInMap("FolderName")]
            [Validation(Required=false)]
            public string FolderName { get; set; }

            /// <summary>
            /// <para>The ID of the business process to which the folder belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds_1234</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The time when the folder was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-09-24T18:37:51+0800</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The parent folder ID. The ID of the root folder in a business process is 0, and the ID of a folder created by a user in a business process is greater than 0.</para>
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
