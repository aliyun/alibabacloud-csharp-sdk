// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeInstanceStatusRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Anti-DDoS Proxy instance to query.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/157459.html">DescribeInstanceIds</a> operation to query the IDs of all Anti-DDoS Proxy (Chinese Mainland) or Anti-DDoS Proxy (Outside Chinese Mainland) instances.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddoscoo-cn-6ja1y6p5****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The type of the Anti-DDoS Proxy instance to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: an Anti-DDoS Proxy (Chinese Mainland) instance</description></item>
        /// <item><description><b>2</b>: an Anti-DDoS Proxy (Outside Chinese Mainland) instance</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public int? ProductType { get; set; }

    }

}
