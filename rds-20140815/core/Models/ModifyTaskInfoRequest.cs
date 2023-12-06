// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyTaskInfoRequest : TeaModel {
        /// <summary>
        /// Action params.
        /// </summary>
        [NameInMap("ActionParams")]
        [Validation(Required=false)]
        public string ActionParams { get; set; }

        /// <summary>
        /// The region ID. You can call the DescribeRegions operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public long? ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// Step name.
        /// </summary>
        [NameInMap("StepName")]
        [Validation(Required=false)]
        public string StepName { get; set; }

        /// <summary>
        /// The name of the operation that generates the task. Valid values:
        /// 
        /// *   ImportImage
        /// *   ExportImage
        /// *   RedeployInstance
        /// *   ModifyDiskSpec
        /// </summary>
        [NameInMap("TaskAction")]
        [Validation(Required=false)]
        public string TaskAction { get; set; }

        /// <summary>
        /// The task ID.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
