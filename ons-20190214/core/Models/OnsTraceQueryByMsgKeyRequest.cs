// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsTraceQueryByMsgKeyRequest : TeaModel {
        /// <summary>
        /// <para>The start of the time range to query. The value of this parameter is a UNIX timestamp in milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1570852800000</para>
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The value of this parameter is a UNIX timestamp in milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1570968000000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the ApsaraMQ for RocketMQ instance that contains the specified topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MQ_INST_111111111111_DOxxxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The key of the message that you want to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ORDERID_100</para>
        /// </summary>
        [NameInMap("MsgKey")]
        [Validation(Required=false)]
        public string MsgKey { get; set; }

        /// <summary>
        /// <para>The topic that contains the message you want to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
