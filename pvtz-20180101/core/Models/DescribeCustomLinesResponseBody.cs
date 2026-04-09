// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeCustomLinesResponseBody : TeaModel {
        [NameInMap("CustomLines")]
        [Validation(Required=false)]
        public DescribeCustomLinesResponseBodyCustomLines CustomLines { get; set; }
        public class DescribeCustomLinesResponseBodyCustomLines : TeaModel {
            [NameInMap("CustomLine")]
            [Validation(Required=false)]
            public List<DescribeCustomLinesResponseBodyCustomLinesCustomLine> CustomLine { get; set; }
            public class DescribeCustomLinesResponseBodyCustomLinesCustomLine : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                [NameInMap("CreatorSubType")]
                [Validation(Required=false)]
                public string CreatorSubType { get; set; }

                [NameInMap("CreatorType")]
                [Validation(Required=false)]
                public string CreatorType { get; set; }

                [NameInMap("DnsCategory")]
                [Validation(Required=false)]
                public string DnsCategory { get; set; }

                [NameInMap("Ipv4s")]
                [Validation(Required=false)]
                public DescribeCustomLinesResponseBodyCustomLinesCustomLineIpv4s Ipv4s { get; set; }
                public class DescribeCustomLinesResponseBodyCustomLinesCustomLineIpv4s : TeaModel {
                    [NameInMap("Ipv4")]
                    [Validation(Required=false)]
                    public List<string> Ipv4 { get; set; }

                }

                [NameInMap("LineId")]
                [Validation(Required=false)]
                public string LineId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number. Pages start from page <b>1</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: <b>1 to 100</b>. Default value: <b>10</b>.</para>
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
        /// <para>AF7D4DCE-0776-47F2-A9B2-6FB85A87AA60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// <para>The total number of returned pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
