// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class TestEventPatternRequest : TeaModel {
        /// <summary>
        /// The event.
        /// </summary>
        [NameInMap("Event")]
        [Validation(Required=false)]
        public string Event { get; set; }

        /// <summary>
        /// The event pattern.
        /// </summary>
        [NameInMap("EventPattern")]
        [Validation(Required=false)]
        public string EventPattern { get; set; }

    }

}
