// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListEcsInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The list of ECS instance IDs. The value can be a JSON array that consists of up to 100 instance IDs separated by commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;i-bp13y63575oypr9d****&quot;,&quot;i-bp1gyhphjaj73jsr****&quot;]</para>
        /// </summary>
        [NameInMap("ecsInstanceIds")]
        [Validation(Required=false)]
        public string EcsInstanceIds { get; set; }

        /// <summary>
        /// <para>The ECS instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ecsInstanceName")]
        [Validation(Required=false)]
        public string EcsInstanceName { get; set; }

        /// <summary>
        /// <para>The page number of the returned results. Maximum value: 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The number of results per page. Default value: 10. Maximum value: 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <para>The ECS instance tags. The following fields must be included:</para>
        /// <list type="bullet">
        /// <item><description>tagKey: the tag key.</description></item>
        /// <item><description>tagValue: the tag value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{ &quot;tagKey&quot;:&quot;a&quot;,&quot;tagValue&quot;:&quot;b&quot;}]</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>The VPC ID of the ECS instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp16k1dvzxtmagcva****</para>
        /// </summary>
        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
