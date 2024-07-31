// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgRunSensIdentifyRequest : TeaModel {
        /// <summary>
        /// The parameters that you need to configure to scan specified metadata.
        /// </summary>
        [NameInMap("EsMetaParams")]
        [Validation(Required=false)]
        public List<DsgRunSensIdentifyRequestEsMetaParams> EsMetaParams { get; set; }
        public class DsgRunSensIdentifyRequestEsMetaParams : TeaModel {
            /// <summary>
            /// The cluster ID. You can obtain the ID based on the data source you use.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The type of the data source. Valid values:
            /// 
            /// *   ODPS.ODPS
            /// *   EMR
            /// *   HOLO.POSTGRES
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// The instance ID. You can obtain the ID based on the data source you use.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            /// <summary>
            /// The name of the DataWorks workspace. You can log on to the [DataWorks console](https://workbench.data.aliyun.com/console) and go to the Workspace page to query the name.
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
            /// The name of the table.
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// The names of the tables.
            /// </summary>
            [NameInMap("TableNameList")]
            [Validation(Required=false)]
            public List<string> TableNameList { get; set; }

            /// <summary>
            /// The username of the operator. We recommend that you enter the username of your Alibaba Cloud account.
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

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
