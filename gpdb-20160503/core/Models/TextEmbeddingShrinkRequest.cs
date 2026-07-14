// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class TextEmbeddingShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-xxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The vector dimensions. Default value: the dimensions supported by the embedding model.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>text-embedding-v3 supports 1024, 768, and 512 dimensions. Default value: 1024.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("Dimension")]
        [Validation(Required=false)]
        public int? Dimension { get; set; }

        /// <summary>
        /// <para>The list of text content to vectorize. The list can contain up to 100 entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>What is ADBPG?</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string InputShrink { get; set; }

        /// <summary>
        /// <para>The embedding model. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>text-embedding-v1: 1536 dimensions</description></item>
        /// <item><description>text-embedding-v2: 1536 dimensions</description></item>
        /// <item><description>text-embedding-v3 (default): 1024, 768, or 512 dimensions</description></item>
        /// <item><description>text2vec (not recommended): 1024 dimensions</description></item>
        /// <item><description>m3e-base (not recommended): 768 dimensions</description></item>
        /// <item><description>m3e-small (not recommended): 512 dimensions</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>text-embedding-v3</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
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
