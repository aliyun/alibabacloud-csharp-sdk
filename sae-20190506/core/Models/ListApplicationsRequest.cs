// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListApplicationsRequest : TeaModel {
        /// <summary>
        /// <para>The application name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo-app</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The Serverless App Engine (SAE) application type.</para>
        /// <list type="bullet">
        /// <item><description><b>micro_service.</b></description></item>
        /// <item><description><b>web.</b></description></item>
        /// <item><description><b>job.</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>micro_service</para>
        /// </summary>
        [NameInMap("AppSource")]
        [Validation(Required=false)]
        public string AppSource { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The dimension by which to filter applications. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>appName</b>: application name.</description></item>
        /// <item><description><b>appIds</b>: application ID.</description></item>
        /// <item><description><b>slbIps</b>: SLB IP address.</description></item>
        /// <item><description><b>instanceIps</b>: instance IP address.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>appName</para>
        /// </summary>
        [NameInMap("FieldType")]
        [Validation(Required=false)]
        public string FieldType { get; set; }

        /// <summary>
        /// <para>The application name, application ID, SLB IP address, or instance IP address of the target application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo-app</para>
        /// </summary>
        [NameInMap("FieldValue")]
        [Validation(Required=false)]
        public string FieldValue { get; set; }

        /// <summary>
        /// <para>Specifies whether the application is stateful.</para>
        /// </summary>
        [NameInMap("IsStateful")]
        [Validation(Required=false)]
        public string IsStateful { get; set; }

        /// <summary>
        /// <para>The namespace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing:demo</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>The application version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>lite: Lite Edition</description></item>
        /// <item><description>std: Standard Edition</description></item>
        /// <item><description>pro: Professional Edition</description></item>
        /// </list>
        /// </summary>
        [NameInMap("NewSaeVersion")]
        [Validation(Required=false)]
        public string NewSaeVersion { get; set; }

        /// <summary>
        /// <para>The field by which to sort applications. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>runnings</b>: sorts by the current number target instances.</description></item>
        /// <item><description><b>instances</b>: sorts by the target number target instances.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>runnings</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paging query. Valid values: [0,10000].</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ProgrammingLanguage")]
        [Validation(Required=false)]
        public string ProgrammingLanguage { get; set; }

        /// <summary>
        /// <para>Specifies whether to sort application instances by running status. If instances have the same status, they are sorted by instance ID. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: sorts in ascending order. Instances are arranged based on the startup sequence. For example, to reach the running state, an instance must go through steps such as starting the container, pulling the image, and initializing the instance.</description></item>
        /// <item><description><b>false</b>: sorts in descending order.</description></item>
        /// </list>
        /// <para>The ascending order of instances is as follows:</para>
        /// <ol>
        /// <item><description><b>Error</b>: an error occurred during instance startup.</description></item>
        /// <item><description><b>CrashLoopBackOff</b>: the container failed to start, encountered an error during startup, and encountered an error again after restart.</description></item>
        /// <item><description><b>ErrImagePull</b>: an error occurred while pulling the container image for the instance.</description></item>
        /// <item><description><b>ImagePullBackOff</b>: the container image cannot be obtained.</description></item>
        /// <item><description><b>Pending</b>: the instance is waiting to be scheduled.</description></item>
        /// <item><description><b>Unknown</b>: an unknown exception occurred.</description></item>
        /// <item><description><b>Terminating</b>: the instance is being terminated.</description></item>
        /// <item><description><b>NotFound</b>: the instance cannot be found.</description></item>
        /// <item><description><b>PodInitializing</b>: the instance is being initialized.</description></item>
        /// <item><description><b>Init:0/1</b>: the instance is initializing.</description></item>
        /// <item><description><b>Running</b>: the instance is running.</description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Reverse")]
        [Validation(Required=false)]
        public bool? Reverse { get; set; }

        /// <summary>
        /// <para>The tag key-value pairs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>key</b>: the tag key. The length must be in the range of [1,128].</description></item>
        /// <item><description><b>value</b>: the tag value. The length must be in the range of [1,128].</description></item>
        /// </list>
        /// <para>Tags are case-sensitive. If you specify multiple tags, all specified tags are created and attached to the resource. Each tag key on the same resource can have only one tag value. If you add a tag key that already exists, the corresponding tag value is updated to the new value.</para>
        /// <para>Tags cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;key&quot;:&quot;key&quot;,&quot;value&quot;:&quot;value&quot;}]</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
