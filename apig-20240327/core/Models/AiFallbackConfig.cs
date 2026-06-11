// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AiFallbackConfig : TeaModel {
        /// <summary>
        /// <para>Determines whether fallback is triggered solely by the upstream service\&quot;s status code. If <c>true</c>, fallback occurs only if the upstream service returns an error code. If <c>false</c>, other conditions, such as timeouts, can also trigger the fallback.</para>
        /// </summary>
        [NameInMap("onlyRedirectUpstreamCode")]
        [Validation(Required=false)]
        public bool? OnlyRedirectUpstreamCode { get; set; }

        /// <summary>
        /// <para>A list of fallback service configurations.</para>
        /// </summary>
        [NameInMap("serviceConfigs")]
        [Validation(Required=false)]
        public List<AiFallbackConfigServiceConfigs> ServiceConfigs { get; set; }
        public class AiFallbackConfigServiceConfigs : TeaModel {
            /// <summary>
            /// <para>The name of the fallback service.</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Determines whether to pass the original model name to the fallback service. If <c>true</c>, the model name from the original request is used. If <c>false</c>, the value of <c>targetModelName</c> is used instead.</para>
            /// </summary>
            [NameInMap("passThroughModelName")]
            [Validation(Required=false)]
            public bool? PassThroughModelName { get; set; }

            /// <summary>
            /// <para>The unique ID of the fallback service.</para>
            /// </summary>
            [NameInMap("serviceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>The name of the model to use for the fallback request.</para>
            /// </summary>
            [NameInMap("targetModelName")]
            [Validation(Required=false)]
            public string TargetModelName { get; set; }

        }

    }

}
