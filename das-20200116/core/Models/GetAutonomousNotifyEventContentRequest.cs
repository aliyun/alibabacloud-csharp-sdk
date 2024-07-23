// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetAutonomousNotifyEventContentRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-18ff4a195d****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The unique identifier of the event. You can call the <a href="https://help.aliyun.com/document_detail/288371.html">GetAutonomousNotifyEventsInRange</a> operation to query the unique identifier returned by the SpanId response parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7e7b2774-95b8-4fa3-bd9c-0ab47cb7****</para>
        /// </summary>
        [NameInMap("SpanId")]
        [Validation(Required=false)]
        public string SpanId { get; set; }

        /// <summary>
        /// <para>The reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("__context")]
        [Validation(Required=false)]
        public string Context { get; set; }

    }

}
