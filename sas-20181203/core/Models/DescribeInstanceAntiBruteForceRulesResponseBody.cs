// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeInstanceAntiBruteForceRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeInstanceAntiBruteForceRulesResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeInstanceAntiBruteForceRulesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of servers on which brute-force attacks defense rules take effect on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page in a paging query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The maximum number of entries per page in a paging query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of servers on which brute-force attacks defense rules take effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. The ID is a unique identifier that Alibaba Cloud generates for the request and can be used to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>97286A-4A6B-4A4-95FA-EC7E3E2451</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of servers on which brute-force attacks defense rules take effect.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<DescribeInstanceAntiBruteForceRulesResponseBodyRules> Rules { get; set; }
        public class DescribeInstanceAntiBruteForceRulesResponseBodyRules : TeaModel {
            /// <summary>
            /// <para>The ID of the brute-force attacks defense rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>215779601</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the brute-force attacks defense rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestRule</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The UUID of the server on which the brute-force attacks defense rule takes effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4fe8e1cd-3c37-4851-b9de-124da32c****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

    }

}
