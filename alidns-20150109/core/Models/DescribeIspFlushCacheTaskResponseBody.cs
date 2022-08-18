// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeIspFlushCacheTaskResponseBody : TeaModel {
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("FlushCacheResults")]
        [Validation(Required=false)]
        public List<DescribeIspFlushCacheTaskResponseBodyFlushCacheResults> FlushCacheResults { get; set; }
        public class DescribeIspFlushCacheTaskResponseBodyFlushCacheResults : TeaModel {
            [NameInMap("DnsNodes")]
            [Validation(Required=false)]
            public List<DescribeIspFlushCacheTaskResponseBodyFlushCacheResultsDnsNodes> DnsNodes { get; set; }
            public class DescribeIspFlushCacheTaskResponseBodyFlushCacheResultsDnsNodes : TeaModel {
                [NameInMap("Answers")]
                [Validation(Required=false)]
                public List<DescribeIspFlushCacheTaskResponseBodyFlushCacheResultsDnsNodesAnswers> Answers { get; set; }
                public class DescribeIspFlushCacheTaskResponseBodyFlushCacheResultsDnsNodesAnswers : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Record")]
                    [Validation(Required=false)]
                    public string Record { get; set; }

                    [NameInMap("Ttl")]
                    [Validation(Required=false)]
                    public long? Ttl { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("NodeIp")]
                [Validation(Required=false)]
                public string NodeIp { get; set; }

                [NameInMap("SpName")]
                [Validation(Required=false)]
                public string SpName { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

        }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

    }

}
