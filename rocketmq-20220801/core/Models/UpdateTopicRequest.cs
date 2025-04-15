// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class UpdateTopicRequest : TeaModel {
        /// <summary>
        /// <para>Maximum send message tps</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("maxSendTps")]
        [Validation(Required=false)]
        public long? MaxSendTps { get; set; }

        /// <summary>
        /// <para>Updated remarks for the topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is the remark for test.</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
