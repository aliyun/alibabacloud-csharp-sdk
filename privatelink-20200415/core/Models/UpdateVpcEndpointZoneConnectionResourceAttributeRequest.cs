// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class UpdateVpcEndpointZoneConnectionResourceAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe637760</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The endpoint ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ep-hp33b2e43fays7s8****</para>
        /// </summary>
        [NameInMap("EndpointId")]
        [Validation(Required=false)]
        public string EndpointId { get; set; }

        /// <summary>
        /// <para>The region ID of the endpoint connection whose bandwidth you want to modify.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/120468.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource allocation mode. You can change the resource allocation mode only if the endpoint connection is in the <b>Disconnected</b> state. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Auto</b>: automatically and randomly allocates service resources. In this mode, the specified service resource is deleted.</description></item>
        /// <item><description><b>Manual</b>: manually allocates service resources. If you set the value to Manual, you must also specify the <b>ResourceId</b> and <b>ResourceType</b> parameters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Auto</para>
        /// </summary>
        [NameInMap("ResourceAllocateMode")]
        [Validation(Required=false)]
        public string ResourceAllocateMode { get; set; }

        /// <summary>
        /// <para>The ID of the service resource that you want to manually allocate or migrate in the zone where the endpoint connection is deployed.</para>
        /// <remarks>
        /// <para>If <b>ResourceAllocateMode</b> is set to <b>Mannual</b>, or <b>ResourceReplaceMode</b> is set, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>lb-hp32z1wp5peaoox2q****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The migration mode of the service resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Graceful</b>: smooth migration. Service resources in the zone are smoothly migrated.</description></item>
        /// <item><description><b>Force</b>: forced migration. Service resources in the zone are forcefully migrated.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You need to specify this parameter only if you want to migrate service resources and the endpoint connection is in the <b>Connected</b> state. If you specify this parameter, you must also specify the <b>ResourceId</b> and <b>ResourceType</b> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Graceful</para>
        /// </summary>
        [NameInMap("ResourceReplaceMode")]
        [Validation(Required=false)]
        public string ResourceReplaceMode { get; set; }

        /// <summary>
        /// <para>The type of the service resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>slb</b>: a CLB instance that supports PrivateLink. In addition, the CLB instance is deployed in a VPC.</description></item>
        /// <item><description><b>alb</b>: an Application Load Balancer (ALB) instance that supports PrivateLink. In addition, the ALB instance is deployed in a VPC.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If <b>ResourceAllocateMode</b> is set to <b>Mannual</b>, or <b>ResourceReplaceMode</b> is set, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>slb</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The endpoint service ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epsrv-hp3vpx8yqxblby3i****</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
