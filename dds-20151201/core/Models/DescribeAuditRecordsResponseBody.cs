// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeAuditRecordsResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeAuditRecordsResponseBodyItems Items { get; set; }
        public class DescribeAuditRecordsResponseBodyItems : TeaModel {
            [NameInMap("SQLRecord")]
            [Validation(Required=false)]
            public List<DescribeAuditRecordsResponseBodyItemsSQLRecord> SQLRecord { get; set; }
            public class DescribeAuditRecordsResponseBodyItemsSQLRecord : TeaModel {
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                [NameInMap("DBName")]
                [Validation(Required=false)]
                public string DBName { get; set; }

                [NameInMap("ExecuteTime")]
                [Validation(Required=false)]
                public string ExecuteTime { get; set; }

                [NameInMap("HostAddress")]
                [Validation(Required=false)]
                public string HostAddress { get; set; }

                [NameInMap("ReturnRowCounts")]
                [Validation(Required=false)]
                public long? ReturnRowCounts { get; set; }

                [NameInMap("Syntax")]
                [Validation(Required=false)]
                public string Syntax { get; set; }

                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                [NameInMap("ThreadID")]
                [Validation(Required=false)]
                public string ThreadID { get; set; }

                [NameInMap("TotalExecutionTimes")]
                [Validation(Required=false)]
                public long? TotalExecutionTimes { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of entries on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3278BEB8-503B-4E46-8F7E-D26E040C9769</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
