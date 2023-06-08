// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class ListFCTriggerRequest : TeaModel {
        /// <summary>
        /// The name of the event. You can specify only one name.
        /// </summary>
        [NameInMap("EventMetaName")]
        [Validation(Required=false)]
        public string EventMetaName { get; set; }

        /// <summary>
        /// The version number of the event. You can specify only one version number.
        /// </summary>
        [NameInMap("EventMetaVersion")]
        [Validation(Required=false)]
        public string EventMetaVersion { get; set; }

    }

}
