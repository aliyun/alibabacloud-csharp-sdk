// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class VerifyConsumeMessageRequest : TeaModel {
        /// <summary>
        /// <para>The client ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zeekr-settlement-server-dc555456f-v2lcg@1@1@qfvorazqns</para>
        /// </summary>
        [NameInMap("clientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <para>The ID of the consumer group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TEST_FINANCE_STOCK_OUT_GROUP</para>
        /// </summary>
        [NameInMap("consumerGroupId")]
        [Validation(Required=false)]
        public string ConsumerGroupId { get; set; }

    }

}
