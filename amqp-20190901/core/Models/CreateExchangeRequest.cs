// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp20190901.Models
{
    public class CreateExchangeRequest : TeaModel {
        [NameInMap("AlternateExchange")]
        [Validation(Required=false)]
        public string AlternateExchange { get; set; }

        [NameInMap("AutoDelete")]
        [Validation(Required=false)]
        public bool? AutoDelete { get; set; }

        [NameInMap("ConsoleSessionId")]
        [Validation(Required=false)]
        public string ConsoleSessionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ExchangeName")]
        [Validation(Required=false)]
        public string ExchangeName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ExchangeType")]
        [Validation(Required=false)]
        public int? ExchangeType { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Internal")]
        [Validation(Required=false)]
        public bool? Internal { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("VhostName")]
        [Validation(Required=false)]
        public string VhostName { get; set; }

        [NameInMap("XDelayedType")]
        [Validation(Required=false)]
        public string XDelayedType { get; set; }

        [NameInMap("XHashHeader")]
        [Validation(Required=false)]
        public string XHashHeader { get; set; }

    }

}
