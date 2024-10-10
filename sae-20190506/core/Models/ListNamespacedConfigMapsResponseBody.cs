// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListNamespacedConfigMapsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: indicates that the call was successful.</description></item>
        /// <item><description><b>3xx</b>: indicates that the call was redirected.</description></item>
        /// <item><description><b>4xx</b>: indicates that the call failed.</description></item>
        /// <item><description><b>5xx</b>: indicates that a server error occurred.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListNamespacedConfigMapsResponseBodyData Data { get; set; }
        public class ListNamespacedConfigMapsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ConfigMap instances.</para>
            /// </summary>
            [NameInMap("ConfigMaps")]
            [Validation(Required=false)]
            public List<ListNamespacedConfigMapsResponseBodyDataConfigMaps> ConfigMaps { get; set; }
            public class ListNamespacedConfigMapsResponseBodyDataConfigMaps : TeaModel {
                /// <summary>
                /// <para>The ID of the ConfigMap instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ConfigMapId")]
                [Validation(Required=false)]
                public long? ConfigMapId { get; set; }

                /// <summary>
                /// <para>The time when the instance was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1593760185111</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The data of ConfigMap key-value pairs. Format:</para>
                /// <para>{&quot;k1&quot;:&quot;v1&quot;, &quot;k2&quot;:&quot;v2&quot;}</para>
                /// <para>k specifies a key and v specifies a value. For more information, see <a href="https://help.aliyun.com/document_detail/171326.html">Manage and use configurations</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;k1&quot;:&quot;v1&quot;,&quot;k2&quot;:&quot;v2&quot;}</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public Dictionary<string, object> Data { get; set; }

                /// <summary>
                /// <para>The description of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-desc</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the ConfigMap instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("NamespaceId")]
                [Validation(Required=false)]
                public string NamespaceId { get; set; }

                /// <summary>
                /// <para>The application that is associated with the instance.</para>
                /// </summary>
                [NameInMap("RelateApps")]
                [Validation(Required=false)]
                public List<ListNamespacedConfigMapsResponseBodyDataConfigMapsRelateApps> RelateApps { get; set; }
                public class ListNamespacedConfigMapsResponseBodyDataConfigMapsRelateApps : TeaModel {
                    /// <summary>
                    /// <para>The ID of the application.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>f16b4000-9058-4c22-a49d-49a28f0b****</para>
                    /// </summary>
                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    /// <summary>
                    /// <para>The name of the application.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test-app</para>
                    /// </summary>
                    [NameInMap("AppName")]
                    [Validation(Required=false)]
                    public string AppName { get; set; }

                }

                /// <summary>
                /// <para>The time when the instance was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1593760185111</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the call is successful, the <b>ErrorCode</b> parameter is not returned.</description></item>
        /// <item><description>If the call fails, the <b>ErrorCode</b> parameter is returned. For more information, see the &quot;<b>Error codes</b>&quot; section of this topic.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The returned information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the call is successful, <b>success</b> is returned.</description></item>
        /// <item><description>If the call fails, an error code is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>91F93257-7A4A-4BD3-9A7E-2F6EAE6D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the ConfigMap instances were obtained. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The instances were obtained.</description></item>
        /// <item><description><b>false</b>: The instances failed to be obtained.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The ID of the trace. The ID is used to query the details of a request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
