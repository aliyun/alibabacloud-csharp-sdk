// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The name of the resource group. To get the resource group name, see <a href="https://help.aliyun.com/document_detail/449143.html">ListResources</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>group</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>A comma-separated list of labels. This operation returns only the resources that have all the specified labels.</para>
        /// <para>This parameter is available only for resources whose <c>ResourceTypes</c> is set to <c>ACS</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>system.supported.dsw=true,system.supported.dlc=true</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// <para>The option to query resources. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>ListResourceByWorkspace</c> (Default): lists the resources in a workspace.</para>
        /// </description></item>
        /// <item><description><para><c>ListResource</c>: lists the resources of the current user.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ListResourceByWorkspace</para>
        /// </summary>
        [NameInMap("Option")]
        [Validation(Required=false)]
        public string Option { get; set; }

        /// <summary>
        /// <para>The page number. The value must be greater than or equal to 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para><b>Deprecated.</b> This parameter is deprecated. Use the <c>ResourceType</c> parameter instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MaxCompute</para>
        /// </summary>
        [NameInMap("ProductTypes")]
        [Validation(Required=false)]
        public string ProductTypes { get; set; }

        /// <summary>
        /// <para>A comma-separated list of quota IDs. This operation returns only the resources that are associated with all the specified quota IDs.</para>
        /// <remarks>
        /// <para>This parameter is available only for resources whose <c>ResourceTypes</c> is set to <c>ACS</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>quota-k<b><b><b>da,quota-cd</b></b></b>w</para>
        /// </summary>
        [NameInMap("QuotaIds")]
        [Validation(Required=false)]
        public string QuotaIds { get; set; }

        /// <summary>
        /// <para>The resource name. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>The name must be 3 to 28 characters in length.</para>
        /// </description></item>
        /// <item><description><para>The name must be unique within a region.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>resource</para>
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// <para>The resource types. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>MaxCompute</c>: MaxCompute resources.</para>
        /// </description></item>
        /// <item><description><para><c>ECS</c>: ECS resources.</para>
        /// </description></item>
        /// <item><description><para><c>Lingjun</c>: Lingjun computing resources.</para>
        /// </description></item>
        /// <item><description><para><c>ACS</c>: ACS computing resources.</para>
        /// </description></item>
        /// <item><description><para><c>Flink</c>: Flink resources.</para>
        /// </description></item>
        /// <item><description><para><c>SelfManagedAckPro</c>: self-managed AckPro cluster resources.</para>
        /// </description></item>
        /// <item><description><para><c>SelfManagedAckLingjun</c>: self-managed AckLingjun cluster resources.</para>
        /// </description></item>
        /// <item><description><para><c>SelfManagedASI</c>: self-managed ASI cluster resources from a third-party cloud.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MaxCompute</para>
        /// </summary>
        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public string ResourceTypes { get; set; }

        /// <summary>
        /// <para>Specifies whether to return detailed information. The detailed information includes the <c>Quotas</c> field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c> (Default): returns detailed information.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: does not return detailed information.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Verbose")]
        [Validation(Required=false)]
        public bool? Verbose { get; set; }

        /// <summary>
        /// <para>A comma-separated list of fields that you want to return. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Quota</c></para>
        /// </description></item>
        /// <item><description><para><c>Label</c></para>
        /// </description></item>
        /// <item><description><para><c>IsDefault</c></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Quota,IsDefault</para>
        /// </summary>
        [NameInMap("VerboseFields")]
        [Validation(Required=false)]
        public string VerboseFields { get; set; }

        /// <summary>
        /// <para>The ID of the workspace. To get the workspace ID, see <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a>.</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required if <c>Option</c> is set to <c>ListResourceByWorkspace</c>.</para>
        /// </description></item>
        /// <item><description><para>This parameter is not required if <c>Option</c> is set to <c>ListResource</c>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
