// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateKibanaPvlNetworkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>es-cn-27a3mul6l00***-kibana</para>
        /// </summary>
        [NameInMap("endpointName")]
        [Validation(Required=false)]
        public string EndpointName { get; set; }

        [NameInMap("securityGroups")]
        [Validation(Required=false)]
        public List<string> SecurityGroups { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>es-cn-27a3mul6l0***-kibana-internal</para>
        /// </summary>
        [NameInMap("pvlId")]
        [Validation(Required=false)]
        public string PvlId { get; set; }

    }

}
