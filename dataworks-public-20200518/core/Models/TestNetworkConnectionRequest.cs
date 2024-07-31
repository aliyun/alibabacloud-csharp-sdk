// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class TestNetworkConnectionRequest : TeaModel {
        /// <summary>
        /// The name of the data source.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DatasourceName")]
        [Validation(Required=false)]
        public string DatasourceName { get; set; }

        /// <summary>
        /// The environment in which the data source resides. Valid values:
        /// 
        /// *   0: development environment
        /// *   1: production environment
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// The ID of the DataWorks workspace to which the data sources belong. You can call the [ListProjects](https://help.aliyun.com/document_detail/178393.html) operation to query the ID of the workspace.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The identifier of the resource group. You can call the [ListResourceGroups](https://help.aliyun.com/document_detail/173913.html) operation to query the identifier of the resource group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceGroup")]
        [Validation(Required=false)]
        public string ResourceGroup { get; set; }

    }

}
