// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeServcieScheduleRequest : TeaModel {
        /// <summary>
        /// The ID of the application.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// This parameter does not take effect.
        /// </summary>
        [NameInMap("PodConfigName")]
        [Validation(Required=false)]
        public string PodConfigName { get; set; }

        /// <summary>
        /// The UUID of the device.
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
