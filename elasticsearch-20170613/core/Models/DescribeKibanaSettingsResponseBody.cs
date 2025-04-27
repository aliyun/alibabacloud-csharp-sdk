// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribeKibanaSettingsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>F99407AB-2FA9-489E-A259-40CF6D*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;map.includeElasticMapsService&quot;: &quot;false&quot;, &quot;server.ssl.cert&quot;: &quot;/home/admin/packages/kibana/config/cert/client.crt&quot;, &quot;server.ssl.enabled&quot;: &quot;true&quot;, &quot;server.ssl.key&quot;: &quot;/home/admin/packages/kibana/config/cert/client.key&quot;, &quot;xpack.reporting.capture.browser.chromium.disableSandbox&quot;: &quot;true&quot;}</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public Dictionary<string, object> Result { get; set; }

    }

}
