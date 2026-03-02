// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class AbbrevMonitorAlertRule : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-06-11T00:00:00.000Z</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>规则1</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>最近5分钟节点机CPU使用率平均大于等于90%</para>
        /// </summary>
        [NameInMap("triggerContent")]
        [Validation(Required=false)]
        public string TriggerContent { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("triggerRule")]
        [Validation(Required=false)]
        public string TriggerRule { get; set; }

    }

}
