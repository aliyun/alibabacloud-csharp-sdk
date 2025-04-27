// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListEcsInstancesRequest : TeaModel {
        /// <summary>
        /// <para>test</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;i-bp13y63575oypr9d****&quot;,&quot;i-bp1gyhphjaj73jsr****&quot;]</para>
        /// </summary>
        [NameInMap("ecsInstanceIds")]
        [Validation(Required=false)]
        public string EcsInstanceIds { get; set; }

        /// <summary>
        /// <para>[{ &quot;tagKey&quot;:&quot;a&quot;,&quot;tagValue&quot;:&quot;b&quot;}]</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ecsInstanceName")]
        [Validation(Required=false)]
        public string EcsInstanceName { get; set; }

        /// <summary>
        /// <para>10</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>[&quot;i-bp13y63575oypr9d\<em>\</em>\<em>\</em>&quot;,&quot;i-bp1gyhphjaj73jsr\<em>\</em>\<em>\</em>&quot;]</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <para>vpc-bp16k1dvzxtmagcva\<em>\</em>\<em>\</em></para>
        /// 
        /// <b>Example:</b>
        /// <para>[{ &quot;tagKey&quot;:&quot;a&quot;,&quot;tagValue&quot;:&quot;b&quot;}]</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp16k1dvzxtmagcva****</para>
        /// </summary>
        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
