// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDIJobRequest : TeaModel {
        /// <summary>
        /// The ID of the synchronization task.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DIJobId")]
        [Validation(Required=false)]
        public long? DIJobId { get; set; }

        /// <summary>
        /// Specifies whether to return detailed configuration information, including TransformationRules, TableMappings, and JobSettings. Valid values: true and false. Default value: true.
        /// </summary>
        [NameInMap("WithDetails")]
        [Validation(Required=false)]
        public bool? WithDetails { get; set; }

    }

}
