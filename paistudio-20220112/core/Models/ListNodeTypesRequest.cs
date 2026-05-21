// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ListNodeTypesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>GPU</para>
        /// </summary>
        [NameInMap("AcceleratorType")]
        [Validation(Required=false)]
        public string AcceleratorType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A10</para>
        /// </summary>
        [NameInMap("GPUType")]
        [Validation(Required=false)]
        public string GPUType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ecs.c6.large,ecs.gn7i-c32g1.8xlarge</para>
        /// </summary>
        [NameInMap("NodeTypes")]
        [Validation(Required=false)]
        public string NodeTypes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>quota123</para>
        /// </summary>
        [NameInMap("QuotaId")]
        [Validation(Required=false)]
        public string QuotaId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg123,rg456</para>
        /// </summary>
        [NameInMap("ResourceGroupIds")]
        [Validation(Required=false)]
        public string ResourceGroupIds { get; set; }

    }

}
