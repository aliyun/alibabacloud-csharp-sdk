// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class DeleteEventStreamingRequest : TeaModel {
        /// <summary>
        /// <para>The name of the event stream to delete.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rocketmq-sync</para>
        /// </summary>
        [NameInMap("EventStreamingName")]
        [Validation(Required=false)]
        public string EventStreamingName { get; set; }

        /// <summary>
        /// <para>Specifies whether to force delete the event stream. If set to true, system label-based deletion protection is bypassed. Default value: false.</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

    }

}
