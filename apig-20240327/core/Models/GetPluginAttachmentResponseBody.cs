// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetPluginAttachmentResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetPluginAttachmentResponseBodyData Data { get; set; }
        public class GetPluginAttachmentResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            [NameInMap("environmentInfo")]
            [Validation(Required=false)]
            public EnvironmentInfo EnvironmentInfo { get; set; }

            [NameInMap("gatewayInfo")]
            [Validation(Required=false)]
            public GatewayInfo GatewayInfo { get; set; }

            [NameInMap("parentResourceInfo")]
            [Validation(Required=false)]
            public ParentResourceInfo ParentResourceInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pa-d05f1tmm1hku195dd8j0</para>
            /// </summary>
            [NameInMap("pluginAttachmentId")]
            [Validation(Required=false)]
            public string PluginAttachmentId { get; set; }

            [NameInMap("pluginClassInfo")]
            [Validation(Required=false)]
            public PluginClassInfo PluginClassInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cHJlcGVuZDoKLSByb2xlOiBzeXN0ZW0KICBjb250ZW50OiDor7fkvb/nlKjoi7Hor63lm57nrZTpl67popgKYXBwZW5kOgotIHJvbGU6IHVzZXIKICBjb250ZW50OiDmr4/mrKHlm57nrZTlrozpl67popjvvIzlsJ3or5Xov5vooYzlj43pl64K</para>
            /// </summary>
            [NameInMap("pluginConfig")]
            [Validation(Required=false)]
            public string PluginConfig { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pl-cvo8ub6m1hkvgv03r3k0</para>
            /// </summary>
            [NameInMap("pluginId")]
            [Validation(Required=false)]
            public string PluginId { get; set; }

            [NameInMap("resourceInfos")]
            [Validation(Required=false)]
            public List<ResourceInfo> ResourceInfos { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>C61E30D3-579A-5B43-994E-31E02EDC9129</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
