// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class MonitorNotifyStrategy : TeaModel {
        [NameInMap("channels")]
        [Validation(Required=false)]
        public List<string> Channels { get; set; }

        [NameInMap("contactGroupIds")]
        [Validation(Required=false)]
        public List<long?> ContactGroupIds { get; set; }

        [NameInMap("contactGroups")]
        [Validation(Required=false)]
        public List<MonitorContactGroup> ContactGroups { get; set; }

        [NameInMap("contactIds")]
        [Validation(Required=false)]
        public List<long?> ContactIds { get; set; }

        [NameInMap("contacts")]
        [Validation(Required=false)]
        public List<MonitorContact> Contacts { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1439</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>告警策略1</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>00:00</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("webhookIds")]
        [Validation(Required=false)]
        public List<long?> WebhookIds { get; set; }

        [NameInMap("webhooks")]
        [Validation(Required=false)]
        public List<MonitorWebhook> Webhooks { get; set; }

    }

}
