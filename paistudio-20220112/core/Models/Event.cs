// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class Event : TeaModel {
        /// <summary>
        /// <para>The event content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The event ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eventxxx</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <para>The event type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreateQuota</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>The reserved field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Empty</para>
        /// </summary>
        [NameInMap("Function")]
        [Validation(Required=false)]
        public string Function { get; set; }

        /// <summary>
        /// <para>Indicates whether the content is truncated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// <para>Object ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>quotaxxx</para>
        /// </summary>
        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// <para>The object type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Quota</para>
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("TriggerTenantId")]
        [Validation(Required=false)]
        public string TriggerTenantId { get; set; }

        /// <summary>
        /// <para>The trigger time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("TriggerTime")]
        [Validation(Required=false)]
        public string TriggerTime { get; set; }

        /// <summary>
        /// <para>The RAM user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567</para>
        /// </summary>
        [NameInMap("TriggerUserId")]
        [Validation(Required=false)]
        public string TriggerUserId { get; set; }

        /// <summary>
        /// <para>The trigger source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>System</para>
        /// </summary>
        [NameInMap("TriggeredBy")]
        [Validation(Required=false)]
        public string TriggeredBy { get; set; }

    }

}
