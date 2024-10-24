// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeInstanceIdsRequest : TeaModel {
        /// <summary>
        /// <para>The type of the instance to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Anti-DDoS Proxy (Outside Chinese Mainland) instance of the Insurance mitigation plan</description></item>
        /// <item><description><b>1</b>: Anti-DDoS Proxy (Outside Chinese Mainland) instance of the Unlimited mitigation plan</description></item>
        /// <item><description><b>2</b>: Anti-DDoS Proxy (Outside Chinese Mainland) instance of the Chinese Mainland Acceleration (CMA) mitigation plan</description></item>
        /// <item><description><b>3</b>: Anti-DDoS Proxy (Outside Chinese Mainland) instance of the Secure Chinese Mainland Acceleration (Sec-CMA) mitigation plan</description></item>
        /// <item><description><b>9</b>: Anti-DDoS Proxy (Chinese Mainland) instance of the Profession mitigation plan</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("Edition")]
        [Validation(Required=false)]
        public int? Edition { get; set; }

        /// <summary>
        /// <para>The IDs of instances to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddoscoo-cn-mp91j1ao****</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-acfm2pz25js****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
