// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class MnsTopicTriggerConfig : TeaModel {
        /// <summary>
        /// filterTag
        /// </summary>
        [NameInMap("filterTag")]
        [Validation(Required=false)]
        public string FilterTag { get; set; }

        /// <summary>
        /// notifyContentFormat
        /// </summary>
        [NameInMap("notifyContentFormat")]
        [Validation(Required=false)]
        public string NotifyContentFormat { get; set; }

        /// <summary>
        /// notifyStrategy
        /// </summary>
        [NameInMap("notifyStrategy")]
        [Validation(Required=false)]
        public string NotifyStrategy { get; set; }

    }

}
