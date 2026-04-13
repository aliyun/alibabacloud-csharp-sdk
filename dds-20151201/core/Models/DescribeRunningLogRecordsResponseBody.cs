// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeRunningLogRecordsResponseBody : TeaModel {
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
        public DescribeRunningLogRecordsResponseBodyItems Items { get; set; }
        public class DescribeRunningLogRecordsResponseBodyItems : TeaModel {
            [NameInMap("LogRecords")]
            [Validation(Required=false)]
            public List<DescribeRunningLogRecordsResponseBodyItemsLogRecords> LogRecords { get; set; }
            public class DescribeRunningLogRecordsResponseBodyItemsLogRecords : TeaModel {
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

            }

        }

        /// <summary>
        /// <para>The number of the page to return.</para>
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
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>45D2B592-DEBA-4347-BBF3-47FF6C97DBBC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
