// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class InitializeOperationRoleRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. The client generates the value. The value must be unique among different requests and can be up to 64 ASCII characters long.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The name of the Elasticsearch service-linked role to be created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;rolename&quot;:&quot;AliyunServiceRoleForElasticsearchCollector&quot;}</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

    }

}
