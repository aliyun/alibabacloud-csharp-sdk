// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class MonitorArmsAlertUpdateCmd : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OR</para>
        /// </summary>
        [NameInMap("condition")]
        [Validation(Required=false)]
        public string Condition { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("monitorArmsAlertRules")]
        [Validation(Required=false)]
        public List<MonitorArmsAlertRule> MonitorArmsAlertRules { get; set; }

        [NameInMap("monitorNotifyStrategy")]
        [Validation(Required=false)]
        public MonitorNotifyStrategy MonitorNotifyStrategy { get; set; }

    }

}
