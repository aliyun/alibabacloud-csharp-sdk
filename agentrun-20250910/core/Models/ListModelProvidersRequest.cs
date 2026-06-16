// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ListModelProvidersRequest : TeaModel {
        /// <summary>
        /// <para>The name of the model to filter by.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aa</para>
        /// </summary>
        [NameInMap("modelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>The model type to filter by. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>system</c>: A system model.</para>
        /// </description></item>
        /// <item><description><para><c>deployment</c>: A custom deployment model.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pop</para>
        /// </summary>
        [NameInMap("modelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        /// <summary>
        /// <para>The page number to retrieve.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of results to return per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The cloud provider. To specify Alibaba Cloud, use the value \&quot;Aliyun\&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Aliyun</para>
        /// </summary>
        [NameInMap("provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

    }

}
