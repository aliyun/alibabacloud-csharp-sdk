// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>A2RN</para>
        /// 
        /// <b>Example:</b>
        /// <para>A2RN</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>cn-beijing</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>[&quot;d42921c4-5433-4abd-8075-0e536f8b\<em>\</em>\<em>\</em>&quot;]</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;d42921c4-5433-4abd-8075-0e536f8b****&quot;]</para>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public string ResourceIds { get; set; }

        /// <summary>
        /// <para>application</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>application</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>[{&quot;key&quot;:&quot;k1&quot;,&quot;value&quot;:&quot;v1&quot;}]</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;key&quot;:&quot;k1&quot;,&quot;value&quot;:&quot;v1&quot;}]</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
