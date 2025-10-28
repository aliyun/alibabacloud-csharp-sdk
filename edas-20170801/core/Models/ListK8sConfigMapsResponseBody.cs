// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListK8sConfigMapsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The additional information that is returned.</para>
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
        /// <para>D16979DC-4D42-****************</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The query results that are returned.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListK8sConfigMapsResponseBodyResult Result { get; set; }
        public class ListK8sConfigMapsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The information about ConfigMaps.</para>
            /// </summary>
            [NameInMap("ConfigMaps")]
            [Validation(Required=false)]
            public List<ListK8sConfigMapsResponseBodyResultConfigMaps> ConfigMaps { get; set; }
            public class ListK8sConfigMapsResponseBodyResultConfigMaps : TeaModel {
                /// <summary>
                /// <para>The ID of the Kubernetes cluster. You can obtain the cluster ID by calling the GetK8sCluster operation. For more information, see <a href="https://help.aliyun.com/document_detail/181437.html">GetK8sCluster</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d73918f4-3b08-4c17-bb07-eaf8********</para>
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <para>The name of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-cluster</para>
                /// </summary>
                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                /// <summary>
                /// <para>The time when the ConfigMaps were created. The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-01-31T02:46:14Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The information about ConfigMaps.</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<ListK8sConfigMapsResponseBodyResultConfigMapsData> Data { get; set; }
                public class ListK8sConfigMapsResponseBodyResultConfigMapsData : TeaModel {
                    /// <summary>
                    /// <para>The user-defined key that is stored in the ConfigMap.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>name</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The user-defined value that is stored in the ConfigMap.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>william</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The name of the ConfigMap.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-config</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The namespace of the Kubernetes cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The related applications.</para>
                /// </summary>
                [NameInMap("RelatedApps")]
                [Validation(Required=false)]
                public List<ListK8sConfigMapsResponseBodyResultConfigMapsRelatedApps> RelatedApps { get; set; }
                public class ListK8sConfigMapsResponseBodyResultConfigMapsRelatedApps : TeaModel {
                    /// <summary>
                    /// <para>The ID of the application.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>728cbdf2-da10-49b8-b69c-9168a********</para>
                    /// </summary>
                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    /// <summary>
                    /// <para>The name of the application.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>my-app</para>
                    /// </summary>
                    [NameInMap("AppName")]
                    [Validation(Required=false)]
                    public string AppName { get; set; }

                }

            }

            /// <summary>
            /// <para>The total number of entries that are returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

    }

}
