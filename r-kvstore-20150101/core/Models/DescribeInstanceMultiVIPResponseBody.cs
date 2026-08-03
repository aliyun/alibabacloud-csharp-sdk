// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeInstanceMultiVIPResponseBody : TeaModel {
        /// <summary>
        /// <para>The IP address of the primary DNS server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-8vb30e8n0m4nvu7tff.redis.zhangbei.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("MasterDns")]
        [Validation(Required=false)]
        public string MasterDns { get; set; }

        /// <summary>
        /// <para>The list of IP addresses corresponding to all LBs of the current instance.</para>
        /// </summary>
        [NameInMap("MasterDnsRecord")]
        [Validation(Required=false)]
        public List<string> MasterDnsRecord { get; set; }

        /// <summary>
        /// <para>The maximum number of VIPs that can be created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MaxQuota")]
        [Validation(Required=false)]
        public long? MaxQuota { get; set; }

        /// <summary>
        /// <para>The list of multiple LB VIPs.</para>
        /// </summary>
        [NameInMap("MultiVIPList")]
        [Validation(Required=false)]
        public List<DescribeInstanceMultiVIPResponseBodyMultiVIPList> MultiVIPList { get; set; }
        public class DescribeInstanceMultiVIPResponseBodyMultiVIPList : TeaModel {
            /// <summary>
            /// <para>The endpoint of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>r-bp1p4pzsr2rtubcvns-conn1.redis.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("ConnectionString")]
            [Validation(Required=false)]
            public string ConnectionString { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABAF95F6-35C1-4177-AF3A-70969EBD****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
