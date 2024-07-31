// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ImportDataSourcesRequest : TeaModel {
        /// <summary>
        /// The configurations of the data sources that you want to import. The Name, DataSourceType, SubType, Description, Content, and EnvType parameters are required. For more information about the parameters, see [CreateDataSource](https://help.aliyun.com/document_detail/211429.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DataSources")]
        [Validation(Required=false)]
        public string DataSources { get; set; }

        /// <summary>
        /// The DataWorks workspace ID. You can log on to the [DataWorks console](https://workbench.data.aliyun.com/console) and go to the Workspace page to obtain the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
