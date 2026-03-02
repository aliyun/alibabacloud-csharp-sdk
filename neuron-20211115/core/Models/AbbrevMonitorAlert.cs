// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class AbbrevMonitorAlert : TeaModel {
        [NameInMap("abbrevMonitorAlertRules")]
        [Validation(Required=false)]
        public List<AbbrevMonitorAlertRule> AbbrevMonitorAlertRules { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OR</para>
        /// </summary>
        [NameInMap("condition")]
        [Validation(Required=false)]
        public string Condition { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TEST</para>
        /// </summary>
        [NameInMap("env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-08-24T00:00:00.000Z</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-08-24T00:00:00.000Z</para>
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("monitorNotifyStrategy")]
        [Validation(Required=false)]
        public MonitorNotifyStrategy MonitorNotifyStrategy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>报警任务1</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("pbcId")]
        [Validation(Required=false)]
        public string PbcId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>测试任务</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("serviceGroupId")]
        [Validation(Required=false)]
        public string ServiceGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ARMS</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
