// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class TextEmbeddingRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-xxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The number of embedding dimensions. The default value is the number of dimensions supported by the embedding algorithm.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The text-embedding-v3 supports 1024, 768, and 512 dimensions. Default value: 1024.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("Dimension")]
        [Validation(Required=false)]
        public int? Dimension { get; set; }

        /// <summary>
        /// <para>A list of text content to be embedded. The list length must not exceed 100.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public List<string> Input { get; set; }

        /// <summary>
        /// <para>The text embedding model. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>text-embedding-v1:1536 dimensions</description></item>
        /// <item><description>text-embedding-v2:1536 dimensions</description></item>
        /// <item><description>text-embedding-v3 (default):1024, 768, and 512 dimensions</description></item>
        /// <item><description>text2vec: 1024 dimensions</description></item>
        /// <item><description>m3e-base: 768 dimensions</description></item>
        /// <item><description>m3e-small: 512 dimensions</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>text-embedding-v2</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
