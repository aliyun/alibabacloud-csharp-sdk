// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ImportDataSourcesRequest : TeaModel {
        /// <summary>
        /// The configurations of the data sources to be imported. The Name, DataSourceType, SubType, Description, Content, and EnvType fields are required. For more information about the fields, see [CreateDataSource](~~211429~~).
        /// </summary>
        [NameInMap("DataSources")]
        [Validation(Required=false)]
        public string DataSources { get; set; }

        /// <summary>
        /// The ID of the DataWorks workspace. You can log on to the [DataWorks console](https://workbench.data.aliyun.com/console) and go to the Workspace Management page to obtain the workspace ID.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
