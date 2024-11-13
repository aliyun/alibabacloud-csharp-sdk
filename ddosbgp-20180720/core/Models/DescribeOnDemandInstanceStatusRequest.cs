// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeOnDemandInstanceStatusRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the anti-DDoS diversion instances.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/152120.html">DescribeOnDemandInstance</a> operation to query the IDs of all anti-DDoS diversion instances.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddosbgp-cn-z2q1qzxb****</para>
        /// </summary>
        [NameInMap("InstanceIdList")]
        [Validation(Required=false)]
        public List<string> InstanceIdList { get; set; }

        /// <summary>
        /// <para>The region ID of the anti-DDoS diversion instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/118703.html">DescribeRegions</a> operation to query all regions that are supported by Anti-DDoS Origin.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-zhangjiakou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
