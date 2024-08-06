// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class SubmitSparkAppRequest : TeaModel {
        /// <summary>
        /// The type of the client. The value can be up to 64 characters in length.
        /// </summary>
        [NameInMap("AgentSource")]
        [Validation(Required=false)]
        public string AgentSource { get; set; }

        /// <summary>
        /// The version of the client. The value can be up to 64 characters in length.
        /// </summary>
        [NameInMap("AgentVersion")]
        [Validation(Required=false)]
        public string AgentVersion { get; set; }

        /// <summary>
        /// The name of the application. The value can be up to 64 characters in length.
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// The type of the application. Valid values:
        /// 
        /// *   **SQL**
        /// *   **STREAMING**
        /// *   **BATCH** (default)
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// The ID of the AnalyticDB for MySQL Data Lakehouse Edition cluster.
        /// 
        /// >  You can call the [DescribeDBClusters](https://help.aliyun.com/document_detail/454250.html) operation to query the IDs of all AnalyticDB for MySQL clusters within a region.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The data of the application template.
        /// 
        /// > For information about the application template configuration, see [Spark application configuration guide](https://help.aliyun.com/document_detail/452402.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// The name of the job resource group.
        /// 
        /// >  You can call the [DescribeDBResourceGroup](https://help.aliyun.com/document_detail/612410.html) operation to query the name of a resource group within a cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceGroupName")]
        [Validation(Required=false)]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// The ID of the application template.
        /// 
        /// > You can call the [GetSparkTemplateFullTree](https://help.aliyun.com/document_detail/456205.html) operation to query the application template ID.
        /// </summary>
        [NameInMap("TemplateFileId")]
        [Validation(Required=false)]
        public long? TemplateFileId { get; set; }

    }

}
