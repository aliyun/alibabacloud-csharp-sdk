// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeUserConnectionRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The connection records.</para>
        /// </summary>
        [NameInMap("ConnectionRecords")]
        [Validation(Required=false)]
        public List<DescribeUserConnectionRecordsResponseBodyConnectionRecords> ConnectionRecords { get; set; }
        public class DescribeUserConnectionRecordsResponseBodyConnectionRecords : TeaModel {
            /// <summary>
            /// <para>The connection duration. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3405035000</para>
            /// </summary>
            [NameInMap("ConnectDuration")]
            [Validation(Required=false)]
            public string ConnectDuration { get; set; }

            /// <summary>
            /// <para>The time when the end user disconnected from the cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-02-27T20:03:13Z</para>
            /// </summary>
            [NameInMap("ConnectEndTime")]
            [Validation(Required=false)]
            public string ConnectEndTime { get; set; }

            /// <summary>
            /// <para>The time when the end user connected to the cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-19T10:12:38Z</para>
            /// </summary>
            [NameInMap("ConnectStartTime")]
            [Validation(Required=false)]
            public string ConnectStartTime { get; set; }

            /// <summary>
            /// <para>The ID of the connection record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>528</para>
            /// </summary>
            [NameInMap("ConnectionRecordId")]
            [Validation(Required=false)]
            public string ConnectionRecordId { get; set; }

            /// <summary>
            /// <para>The ID of the cloud computer to which the end user connected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ud-2hawufy3uedi1****</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <para>The name of the cloud computer to which the end user connected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testName</para>
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

        }

        /// <summary>
        /// <para>The token that is used to start the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2CC66B0A-BA3B-5D87-BFBE-11AAAD7A8E03</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
