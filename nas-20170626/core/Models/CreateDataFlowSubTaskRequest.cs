// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateDataFlowSubTaskRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("Condition")]
        [Validation(Required=false)]
        public CreateDataFlowSubTaskRequestCondition Condition { get; set; }
        public class CreateDataFlowSubTaskRequestCondition : TeaModel {
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DataFlowId")]
        [Validation(Required=false)]
        public string DataFlowId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DataFlowTaskId")]
        [Validation(Required=false)]
        public string DataFlowTaskId { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DstFilePath")]
        [Validation(Required=false)]
        public string DstFilePath { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SrcFilePath")]
        [Validation(Required=false)]
        public string SrcFilePath { get; set; }

    }

}
