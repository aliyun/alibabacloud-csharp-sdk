// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeProcessListResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the queries.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeProcessListResponseBodyItems Items { get; set; }
        public class DescribeProcessListResponseBodyItems : TeaModel {
            [NameInMap("Process")]
            [Validation(Required=false)]
            public List<DescribeProcessListResponseBodyItemsProcess> Process { get; set; }
            public class DescribeProcessListResponseBodyItemsProcess : TeaModel {
                /// <summary>
                /// <para>The type of the statement. Only SELECT can be returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SELECT</para>
                /// </summary>
                [NameInMap("Command")]
                [Validation(Required=false)]
                public string Command { get; set; }

                /// <summary>
                /// <para>The name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>adb_demo</para>
                /// </summary>
                [NameInMap("DB")]
                [Validation(Required=false)]
                public string DB { get; set; }

                /// <summary>
                /// <para>The IP address from which the query was initiated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.XX.XX:12308</para>
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <para>The ID of the worker thread.</para>
                /// 
                /// <b>Example:</b>
                /// <para>49104</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                /// <summary>
                /// <para>The SQL statement that is being executed. By default, the first 100 characters of the SQL statement are returned. If the ShowFull parameter is set to True, the complete SQL statement is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>select * from sbtest1,sbtest2,sbtest3,sbtest4</para>
                /// </summary>
                [NameInMap("Info")]
                [Validation(Required=false)]
                public string Info { get; set; }

                /// <summary>
                /// <para>The unique ID of the query. You must specify this parameter when you use the KILL PROCESS statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>202011191048151921681492420315100****</para>
                /// </summary>
                [NameInMap("ProcessId")]
                [Validation(Required=false)]
                public string ProcessId { get; set; }

                /// <summary>
                /// <para>The start time of the query. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-11-19T02:48:15Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The amount of time that has elapsed from the start time of the query. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public int? Time { get; set; }

                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("User")]
                [Validation(Required=false)]
                public string User { get; set; }

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
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The total number of pages returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
