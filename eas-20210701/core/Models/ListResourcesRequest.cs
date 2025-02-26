// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ListResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The sorting order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Desc</description></item>
        /// <item><description>Asc</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. You can call the <a href="https://help.aliyun.com/document_detail/412111.html">CreateResource</a> operation to query the ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eas-r-h7lcw24dyqztwxxxxxx</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The name of the resource group. You can call the <a href="https://help.aliyun.com/document_detail/412111.html">CreateResource</a> operation to query the name of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyResource</para>
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// <para>The resource group status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ResourceReady</para>
        /// </summary>
        [NameInMap("ResourceStatus")]
        [Validation(Required=false)]
        public string ResourceStatus { get; set; }

        /// <summary>
        /// <para>The type of the resource group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Dedicated: the dedicated resource group.</description></item>
        /// <item><description>SelfManaged: the self-managed resource group.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Dedicated</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The condition by which the results are sorted. By default, the query results are sorted by the timestamp type in descending order.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PrePaidInstanceCount</description></item>
        /// <item><description>CpuCount</description></item>
        /// <item><description>Memory</description></item>
        /// <item><description>CreateTime</description></item>
        /// <item><description>PostPaidInstanceCount</description></item>
        /// <item><description>MemoryUsed</description></item>
        /// <item><description>GpuCount</description></item>
        /// <item><description>GpuUsed</description></item>
        /// <item><description>CpuUsed</description></item>
        /// <item><description>ServiceCount</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTime</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

    }

}
