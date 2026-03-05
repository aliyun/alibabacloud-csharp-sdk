// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeSlowLogRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The database engine that the instance runs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Redis</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp10n********</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeSlowLogRecordsResponseBodyItems Items { get; set; }
        public class DescribeSlowLogRecordsResponseBodyItems : TeaModel {
            [NameInMap("LogRecords")]
            [Validation(Required=false)]
            public List<DescribeSlowLogRecordsResponseBodyItemsLogRecords> LogRecords { get; set; }
            public class DescribeSlowLogRecordsResponseBodyItemsLogRecords : TeaModel {
                [NameInMap("Account")]
                [Validation(Required=false)]
                public string Account { get; set; }

                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                [NameInMap("Command")]
                [Validation(Required=false)]
                public string Command { get; set; }

                [NameInMap("DBName")]
                [Validation(Required=false)]
                public string DBName { get; set; }

                [NameInMap("DataBaseName")]
                [Validation(Required=false)]
                public string DataBaseName { get; set; }

                [NameInMap("ElapsedTime")]
                [Validation(Required=false)]
                public long? ElapsedTime { get; set; }

                [NameInMap("ExecuteTime")]
                [Validation(Required=false)]
                public string ExecuteTime { get; set; }

                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

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
        /// <para>The number of log entries returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The maximum number of log entries returned per page.</para>
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
        /// <para>686BB8A6-BBA5-47E5-8A75-D2ADE433****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start time of the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-03-10T13:11Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The total number of returned log entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
