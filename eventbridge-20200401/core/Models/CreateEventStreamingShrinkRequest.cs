// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class CreateEventStreamingShrinkRequest : TeaModel {
        /// <summary>
        /// The description of the event stream.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the event stream.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EventStreamingName")]
        [Validation(Required=false)]
        public string EventStreamingName { get; set; }

        /// <summary>
        /// The rule that is used to filter events. If you leave this parameter empty, all events are matched.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FilterPattern")]
        [Validation(Required=false)]
        public string FilterPattern { get; set; }

        /// <summary>
        /// The parameters that are configured for the runtime environment.
        /// </summary>
        [NameInMap("RunOptions")]
        [Validation(Required=false)]
        public string RunOptionsShrink { get; set; }

        /// <summary>
        /// The event target. You must and can specify only one event target.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Sink")]
        [Validation(Required=false)]
        public string SinkShrink { get; set; }

        /// <summary>
        /// The event provider, which is also known as the event source. You must and can specify only one event source.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string SourceShrink { get; set; }

        [NameInMap("Transforms")]
        [Validation(Required=false)]
        public string TransformsShrink { get; set; }

    }

}
