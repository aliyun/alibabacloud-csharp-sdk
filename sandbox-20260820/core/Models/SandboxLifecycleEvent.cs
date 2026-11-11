// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class SandboxLifecycleEvent : TeaModel {
        /// <summary>
        /// <para>The action that triggered the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>delete</para>
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <para>The template build ID. This field is not returned if there is no associated build.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bld-example-001</para>
        /// </summary>
        [NameInMap("buildID")]
        [Validation(Required=false)]
        public string BuildID { get; set; }

        /// <summary>
        /// <para>The event description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sandbox deleted</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The event data as a JSON object. The specific fields vary depending on the event type.</para>
        /// </summary>
        [NameInMap("eventData")]
        [Validation(Required=false)]
        public Dictionary<string, object> EventData { get; set; }

        /// <summary>
        /// <para>The event ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>df3c6750-2c5e-50d1-8b81-7a2248f6ca3b</para>
        /// </summary>
        [NameInMap("eventID")]
        [Validation(Required=false)]
        public string EventID { get; set; }

        /// <summary>
        /// <para>The event type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>terminated</para>
        /// </summary>
        [NameInMap("eventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>The event category. Valid values: INFO and WARNING.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INFO</para>
        /// </summary>
        [NameInMap("level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// <para>The time when the event occurred. The time is in UTC RFC3339 format and supports fractional seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-08T06:18:38.123Z</para>
        /// </summary>
        [NameInMap("occurredAt")]
        [Validation(Required=false)]
        public string OccurredAt { get; set; }

        /// <summary>
        /// <para>The reason for the event. This field is not returned if there is no reason.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request</para>
        /// </summary>
        [NameInMap("reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sbx-62105527-699e-48df-ad3b-7425001ae4f2</para>
        /// </summary>
        [NameInMap("sandboxID")]
        [Validation(Required=false)]
        public string SandboxID { get; set; }

        /// <summary>
        /// <para>The ID of the team to which the event belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70d1c834-0333-58d8-97ac-5336eb9179eb</para>
        /// </summary>
        [NameInMap("teamID")]
        [Validation(Required=false)]
        public string TeamID { get; set; }

        /// <summary>
        /// <para>The template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4hrtmghh2nzrsdh6yr65</para>
        /// </summary>
        [NameInMap("templateID")]
        [Validation(Required=false)]
        public string TemplateID { get; set; }

    }

}
