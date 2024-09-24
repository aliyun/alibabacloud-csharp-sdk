// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetResourceTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>The type of the resource.</para>
        /// </summary>
        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public Dictionary<string, object> Attributes { get; set; }

        /// <summary>
        /// <para>The creation time. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-02-24T08:25:21</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The default version ID.</para>
        /// <remarks>
        /// <para>This parameter is returned only if the resource type is queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("DefaultVersionId")]
        [Validation(Required=false)]
        public string DefaultVersionId { get; set; }

        /// <summary>
        /// <para>The description of the resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>It is a demo.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The entity type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Resource: regular resource. For more information, see <a href="https://help.aliyun.com/document_detail/28863.html">Resources</a>.</description></item>
        /// <item><description>DataSource: DataSource resource. For more information, see <a href="https://help.aliyun.com/document_detail/404753.html">DataSource resources</a>.</description></item>
        /// <item><description>module: module.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Resource</para>
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <para>Indicates whether the version is the default version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is returned only if a specific version of the resource type is queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsDefaultVersion")]
        [Validation(Required=false)]
        public bool? IsDefaultVersion { get; set; }

        /// <summary>
        /// <para>The latest version ID.</para>
        /// <remarks>
        /// <para>This parameter is returned only if the resource type is queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>v10</para>
        /// </summary>
        [NameInMap("LatestVersionId")]
        [Validation(Required=false)]
        public string LatestVersionId { get; set; }

        /// <summary>
        /// <para>Indicates whether the resource supports drift detection. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Drift detection is supported.</description></item>
        /// <item><description>false: Drift detection is not supported.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Properties")]
        [Validation(Required=false)]
        public Dictionary<string, object> Properties { get; set; }

        /// <summary>
        /// <para>The provider of the resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ROS: The resource type is provided by Resource Orchestration Service (ROS).</description></item>
        /// <item><description>Self: The resource type is provided by you.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ROS</para>
        /// </summary>
        [NameInMap("Provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// <para>The attributes of the resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A28FBA2E-B6B3-5822-AA45-AB875EF23641</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The properties of the resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALIYUN::ROS::WaitConditionHandle</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>Indicates whether the resource supports scratch detection. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Scratch detection is supported.</description></item>
        /// <item><description>false: Scratch detection is not supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SupportDriftDetection")]
        [Validation(Required=false)]
        public bool? SupportDriftDetection { get; set; }

        /// <summary>
        /// <para>The entity type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Resource: resources other than DataSource resources. For more information, see <a href="https://help.aliyun.com/document_detail/28863.html">Resources</a>.</description></item>
        /// <item><description>DataSource: DataSource resources.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SupportScratchDetection")]
        [Validation(Required=false)]
        public bool? SupportScratchDetection { get; set; }

        /// <summary>
        /// <para>The template content in the module.</para>
        /// <remarks>
        /// <para>This parameter is returned only if a specific version of the resource type is queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ROSTemplateFormatVersion&quot;:&quot;2015-09-01&quot;}</para>
        /// </summary>
        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// <para>The total number of versions.</para>
        /// <remarks>
        /// <para>This parameter is returned only if the resource type is queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalVersionCount")]
        [Validation(Required=false)]
        public int? TotalVersionCount { get; set; }

        /// <summary>
        /// <para>The update time. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-02-24T08:25:21</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
