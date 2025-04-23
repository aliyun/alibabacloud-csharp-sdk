// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class UpdateRabbitmqPublisherAttributeRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ExchangeTest</para>
        /// </summary>
        [NameInMap("exchangeName")]
        [Validation(Required=false)]
        public string ExchangeName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TOPIC</para>
        /// </summary>
        [NameInMap("exchangeType")]
        [Validation(Required=false)]
        public string ExchangeType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
