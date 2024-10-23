// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class MNSTopicTriggerConfig : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>serverless</para>
        /// </summary>
        [NameInMap("filterTag")]
        [Validation(Required=false)]
        public string FilterTag { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>JSON</para>
        /// </summary>
        [NameInMap("notifyContentFormat")]
        [Validation(Required=false)]
        public string NotifyContentFormat { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BACKOFF_RETRY</para>
        /// </summary>
        [NameInMap("notifyStrategy")]
        [Validation(Required=false)]
        public string NotifyStrategy { get; set; }

    }

}
