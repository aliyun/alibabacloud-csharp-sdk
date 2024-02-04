// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ModifyInstanceNodeNumRequest : TeaModel {
        /// <summary>
        /// Specifies whether to perform only a dry run for the request. Default value: false. Valid values:
        /// - true: Only a dry-run request is sent and the number of nodes in the instance is not modified. If the dry run succeeds, DryRunResult=true is returned. If the dry run fails, an error code is returned.
        /// - false: The actual request is sent and no dry run is performed. The number of nodes is changed if the requirements are met. By default, the DryRunResult parameter returns false if you set DryRun to false.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The ID of the OceanBase cluster.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The number of nodes in the cluster. If the cluster is deployed in n-n-n mode, the number of nodes in the cluster equals n × 3.
        /// </summary>
        [NameInMap("NodeNum")]
        [Validation(Required=false)]
        public string NodeNum { get; set; }

    }

}
