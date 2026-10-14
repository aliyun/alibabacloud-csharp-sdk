// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyElasticBandWidthRequest : TeaModel {
        /// <summary>
        /// <para>The burstable protection bandwidth that you want to set. Unit: Gbps.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/91502.html">DescribeElasticBandwidthSpec</a> to query the available burstable protection bandwidth specifications.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("ElasticBandwidth")]
        [Validation(Required=false)]
        public int? ElasticBandwidth { get; set; }

        /// <summary>
        /// <para>The ID of the Anti-DDoS Pro or Anti-DDoS Premium instance.</para>
        /// <remarks>
        /// <para>The instance must be in a normal state. You can call <a href="https://help.aliyun.com/document_detail/157459.html">DescribeInstanceIds</a> to query the IDs of all Anti-DDoS Pro or Anti-DDoS Premium instances.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddoscoo-cn-mp91j1ao****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
