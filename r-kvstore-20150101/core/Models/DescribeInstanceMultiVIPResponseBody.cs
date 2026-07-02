// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeInstanceMultiVIPResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>r-8vb30e8n0m4nvu7tff.redis.zhangbei.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("MasterDns")]
        [Validation(Required=false)]
        public string MasterDns { get; set; }

        [NameInMap("MasterDnsRecord")]
        [Validation(Required=false)]
        public List<string> MasterDnsRecord { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MaxQuota")]
        [Validation(Required=false)]
        public long? MaxQuota { get; set; }

        [NameInMap("MultiVIPList")]
        [Validation(Required=false)]
        public List<DescribeInstanceMultiVIPResponseBodyMultiVIPList> MultiVIPList { get; set; }
        public class DescribeInstanceMultiVIPResponseBodyMultiVIPList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>r-bp1p4pzsr2rtubcvns-conn1.redis.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("ConnectionString")]
            [Validation(Required=false)]
            public string ConnectionString { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ABAF95F6-35C1-4177-AF3A-70969EBD****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
