// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DeleteSparkTemplateRequest : TeaModel {
        /// <summary>
        /// The ID of the AnalyticDB for MySQL Data Lakehouse Edition cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The directory ID of the template files that you want to delete.
        /// 
        /// > 
        /// 
        /// *   You can call the [GetSparkTemplateFullTree](https://help.aliyun.com/document_detail/456205.html) operation to query the directory ID of template files.
        /// 
        /// *   When you specify a directory ID, the directory and all template files that are included in the directory are deleted.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

    }

}
