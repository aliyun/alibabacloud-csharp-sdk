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
        /// <para>The event filtering rule. If this parameter is not specified, all events are matched.</para>
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

        /// <summary>
        /// <para>The common JSON configurations for the event provider. This parameter is mutually exclusive with the Source parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key&quot;:&quot;value&quot;}</para>
        /// </summary>
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
        /// <para>The event target. You must select one and only one sink.</para>
        /// </summary>
        [NameInMap("Sink")]
        [Validation(Required=false)]
        public string SinkShrink { get; set; }

        /// <summary>
        /// <para>The event provider. You must specify exactly one source.</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string SourceShrink { get; set; }

        /// <summary>
        /// <para>The list of tags. You can specify up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateEventStreamingShrinkRequestTags> Tags { get; set; }
        public class CreateEventStreamingShrinkRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prod</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The transform configurations.</para>
        /// </summary>
        [NameInMap("Transforms")]
        [Validation(Required=false)]
        public string TransformsShrink { get; set; }

    }

}
