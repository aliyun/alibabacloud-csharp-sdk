// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetPluginAttachmentResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response payload.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetPluginAttachmentResponseBodyData Data { get; set; }
        public class GetPluginAttachmentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the plug-in is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The environment information.</para>
            /// </summary>
            [NameInMap("environmentInfo")]
            [Validation(Required=false)]
            public EnvironmentInfo EnvironmentInfo { get; set; }

            /// <summary>
            /// <para>The instance information.</para>
            /// </summary>
            [NameInMap("gatewayInfo")]
            [Validation(Required=false)]
            public GatewayInfo GatewayInfo { get; set; }

            /// <summary>
            /// <para>The information about the parent resource to which the plug-in is attached.</para>
            /// </summary>
            [NameInMap("parentResourceInfo")]
            [Validation(Required=false)]
            public ParentResourceInfo ParentResourceInfo { get; set; }

            /// <summary>
            /// <para>The attachment ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pa-d05f1tmm1hku195dd8j0</para>
            /// </summary>
            [NameInMap("pluginAttachmentId")]
            [Validation(Required=false)]
            public string PluginAttachmentId { get; set; }

            /// <summary>
            /// <para>The plug-in type information.</para>
            /// </summary>
            [NameInMap("pluginClassInfo")]
            [Validation(Required=false)]
            public PluginClassInfo PluginClassInfo { get; set; }

            /// <summary>
            /// <para>The Base64-encoded configurations of the plug-in.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cHJlcGVuZDoKLSByb2xlOiBzeXN0ZW0KICBjb250ZW50OiDor7fkvb/nlKjoi7Hor63lm57nrZTpl67popgKYXBwZW5kOgotIHJvbGU6IHVzZXIKICBjb250ZW50OiDmr4/mrKHlm57nrZTlrozpl67popjvvIzlsJ3or5Xov5vooYzlj43pl64K</para>
            /// </summary>
            [NameInMap("pluginConfig")]
            [Validation(Required=false)]
            public string PluginConfig { get; set; }

            /// <summary>
            /// <para>The plug-in ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pl-cvo8ub6m1hkvgv03r3k0</para>
            /// </summary>
            [NameInMap("pluginId")]
            [Validation(Required=false)]
            public string PluginId { get; set; }

            /// <summary>
            /// <para>The resource details.</para>
            /// </summary>
            [NameInMap("resourceInfos")]
            [Validation(Required=false)]
            public List<ResourceInfo> ResourceInfos { get; set; }

        }

        /// <summary>
        /// <para>The status message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C61E30D3-579A-5B43-994E-31E02EDC9129</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
