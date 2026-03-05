// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeAuditRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The end time of the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-03-25T12:10:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The name of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeAuditRecordsResponseBodyItems Items { get; set; }
        public class DescribeAuditRecordsResponseBodyItems : TeaModel {
            [NameInMap("SQL")]
            [Validation(Required=false)]
            public List<DescribeAuditRecordsResponseBodyItemsSQL> SQL { get; set; }
            public class DescribeAuditRecordsResponseBodyItemsSQL : TeaModel {
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                [NameInMap("DatabaseName")]
                [Validation(Required=false)]
                public string DatabaseName { get; set; }

                [NameInMap("ExecuteTime")]
                [Validation(Required=false)]
                public string ExecuteTime { get; set; }

                [NameInMap("HostAddress")]
                [Validation(Required=false)]
                public string HostAddress { get; set; }

                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                [NameInMap("SQLText")]
                [Validation(Required=false)]
                public string SQLText { get; set; }

                [NameInMap("SQLType")]
                [Validation(Required=false)]
                public string SQLType { get; set; }

                [NameInMap("TotalExecutionTimes")]
                [Validation(Required=false)]
                public string TotalExecutionTimes { get; set; }

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
        /// <para>The maximum number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9F5EB478-824E-4AC4-8D2B-58F31A02****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start time of the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-03-24T12:10:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22222</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
