// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ListModelServicesRequest : TeaModel {
        /// <summary>
        /// <para>The model type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>system</c>: A built-in model.</para>
        /// </description></item>
        /// <item><description><para><c>deployment</c>: A model from a custom deployment.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>system</para>
        /// </summary>
        [NameInMap("modelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The cloud provider. Currently, only Alibaba Cloud is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Aliyun</para>
        /// </summary>
        [NameInMap("provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// <para>The provider type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>providerType</para>
        /// </summary>
        [NameInMap("providerType")]
        [Validation(Required=false)]
        public string ProviderType { get; set; }

        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        [NameInMap("workspaceIds")]
        [Validation(Required=false)]
        public string WorkspaceIds { get; set; }

    }

}
