// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class MonitorNotifyAlert : TeaModel {
        [NameInMap("contactGroups")]
        [Validation(Required=false)]
        public List<MonitorContactGroup> ContactGroups { get; set; }

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

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("notifyChannels")]
        [Validation(Required=false)]
        public List<string> NotifyChannels { get; set; }

        [NameInMap("ruleNames")]
        [Validation(Required=false)]
        public List<string> RuleNames { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>00:00</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>日志</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("webhooks")]
        [Validation(Required=false)]
        public List<MonitorWebhook> Webhooks { get; set; }

    }

}
