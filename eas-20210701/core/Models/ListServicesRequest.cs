// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ListServicesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Auto Scaling for the service.</para>
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
        /// <para>Specifies whether to enable scheduled auto scaling for the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CronscalerEnabled")]
        [Validation(Required=false)]
        public bool? CronscalerEnabled { get; set; }

        /// <summary>
        /// <para>The keyword for a fuzzy search. This parameter supports fuzzy searches by service name only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>foo</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The private gateway ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-1uhcqmsc7x22******</para>
        /// </summary>
        [NameInMap("Gateway")]
        [Validation(Required=false)]
        public string Gateway { get; set; }

        /// <summary>
        /// <para>The name of the service group. To learn how to obtain this name, see <a href="https://help.aliyun.com/document_detail/412109.html">ListServices</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>foo</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>Specifies whether to include services that do not belong to any workspace. The default value is true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeNoWorkspace")]
        [Validation(Required=false)]
        public bool? IncludeNoWorkspace { get; set; }

        /// <summary>
        /// <para>Filters services by label.</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public Dictionary<string, string> Label { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>desc</c> (default): descending.</para>
        /// </description></item>
        /// <item><description><para><c>asc</c>: ascending.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number of the results to return. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of services to return per page. The default value is 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The UID of the primary service. This parameter applies to member services in a service group.</para>
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
        /// <para>Specifies whether to enable a burstable resource pool for the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ResourceBurstable")]
        [Validation(Required=false)]
        public bool? ResourceBurstable { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. To learn how to query for this ID, see <a href="https://help.aliyun.com/document_detail/412133.html">ListResources</a>.</para>
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
        /// <para>The name or ID of the service\&quot;s resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eas-r-hd0qwy8cxxxx</para>
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        [Obsolete]
        public string ResourceName { get; set; }

        /// <summary>
        /// <para>The type of resource the service uses. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PublicResource</para>
        /// </description></item>
        /// <item><description><para>DedicatedResource</para>
        /// </description></item>
        /// <item><description><para>Lingjun</para>
        /// </description></item>
        /// <item><description><para>SelfManagedLingjun</para>
        /// </description></item>
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
        /// <para>The service name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>echo_test</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The status of the service.</para>
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
        /// <item><description><para>Async</para>
        /// </description></item>
        /// <item><description><para>Standard</para>
        /// </description></item>
        /// <item><description><para>Queue</para>
        /// </description></item>
        /// <item><description><para>LLM</para>
        /// </description></item>
        /// <item><description><para>RAG</para>
        /// </description></item>
        /// <item><description><para>Serverless</para>
        /// </description></item>
        /// <item><description><para>LLMGatewayService</para>
        /// </description></item>
        /// <item><description><para>OfflineTask</para>
        /// </description></item>
        /// <item><description><para>SDCluster</para>
        /// </description></item>
        /// <item><description><para>ScalableJob</para>
        /// </description></item>
        /// <item><description><para>ScalableJobService</para>
        /// </description></item>
        /// <item><description><para>AssistantJob</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// <para>The service UID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eas-m-c9iw3yitxxxx</para>
        /// </summary>
        [NameInMap("ServiceUid")]
        [Validation(Required=false)]
        public string ServiceUid { get; set; }

        /// <summary>
        /// <para>The sort field. By default, results are sorted by timestamp in descending order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTime</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// <para>Specifies whether the service accepts group traffic. This parameter applies only to services within a service group.</para>
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
