// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class UpdateTopicRequest : TeaModel {
        /// <summary>
        /// <para>The expiration time of a lite topic, in minutes. Valid values: 15 to 720. The default value is -1, which indicates that the topic never expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("liteTopicExpiration")]
        [Validation(Required=false)]
        public long? LiteTopicExpiration { get; set; }

        /// <summary>
        /// <para>The maximum number of transactions per second (TPS) for sending messages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("maxSendTps")]
        [Validation(Required=false)]
        public long? MaxSendTps { get; set; }

        /// <summary>
        /// <para>The updated remarks for the topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is the remark for test.</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
