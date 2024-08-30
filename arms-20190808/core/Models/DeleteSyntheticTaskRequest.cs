// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DeleteSyntheticTaskRequest : TeaModel {
        /// <summary>
        /// The region ID. Default value: cn-hangzhou.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The task IDs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskIds")]
        [Validation(Required=false)]
        public List<string> TaskIds { get; set; }

    }

}
