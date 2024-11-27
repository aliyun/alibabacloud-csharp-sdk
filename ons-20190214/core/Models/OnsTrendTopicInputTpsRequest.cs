// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsTrendTopicInputTpsRequest : TeaModel {
        /// <summary>
        /// <para>The timestamp that indicates the beginning of the time range to query. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1570852800000</para>
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// <para>The timestamp that indicates the end of the time range to query. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1570868400000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the instance to which the topic you want to query belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MQ_INST_111111111111_DOxxxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The sampling period. Unit: minutes. Valid values: 1, 5, and 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public long? Period { get; set; }

        /// <summary>
        /// <para>The name of the topic that you want to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

        /// <summary>
        /// <para>The type of information that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: the number of messages that are published to the topic during each sampling period.</description></item>
        /// <item><description><b>1</b>: the TPS for message publishing in the topic during each sampling period.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
