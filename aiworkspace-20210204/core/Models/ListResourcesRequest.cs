// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The name of the resource group. You can call <a href="https://help.aliyun.com/document_detail/449143.html">ListResources</a> to obtain the name of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>group</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>Tag-based filter conditions. Multiple conditions are separated by commas (,). Only resources that meet all the specified tag-based filter conditions are returned.</para>
        /// <para>This parameter is available only for resources whose ProductType is ACS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>system.supported.dsw=true,system.supported.dlc=true</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// <para>The operation to perform. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ListResourceByWorkspace: obtains the resources in the workspace. This is the default value.</description></item>
        /// <item><description>ListResource: obtains the resources of the user.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ListResourceByWorkspace</para>
        /// </summary>
        [NameInMap("Option")]
        [Validation(Required=false)]
        public string Option { get; set; }

        /// <summary>
        /// <para>The page number. The pages start from page 1. Default value: 1.</para>
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
        /// <para>**This field is no longer used and will be removed. Use the ResourceType field instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MaxCompute</para>
        /// </summary>
        [NameInMap("ProductTypes")]
        [Validation(Required=false)]
        public string ProductTypes { get; set; }

        /// <summary>
        /// <para>The quota IDs, which are separated by commas (,). Only resources that contain all the specified quotas are returned.</para>
        /// <remarks>
        /// <para> This parameter is available only for resources whose ResourceTypes is ACS.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>quota-k<b><b><b>da,quota-cd</b></b></b>w</para>
        /// </summary>
        [NameInMap("QuotaIds")]
        [Validation(Required=false)]
        public string QuotaIds { get; set; }

        /// <summary>
        /// <para>The resource name. The value must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name must be 3 to 28 characters in length.</description></item>
        /// <item><description>The name is unique in the region.</description></item>
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
        /// <item><description>MaxCompute</description></item>
        /// <item><description>ECS</description></item>
        /// <item><description>Lingjun</description></item>
        /// <item><description>ACS</description></item>
        /// <item><description>FLINK</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MaxCompute</para>
        /// </summary>
        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public string ResourceTypes { get; set; }

        /// <summary>
        /// <para>Specifies whether to show detailed information, which includes the Quotas field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true (default)</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Verbose")]
        [Validation(Required=false)]
        public bool? Verbose { get; set; }

        /// <summary>
        /// <para>The fields to return. Multiple fields are separated by commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Quota</description></item>
        /// <item><description>Label</description></item>
        /// <item><description>IsDefault</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Quota,IsDefault</para>
        /// </summary>
        [NameInMap("VerboseFields")]
        [Validation(Required=false)]
        public string VerboseFields { get; set; }

        /// <summary>
        /// <para>The workspace ID. You can call <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a> to obtain the workspace ID.</para>
        /// <list type="bullet">
        /// <item><description>This parameter is required when the Option parameter is set to ListResourceByWorkspace.</description></item>
        /// <item><description>You do not need to configure this parameter when the Option parameter is set to ListResource.</description></item>
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
