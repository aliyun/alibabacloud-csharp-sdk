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
        /// <para>The event filtering rule. If not specified, all events are matched.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        /// &quot;source&quot;: [
        /// {
        /// &quot;prefix&quot;: &quot;acs:mns&quot;
        /// }
        /// ],
        /// &quot;type&quot;: [
        /// {
        /// &quot;prefix&quot;: &quot;mns:Queue&quot;
        /// }
        /// ],
        /// &quot;subject&quot;: [
        /// {
        /// &quot;prefix&quot;: &quot;acs:mns:cn-hangzhou:123456789098****:queues/zeus&quot;
        /// }
        /// ]
        /// }</para>
        /// </summary>
        [NameInMap("FilterPattern")]
        [Validation(Required=false)]
        public string FilterPattern { get; set; }

        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public string Metadata { get; set; }

        /// <summary>
        /// <para>The runtime environment parameters.</para>
        /// </summary>
        [NameInMap("RunOptions")]
        [Validation(Required=false)]
        public string RunOptionsShrink { get; set; }

        /// <summary>
        /// <para>The event target. You must select exactly one Sink type.</para>
        /// </summary>
        [NameInMap("Sink")]
        [Validation(Required=false)]
        public string SinkShrink { get; set; }

        /// <summary>
        /// <para>The event provider. You must select exactly one Source type.</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string SourceShrink { get; set; }

        /// <summary>
        /// <para>The tag list. A maximum of 20 items are supported.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateEventStreamingShrinkRequestTags> Tags { get; set; }
        public class CreateEventStreamingShrinkRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The Transform-related configurations.</para>
        /// </summary>
        [NameInMap("Transforms")]
        [Validation(Required=false)]
        public string TransformsShrink { get; set; }

    }

}
