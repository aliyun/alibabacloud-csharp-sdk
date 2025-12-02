// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20250903.Models
{
    public class ListComponentsResponseBody : TeaModel {
        /// <summary>
        /// <para>List of components.</para>
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public List<ListComponentsResponseBodyComponents> Components { get; set; }
        public class ListComponentsResponseBodyComponents : TeaModel {
            /// <summary>
            /// <para>List of component actions.</para>
            /// </summary>
            [NameInMap("ComponentActions")]
            [Validation(Required=false)]
            public List<ListComponentsResponseBodyComponentsComponentActions> ComponentActions { get; set; }
            public class ListComponentsResponseBodyComponentsComponentActions : TeaModel {
                /// <summary>
                /// <para>The description of the component action name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Query logs from SLS</para>
                /// </summary>
                [NameInMap("ComponentActionDescription")]
                [Validation(Required=false)]
                public string ComponentActionDescription { get; set; }

                /// <summary>
                /// <para>The name of the component action.</para>
                /// 
                /// <b>Example:</b>
                /// <para>QueryLogs</para>
                /// </summary>
                [NameInMap("ComponentActionName")]
                [Validation(Required=false)]
                public string ComponentActionName { get; set; }

                /// <summary>
                /// <para>Configuration of input parameters for the action.</para>
                /// </summary>
                [NameInMap("InputConfigs")]
                [Validation(Required=false)]
                public List<ListComponentsResponseBodyComponentsComponentActionsInputConfigs> InputConfigs { get; set; }
                public class ListComponentsResponseBodyComponentsComponentActionsInputConfigs : TeaModel {
                    /// <summary>
                    /// <para>Default value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("DefaultValue")]
                    [Validation(Required=false)]
                    public string DefaultValue { get; set; }

                    /// <summary>
                    /// <para>Field description information.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Project Name</para>
                    /// </summary>
                    [NameInMap("FieldDescription")]
                    [Validation(Required=false)]
                    public string FieldDescription { get; set; }

                    /// <summary>
                    /// <para>Field display configuration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{
                    ///     &quot;height&quot;: 200,
                    ///     &quot;theme&quot;: &quot;vs-light&quot;,
                    ///     &quot;language&quot;: &quot;markdown&quot;,
                    ///     &quot;editorOptions&quot;: {}
                    /// }</para>
                    /// </summary>
                    [NameInMap("FieldDisplayConfig")]
                    [Validation(Required=false)]
                    public string FieldDisplayConfig { get; set; }

                    /// <summary>
                    /// <para>Field name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Project</para>
                    /// </summary>
                    [NameInMap("FieldName")]
                    [Validation(Required=false)]
                    public string FieldName { get; set; }

                    /// <summary>
                    /// <para>Field type, with the following values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>String</b>: String.</description></item>
                    /// <item><description><b>Long</b>: Long integer.</description></item>
                    /// <item><description><b>Integer</b>: Integer.</description></item>
                    /// <item><description><b>Double</b>: Double.</description></item>
                    /// <item><description><b>Boolean</b>: Boolean.</description></item>
                    /// <item><description><b>Complex</b>: Key-value pair.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>String</para>
                    /// </summary>
                    [NameInMap("FieldType")]
                    [Validation(Required=false)]
                    public string FieldType { get; set; }

                    /// <summary>
                    /// <para>Whether this parameter is required.</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b>: Required.</description></item>
                    /// <item><description><b>false</b>: Not required.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Required")]
                    [Validation(Required=false)]
                    public bool? Required { get; set; }

                }

                /// <summary>
                /// <para>Action output parameter configuration.</para>
                /// </summary>
                [NameInMap("OutputConfigs")]
                [Validation(Required=false)]
                public List<ListComponentsResponseBodyComponentsComponentActionsOutputConfigs> OutputConfigs { get; set; }
                public class ListComponentsResponseBodyComponentsComponentActionsOutputConfigs : TeaModel {
                    /// <summary>
                    /// <para>Field name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>lh_source</para>
                    /// </summary>
                    [NameInMap("FieldName")]
                    [Validation(Required=false)]
                    public string FieldName { get; set; }

                    /// <summary>
                    /// <para>Field type, with the following values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>String</b>: String.</description></item>
                    /// <item><description><b>Long</b>: Long integer.</description></item>
                    /// <item><description><b>Integer</b>: Integer.</description></item>
                    /// <item><description><b>Double</b>: Double.</description></item>
                    /// <item><description><b>Boolean</b>: Boolean.</description></item>
                    /// <item><description><b>Complex</b>: Key-value pair.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>String</para>
                    /// </summary>
                    [NameInMap("FieldType")]
                    [Validation(Required=false)]
                    public string FieldType { get; set; }

                }

            }

            /// <summary>
            /// <para>The alias of the component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Log</para>
            /// </summary>
            [NameInMap("ComponentAlias")]
            [Validation(Required=false)]
            public string ComponentAlias { get; set; }

            /// <summary>
            /// <para>List of asset field configurations.</para>
            /// </summary>
            [NameInMap("ComponentAssetConfigs")]
            [Validation(Required=false)]
            public List<ListComponentsResponseBodyComponentsComponentAssetConfigs> ComponentAssetConfigs { get; set; }
            public class ListComponentsResponseBodyComponentsComponentAssetConfigs : TeaModel {
                /// <summary>
                /// <para>Default value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                /// <summary>
                /// <para>Whether the field value needs to be encrypted. The range of values is as follows:</para>
                /// <list type="bullet">
                /// <item><description>true: Encrypted.</description></item>
                /// <item><description>false: Not encrypted.</description></item>
                /// </list>
                /// <para>Default value: false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Encrypted")]
                [Validation(Required=false)]
                public bool? Encrypted { get; set; }

                /// <summary>
                /// <para>Description of the field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>project name</para>
                /// </summary>
                [NameInMap("FieldDescription")]
                [Validation(Required=false)]
                public string FieldDescription { get; set; }

                /// <summary>
                /// <para>Field name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>project</para>
                /// </summary>
                [NameInMap("FieldName")]
                [Validation(Required=false)]
                public string FieldName { get; set; }

                /// <summary>
                /// <para>Field type, with the following values:</para>
                /// <list type="bullet">
                /// <item><description><b>String</b>: String.</description></item>
                /// <item><description><b>Long</b>: Long integer.</description></item>
                /// <item><description><b>Integer</b>: Integer.</description></item>
                /// <item><description><b>Double</b>: Double.</description></item>
                /// <item><description><b>Boolean</b>: Boolean.</description></item>
                /// <item><description><b>Complex</b>: Key-value pair.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>String</para>
                /// </summary>
                [NameInMap("FieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                /// <summary>
                /// <para>Whether this parameter is required.</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Required.</description></item>
                /// <item><description><b>false</b>: Not required.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Required")]
                [Validation(Required=false)]
                public bool? Required { get; set; }

            }

            /// <summary>
            /// <para>The description of the component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Log query</para>
            /// </summary>
            [NameInMap("ComponentDescription")]
            [Validation(Required=false)]
            public string ComponentDescription { get; set; }

            /// <summary>
            /// <para>Extended information of the component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;type&quot;:&quot;common&quot;}</para>
            /// </summary>
            [NameInMap("ComponentExtension")]
            [Validation(Required=false)]
            public string ComponentExtension { get; set; }

            /// <summary>
            /// <para>The icon URL of the component.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://img.alicdn.com/imgextra/i1/O1CN01qBUIqk22YyEBQDsha_!!6000000007133-55-tps-200-200.svg">https://img.alicdn.com/imgextra/i1/O1CN01qBUIqk22YyEBQDsha_!!6000000007133-55-tps-200-200.svg</a></para>
            /// </summary>
            [NameInMap("ComponentLogo")]
            [Validation(Required=false)]
            public string ComponentLogo { get; set; }

            /// <summary>
            /// <para>The name of the component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SLS</para>
            /// </summary>
            [NameInMap("ComponentName")]
            [Validation(Required=false)]
            public string ComponentName { get; set; }

            /// <summary>
            /// <para>Creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1757902337000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>Update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1757902337000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>Maximum number of results returned in a single request. Range: 1~100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Token for the start of the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7fbb1c66d607c1f79a740f039a8dcfda</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Page number for pagination, with a default value of 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Number of items per page for pagination. Range: 1~100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique identifier generated by Alibaba Cloud for this request, which can be used for troubleshooting and problem localization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0727DAC8-<b><b>-51EC-</b></b>-14999C62B502</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of items found.</para>
        /// 
        /// <b>Example:</b>
        /// <para>52</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
