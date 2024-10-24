// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyElasticBizQpsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Anti-DDoS Proxy instance.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/157459.html">DescribeInstanceIds</a> operation to query the IDs of all instances.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddoscoo-cn-mp91j1ao****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The metering method for the burstable QPS. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>month</b>: monthly 95th percentile</description></item>
        /// <item><description><b>day</b>: daily 95th percentile QPS</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>month</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The burstable QPS value.</para>
        /// <remarks>
        /// <para> The default value is 300,000 for the Chinese mainland and 150,000 for regions outside the Chinese mainland.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>300000</para>
        /// </summary>
        [NameInMap("OpsElasticQps")]
        [Validation(Required=false)]
        public long? OpsElasticQps { get; set; }

    }

}
