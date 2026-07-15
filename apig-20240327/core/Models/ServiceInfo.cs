// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ServiceInfo : TeaModel {
        /// <summary>
        /// <para>The service routing type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("expressType")]
        [Validation(Required=false)]
        public string ExpressType { get; set; }

        /// <summary>
        /// <para>The service group name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default-group</para>
        /// </summary>
        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The service name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-openai-service</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The service namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The PAI workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-xxx****</para>
        /// </summary>
        [NameInMap("paiWorkspaceId")]
        [Validation(Required=false)]
        public string PaiWorkspaceId { get; set; }

        /// <summary>
        /// <para>The PAI workspace name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-workspace</para>
        /// </summary>
        [NameInMap("paiWorkspaceName")]
        [Validation(Required=false)]
        public string PaiWorkspaceName { get; set; }

        /// <summary>
        /// <para>The list of service ports.</para>
        /// </summary>
        [NameInMap("ports")]
        [Validation(Required=false)]
        public List<ServiceInfoPorts> Ports { get; set; }
        public class ServiceInfoPorts : TeaModel {
            /// <summary>
            /// <para>The port name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The port number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8080</para>
            /// </summary>
            [NameInMap("port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The port protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

        /// <summary>
        /// <para>The service version qualifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        /// <summary>
        /// <para>The service ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>svc-xxx****</para>
        /// </summary>
        [NameInMap("serviceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The service source type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The service status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The list of service versions.</para>
        /// </summary>
        [NameInMap("versions")]
        [Validation(Required=false)]
        public List<ServiceInfoVersions> Versions { get; set; }
        public class ServiceInfoVersions : TeaModel {
            /// <summary>
            /// <para>The list of version labels.</para>
            /// </summary>
            [NameInMap("labels")]
            [Validation(Required=false)]
            public List<ServiceInfoVersionsLabels> Labels { get; set; }
            public class ServiceInfoVersionsLabels : TeaModel {
                /// <summary>
                /// <para>The label key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>env</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The label value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>production</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The version name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1.0.0</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
