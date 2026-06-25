// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ListServiceInstancesRequest : TeaModel {
        /// <summary>
        /// <para>A keyword for the search. You can search by instance name, instance IP address, host IP address, or instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.118.xx.xx</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The IP address of the host where the service instance is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.224.xx.xx</para>
        /// </summary>
        [NameInMap("HostIP")]
        [Validation(Required=false)]
        public string HostIP { get; set; }

        /// <summary>
        /// <para>The IP address of the service instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.224.xx.xx</para>
        /// </summary>
        [NameInMap("InstanceIP")]
        [Validation(Required=false)]
        public string InstanceIP { get; set; }

        /// <summary>
        /// <para>The name of the service instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>foo-bdc5xxxx-8l7rk</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The status of the service instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// <para>The instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.c7.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>Specifies whether the instance is a spot instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsSpot")]
        [Validation(Required=false)]
        public bool? IsSpot { get; set; }

        /// <summary>
        /// <para>Specifies whether to query the list of instance replicas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ListReplica")]
        [Validation(Required=false)]
        public bool? ListReplica { get; set; }

        /// <summary>
        /// <para>The type of the sub-service. This parameter is valid only for aggregation services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LLMDecode</para>
        /// </summary>
        [NameInMap("MemberType")]
        [Validation(Required=false)]
        public string MemberType { get; set; }

        /// <summary>
        /// <para>The sort order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. The default value is 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        /// <para>The name of the instance replica.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cbh-qwen3-a1bc-prefill-ep1tp4dp</para>
        /// </summary>
        [NameInMap("ReplicaName")]
        [Validation(Required=false)]
        public string ReplicaName { get; set; }

        /// <summary>
        /// <para>The resource group to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eas-r-xxxxxxx</para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

        /// <summary>
        /// <para>The type of the resource group to which the service instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PublicResource</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The role of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Queue</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>The field to use for sorting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>StartTime</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

    }

}
