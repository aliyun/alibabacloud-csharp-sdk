// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeHealthChecksResponseBody : TeaModel {
        [NameInMap("HealthChecks")]
        [Validation(Required=false)]
        public DescribeHealthChecksResponseBodyHealthChecks HealthChecks { get; set; }
        public class DescribeHealthChecksResponseBodyHealthChecks : TeaModel {
            [NameInMap("HealthCheck")]
            [Validation(Required=false)]
            public List<DescribeHealthChecksResponseBodyHealthChecksHealthCheck> HealthCheck { get; set; }
            public class DescribeHealthChecksResponseBodyHealthChecksHealthCheck : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DstIpAddr")]
                [Validation(Required=false)]
                public string DstIpAddr { get; set; }

                [NameInMap("DstPort")]
                [Validation(Required=false)]
                public int? DstPort { get; set; }

                [NameInMap("FailCountThreshold")]
                [Validation(Required=false)]
                public int? FailCountThreshold { get; set; }

                [NameInMap("HcInstanceId")]
                [Validation(Required=false)]
                public string HcInstanceId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ProbeCount")]
                [Validation(Required=false)]
                public int? ProbeCount { get; set; }

                [NameInMap("ProbeInterval")]
                [Validation(Required=false)]
                public int? ProbeInterval { get; set; }

                [NameInMap("ProbeTimeout")]
                [Validation(Required=false)]
                public int? ProbeTimeout { get; set; }

                [NameInMap("RelationCount")]
                [Validation(Required=false)]
                public int? RelationCount { get; set; }

                [NameInMap("RttFailThreshold")]
                [Validation(Required=false)]
                public int? RttFailThreshold { get; set; }

                [NameInMap("RttThreshold")]
                [Validation(Required=false)]
                public int? RttThreshold { get; set; }

                [NameInMap("SmartAGId")]
                [Validation(Required=false)]
                public string SmartAGId { get; set; }

                [NameInMap("SrcIpAddr")]
                [Validation(Required=false)]
                public string SrcIpAddr { get; set; }

                [NameInMap("SrcPort")]
                [Validation(Required=false)]
                public int? SrcPort { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page. Default value: <b>10</b>. Maximum value: <b>50</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B275FE6-FC86-4921-BC70-1B3DF68B078F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
