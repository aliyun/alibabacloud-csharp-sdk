// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class OpenReservedCapacity : TeaModel {
        /// <summary>
        /// createdTime
        /// </summary>
        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// cu
        /// </summary>
        [NameInMap("cu")]
        [Validation(Required=false)]
        public long? Cu { get; set; }

        /// <summary>
        /// deadline
        /// </summary>
        [NameInMap("deadline")]
        [Validation(Required=false)]
        public string Deadline { get; set; }

        /// <summary>
        /// instanceId
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// isRefunded
        /// </summary>
        [NameInMap("isRefunded")]
        [Validation(Required=false)]
        public string IsRefunded { get; set; }

        /// <summary>
        /// lastModifiedTime
        /// </summary>
        [NameInMap("lastModifiedTime")]
        [Validation(Required=false)]
        public string LastModifiedTime { get; set; }

    }

}
