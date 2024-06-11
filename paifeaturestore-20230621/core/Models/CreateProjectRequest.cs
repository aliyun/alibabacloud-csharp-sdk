// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class CreateProjectRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("OfflineDatasourceId")]
        [Validation(Required=false)]
        public string OfflineDatasourceId { get; set; }

        [NameInMap("OfflineLifeCycle")]
        [Validation(Required=false)]
        public int? OfflineLifeCycle { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("OnlineDatasourceId")]
        [Validation(Required=false)]
        public string OnlineDatasourceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
