// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ListServicesRequest : TeaModel {
        /// <summary>
        /// <para>Filters services by visibility. PUBLIC indicates a public service, and PRIVATE indicates a private service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>Specifies whether elastic scaling is enabled for the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoscalerEnabled")]
        [Validation(Required=false)]
        public bool? AutoscalerEnabled { get; set; }

        /// <summary>
        /// <para>The UID of the account that created the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19989224166xxxxxxx</para>
        /// </summary>
        [NameInMap("CallerUid")]
        [Validation(Required=false)]
        public string CallerUid { get; set; }

        /// <summary>
        /// <para>Specifies whether scheduled scaling is enabled for the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CronscalerEnabled")]
        [Validation(Required=false)]
        public bool? CronscalerEnabled { get; set; }

        /// <summary>
        /// <para>The fuzzy match field. Only fuzzy matching by service name is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>foo</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The ID of the private gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-1uhcqmsc7x22******</para>
        /// </summary>
        [NameInMap("Gateway")]
        [Validation(Required=false)]
        public string Gateway { get; set; }

        /// <summary>
        /// <para>The name of the service group. For information about how to obtain the service group name, see <a href="https://help.aliyun.com/document_detail/412109.html">ListServices</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>foo</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>Specifies whether to include services that do not belong to any workspace. Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeNoWorkspace")]
        [Validation(Required=false)]
        public bool? IncludeNoWorkspace { get; set; }

        /// <summary>
        /// <para>The label used to filter services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key1&quot;:&quot;value1&quot;,&quot;key2&quot;:null}</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public Dictionary<string, string> Label { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>desc: Descending order. This is the default value.</description></item>
        /// <item><description>asc: Ascending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number of the service list to return. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of services to return on each page during a paged query. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the primary service that corresponds to the band member service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eas-m-ijafy3c8cxxxx</para>
        /// </summary>
        [NameInMap("ParentServiceUid")]
        [Validation(Required=false)]
        public string ParentServiceUid { get; set; }

        /// <summary>
        /// <para>The quota ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quota1****</para>
        /// </summary>
        [NameInMap("QuotaId")]
        [Validation(Required=false)]
        public string QuotaId { get; set; }

        /// <summary>
        /// <para>The custom name of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("ResourceAliasName")]
        [Validation(Required=false)]
        public string ResourceAliasName { get; set; }

        /// <summary>
        /// <para>Specifies whether the burstable resource pool is enabled for the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ResourceBurstable")]
        [Validation(Required=false)]
        public bool? ResourceBurstable { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. For information about how to query the resource group ID, see <a href="https://help.aliyun.com/document_detail/412133.html">ListResources</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eas-r-asdas****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The name or ID of the resource group to which the service belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eas-r-hd0qwy8cxxxx</para>
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        [Obsolete]
        public string ResourceName { get; set; }

        /// <summary>
        /// <para>The type of resource used by the service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PublicResource</description></item>
        /// <item><description>DedicatedResource</description></item>
        /// <item><description>Lingjun</description></item>
        /// <item><description>SelfManagedLingjun</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PublicResource</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The service role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LLMGateway</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>The name of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>echo_test</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The running status of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("ServiceStatus")]
        [Validation(Required=false)]
        public string ServiceStatus { get; set; }

        /// <summary>
        /// <para>The service type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Async</description></item>
        /// <item><description>Standard</description></item>
        /// <item><description>Queue</description></item>
        /// <item><description>LLM</description></item>
        /// <item><description>RAG</description></item>
        /// <item><description>Serverless</description></item>
        /// <item><description>LLMGatewayService</description></item>
        /// <item><description>Offline Task</description></item>
        /// <item><description>SDCluster</description></item>
        /// <item><description>ScalableJob</description></item>
        /// <item><description>ScalableJobService</description></item>
        /// <item><description>AssistantJob</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// <para>The UID of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eas-m-c9iw3yitxxxx</para>
        /// </summary>
        [NameInMap("ServiceUid")]
        [Validation(Required=false)]
        public string ServiceUid { get; set; }

        /// <summary>
        /// <para>The sort field. By default, timestamp fields are sorted in descending order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTime</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// <para>Specifies whether to receive group traffic. This parameter is valid only for group services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>grouping</para>
        /// </summary>
        [NameInMap("TrafficState")]
        [Validation(Required=false)]
        public string TrafficState { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234**</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
