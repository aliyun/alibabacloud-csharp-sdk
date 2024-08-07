// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class EstablishRelationTableToBusinessRequest : TeaModel {
        /// <summary>
        /// The ID of the workflow. You can call the [ListBusiness](https://help.aliyun.com/document_detail/173945.html) operation to query the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BusinessId")]
        [Validation(Required=false)]
        public string BusinessId { get; set; }

        /// <summary>
        /// The ID of the folder. You can call the [GetFolder](https://help.aliyun.com/document_detail/173952.html) or [ListFolders](https://help.aliyun.com/document_detail/173955.html) operation to query the ID.
        /// </summary>
        [NameInMap("FolderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        /// <summary>
        /// The ID of the DataWorks workspace. You can click the Workspace Manage icon in the upper-right corner of the DataStudio page to go to the Workspace Management page and view the workspace ID.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The unique identifier of the DataWorks workspace. You can click the identifier in the upper-left corner of the DataStudio page to switch to another workspace.
        /// 
        /// You must specify either this parameter or ProjectId to determine the DataWorks workspace to which the operation is applied.
        /// </summary>
        [NameInMap("ProjectIdentifier")]
        [Validation(Required=false)]
        public string ProjectIdentifier { get; set; }

        /// <summary>
        /// The universally unique identifier (UUID) of the table. You can call the [SearchMetaTables](https://help.aliyun.com/document_detail/173919.html) operation to query the UUID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TableGuid")]
        [Validation(Required=false)]
        public string TableGuid { get; set; }

    }

}
