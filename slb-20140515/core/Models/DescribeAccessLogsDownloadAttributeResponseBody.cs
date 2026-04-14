// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeAccessLogsDownloadAttributeResponseBody : TeaModel {
        [NameInMap("LogsDownloadAttributes")]
        [Validation(Required=false)]
        public DescribeAccessLogsDownloadAttributeResponseBodyLogsDownloadAttributes LogsDownloadAttributes { get; set; }
        public class DescribeAccessLogsDownloadAttributeResponseBodyLogsDownloadAttributes : TeaModel {
            [NameInMap("LogsDownloadAttribute")]
            [Validation(Required=false)]
            public List<DescribeAccessLogsDownloadAttributeResponseBodyLogsDownloadAttributesLogsDownloadAttribute> LogsDownloadAttribute { get; set; }
            public class DescribeAccessLogsDownloadAttributeResponseBodyLogsDownloadAttributesLogsDownloadAttribute : TeaModel {
                [NameInMap("LoadBalancerId")]
                [Validation(Required=false)]
                public string LoadBalancerId { get; set; }

                [NameInMap("LogProject")]
                [Validation(Required=false)]
                public string LogProject { get; set; }

                [NameInMap("LogStore")]
                [Validation(Required=false)]
                public string LogStore { get; set; }

                [NameInMap("LogType")]
                [Validation(Required=false)]
                public string LogType { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8B9DB03B-ED39-5DB8-9C9F-1ED5F548D61E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
