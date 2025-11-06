// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp20190901.Models
{
    public class GetExchangeRateShrinkRequest : TeaModel {
        [NameInMap("ConsoleSessionId")]
        [Validation(Required=false)]
        public string ConsoleSessionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ExchangeNames")]
        [Validation(Required=false)]
        public string ExchangeNamesShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("VhostName")]
        [Validation(Required=false)]
        public string VhostName { get; set; }

    }

}
