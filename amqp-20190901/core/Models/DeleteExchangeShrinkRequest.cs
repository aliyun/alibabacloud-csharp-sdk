// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp20190901.Models
{
    public class DeleteExchangeShrinkRequest : TeaModel {
        [NameInMap("Collina")]
        [Validation(Required=false)]
        public string Collina { get; set; }

        [NameInMap("ConsoleSessionId")]
        [Validation(Required=false)]
        public string ConsoleSessionId { get; set; }

        [NameInMap("ExchangeName")]
        [Validation(Required=false)]
        public string ExchangeName { get; set; }

        [NameInMap("ExchangeNames")]
        [Validation(Required=false)]
        public string ExchangeNamesShrink { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("UmidToken")]
        [Validation(Required=false)]
        public string UmidToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("VhostName")]
        [Validation(Required=false)]
        public string VhostName { get; set; }

    }

}
