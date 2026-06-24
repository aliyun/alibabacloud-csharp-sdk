// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateKibanaPvlNetworkRequest : TeaModel {
        /// <summary>
        /// <para>The endpoint name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>es-cn-text-kibana</para>
        /// </summary>
        [NameInMap("endpointName")]
        [Validation(Required=false)]
        public string EndpointName { get; set; }

        /// <summary>
        /// <para>The list of security groups.</para>
        /// </summary>
        [NameInMap("securityGroups")]
        [Validation(Required=false)]
        public List<string> SecurityGroups { get; set; }

        /// <summary>
        /// <para>Used to ensure the idempotency of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The Kibana private network connection ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>es-cn-vo93ngti8000a****-kibana-internal-internal</para>
        /// </summary>
        [NameInMap("pvlId")]
        [Validation(Required=false)]
        public string PvlId { get; set; }

    }

}
