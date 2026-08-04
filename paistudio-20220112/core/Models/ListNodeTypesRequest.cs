// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ListNodeTypesRequest : TeaModel {
        /// <summary>
        /// <para>The accelerator type used to filter the results. Valid values: <c>CPU</c> and <c>GPU</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GPU</para>
        /// </summary>
        [NameInMap("AcceleratorType")]
        [Validation(Required=false)]
        public string AcceleratorType { get; set; }

        /// <summary>
        /// <para>The GPU type used to filter the results. Fuzzy matching is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A10</para>
        /// </summary>
        [NameInMap("GPUType")]
        [Validation(Required=false)]
        public string GPUType { get; set; }

        /// <summary>
        /// <para>A comma-separated list of node types. If omitted, all node types are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.c6.large,ecs.gn7i-c32g1.8xlarge</para>
        /// </summary>
        [NameInMap("NodeTypes")]
        [Validation(Required=false)]
        public string NodeTypes { get; set; }

        /// <summary>
        /// <para>The quota ID. You must specify either this parameter or <c>ResourceGroupIds</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quota123</para>
        /// </summary>
        [NameInMap("QuotaId")]
        [Validation(Required=false)]
        public string QuotaId { get; set; }

        /// <summary>
        /// <para>A comma-separated list of resource group IDs. You must specify either this parameter or <c>QuotaId</c>. The <c>UserId</c> for the specified <c>ResourceGroupId</c> must match the <c>UserId</c> of the requesting user. All specified <c>resource group</c> instances must be of the same type and associated with the same Virtual Private Cloud (VPC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg123,rg456</para>
        /// </summary>
        [NameInMap("ResourceGroupIds")]
        [Validation(Required=false)]
        public string ResourceGroupIds { get; set; }

    }

}
