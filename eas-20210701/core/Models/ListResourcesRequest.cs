// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ListResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Desc</c>: descending order</para>
        /// </description></item>
        /// <item><description><para><c>Asc</c>: ascending order</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1. Default value: 1.</para>
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
        /// <para>The resource group ID. The <a href="https://help.aliyun.com/document_detail/412111.html">CreateResource</a> operation returns this ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eas-r-h7lcw24dyqztwxxxxxx</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The resource group name. The <a href="https://help.aliyun.com/document_detail/412111.html">CreateResource</a> operation returns this name.</para>
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
        /// <para>The resource group type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Dedicated</c>: dedicated resource group</para>
        /// </description></item>
        /// <item><description><para><c>SelfManaged</c>: self-managed resource group</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Dedicated</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The sort field. Timestamp fields are sorted in descending order by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTime</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// <para>The usage mode of the resource group. The default value is <c>inference</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>inference</para>
        /// </summary>
        [NameInMap("UsageMode")]
        [Validation(Required=false)]
        public string UsageMode { get; set; }

    }

}
