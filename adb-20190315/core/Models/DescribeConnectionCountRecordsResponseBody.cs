// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeConnectionCountRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried client IP addresses.</para>
        /// </summary>
        [NameInMap("AccessIpRecords")]
        [Validation(Required=false)]
        public List<DescribeConnectionCountRecordsResponseBodyAccessIpRecords> AccessIpRecords { get; set; }
        public class DescribeConnectionCountRecordsResponseBodyAccessIpRecords : TeaModel {
            /// <summary>
            /// <para>The IP address of the client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>42.120.XX.XX</para>
            /// </summary>
            [NameInMap("AccessIp")]
            [Validation(Required=false)]
            public string AccessIp { get; set; }

            /// <summary>
            /// <para>The number of connections.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

        }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp1jj9xqft1po****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>562C7F89-FBE6-4A04-AAAA-7EBC25******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The queried database accounts.</para>
        /// </summary>
        [NameInMap("UserRecords")]
        [Validation(Required=false)]
        public List<DescribeConnectionCountRecordsResponseBodyUserRecords> UserRecords { get; set; }
        public class DescribeConnectionCountRecordsResponseBodyUserRecords : TeaModel {
            /// <summary>
            /// <para>The number of connections.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The username of the database account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

    }

}
