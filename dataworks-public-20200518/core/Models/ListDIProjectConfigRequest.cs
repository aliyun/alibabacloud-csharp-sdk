// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDIProjectConfigRequest : TeaModel {
        /// <summary>
        /// The type of the destination data source of the sync solution. This parameter cannot be left empty.
        /// 
        /// Valid values: analyticdb_for_mysql, odps, elasticsearch, holo, mysql, and polardb. You can call the ListDIProjectConfig operation to query the supported types of destination data sources.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DestinationType")]
        [Validation(Required=false)]
        public string DestinationType { get; set; }

        /// <summary>
        /// The ID of the DataWorks workspace. You can log on to the [DataWorks console](https://workbench.data.aliyun.com/console) and go to the Workspace Management page to obtain the workspace ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The type of the source data source of the sync solution.
        /// 
        /// Valid values: oracle, mysql, polardb, datahub, drds, and analyticdb_for_mysql. You can call the ListDIProjectConfig operation to query the supported types of source data sources.
        /// 
        /// If you do not set this parameter, DataWorks applies the default global configuration to all the source data sources of the preceding types.
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
