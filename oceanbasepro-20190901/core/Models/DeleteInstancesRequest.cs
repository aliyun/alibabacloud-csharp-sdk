// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DeleteInstancesRequest : TeaModel {
        /// <summary>
        /// The backup retention strategy for cluster deletion. Valid values:  
        /// - receive_all: retains all backup sets.   
        /// - delete_all: deletes all backup sets.   
        /// - receive_last: retains the last backup set.    
        /// 
        /// > <br>Default value: delete_all.
        /// </summary>
        [NameInMap("BackupRetainMode")]
        [Validation(Required=false)]
        public string BackupRetainMode { get; set; }

        /// <summary>
        /// Specifies whether to perform only a dry run for the request. Default value: false. Valid values:
        /// - true: Only a dry-run request is sent and the instance is not deleted. If the dry run succeeds, DryRunResult=true is returned. If the dry run fails, an error code is returned.
        /// - false: The actual request is sent and no dry run is performed. The instance is deleted if the requirements are met. By default, false is returned for the parameter DryRunResult if you set DryRun to false.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The ID of the cluster to be deleted.   
        /// The value is a string in the JSON format.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

    }

}
