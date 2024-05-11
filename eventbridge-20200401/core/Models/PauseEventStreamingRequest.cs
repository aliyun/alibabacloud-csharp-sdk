// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class PauseEventStreamingRequest : TeaModel {
        /// <summary>
        /// The name of the event stream that you want to stop.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EventStreamingName")]
        [Validation(Required=false)]
        public string EventStreamingName { get; set; }

    }

}
