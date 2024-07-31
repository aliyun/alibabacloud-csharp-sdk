// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgQuerySensResultRequest : TeaModel {
        /// <summary>
        /// The name of the field.
        /// </summary>
        [NameInMap("Col")]
        [Validation(Required=false)]
        public string Col { get; set; }

        /// <summary>
        /// The type of the database. Valid values:
        /// 
        /// *   **ODPS.ODPS**
        /// *   **HOLO.POSTGRES**
        /// *   **EMR**
        /// </summary>
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        /// <summary>
        /// The sensitivity level of the field.
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// The name of a data category.
        /// </summary>
        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        /// <summary>
        /// The sorting method.
        /// 
        /// *   DESC
        /// *   ASC
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// The field used for sorting.
        /// 
        /// *   gmt_create
        /// *   gmt_modified
        /// </summary>
        [NameInMap("OrderField")]
        [Validation(Required=false)]
        public string OrderField { get; set; }

        /// <summary>
        /// The page number. Pages start from page 1.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 10. Maximum value: 20.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The name of the DataWorks workspace. You can log on to the [DataWorks console](https://workbench.data.aliyun.com/console) and go to the Workspace page to obtain the workspace name.
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// The name of the schema.
        /// </summary>
        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        /// <summary>
        /// The sensitivity status of the field.
        /// 
        /// *   1: indicates sensitive.
        /// *   \\-1: indicates non-sensitive.
        /// </summary>
        [NameInMap("SensStatus")]
        [Validation(Required=false)]
        public string SensStatus { get; set; }

        /// <summary>
        /// The sensitive field ID.
        /// </summary>
        [NameInMap("SensitiveId")]
        [Validation(Required=false)]
        public string SensitiveId { get; set; }

        /// <summary>
        /// The name of the sensitive field.
        /// </summary>
        [NameInMap("SensitiveName")]
        [Validation(Required=false)]
        public string SensitiveName { get; set; }

        /// <summary>
        /// The name of the table.
        /// </summary>
        [NameInMap("Table")]
        [Validation(Required=false)]
        public string Table { get; set; }

        /// <summary>
        /// The tenant ID. To obtain the tenant ID, perform the following steps: Log on to the [DataWorks console](https://workbench.data.aliyun.com/console). Find your workspace and go to the DataStudio page. On the DataStudio page, click the logon username in the upper-right corner and click User Info in the Menu section.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
