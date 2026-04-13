// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeErrorLogRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The database engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MongoDB</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeErrorLogRecordsResponseBodyItems Items { get; set; }
        public class DescribeErrorLogRecordsResponseBodyItems : TeaModel {
            [NameInMap("LogRecords")]
            [Validation(Required=false)]
            public List<DescribeErrorLogRecordsResponseBodyItemsLogRecords> LogRecords { get; set; }
            public class DescribeErrorLogRecordsResponseBodyItemsLogRecords : TeaModel {
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("ConnInfo")]
                [Validation(Required=false)]
                public string ConnInfo { get; set; }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

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
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68BCBEC2-1E66-471F-A1A8-E3C60C0A80B0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
