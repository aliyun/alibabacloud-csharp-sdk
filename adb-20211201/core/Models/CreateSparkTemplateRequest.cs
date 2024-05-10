// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CreateSparkTemplateRequest : TeaModel {
        /// <summary>
        /// The application type. Valid values:
        /// 
        /// *   **SQL**
        /// *   **STREAMING**
        /// *   **BATCH**
        /// 
        /// >  You do not need to specify this parameter when Type is set to folder.
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The name of the application template. The name can be up to 64 characters in length.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the directory to which the application template belongs.
        /// 
        /// >  You can call the [GetSparkTemplateFolderTree](https://help.aliyun.com/document_detail/456218.html) operation to query the directory ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public long? ParentId { get; set; }

        /// <summary>
        /// The type of the application template. Valid values:
        /// 
        /// *   **folder**: directory.
        /// *   **file**: application.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
