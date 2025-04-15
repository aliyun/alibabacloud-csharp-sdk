// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class CreateEventStreamingShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The description of the event stream.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rocketmq2mns</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the event stream.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myeventstreaming</para>
        /// </summary>
        [NameInMap("EventStreamingName")]
        [Validation(Required=false)]
        public string EventStreamingName { get; set; }

        /// <summary>
        /// <para>The rule that is used to filter events. If you leave this parameter empty, all events are matched.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("FilterPattern")]
        [Validation(Required=false)]
        public string FilterPattern { get; set; }

        /// <summary>
        /// <para>The configurations of the runtime environment.</para>
        /// </summary>
        [NameInMap("RunOptions")]
        [Validation(Required=false)]
        public string RunOptionsShrink { get; set; }

        /// <summary>
        /// <para>The event target. You must and can specify only one event target.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Sink")]
        [Validation(Required=false)]
        public string SinkShrink { get; set; }

        /// <summary>
        /// <para>The event provider, which is also known as the event source. You must and can specify only one event source.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string SourceShrink { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateEventStreamingShrinkRequestTags> Tags { get; set; }
        public class CreateEventStreamingShrinkRequestTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Transforms")]
        [Validation(Required=false)]
        public string TransformsShrink { get; set; }

    }

}
