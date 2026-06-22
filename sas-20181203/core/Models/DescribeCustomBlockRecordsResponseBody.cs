// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCustomBlockRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeCustomBlockRecordsResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeCustomBlockRecordsResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page in a paged query during paging.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The maximum number of entries returned per page in a paged query during paging.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>708</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The list of policy records.</para>
        /// </summary>
        [NameInMap("RecordList")]
        [Validation(Required=false)]
        public List<DescribeCustomBlockRecordsResponseBodyRecordList> RecordList { get; set; }
        public class DescribeCustomBlockRecordsResponseBodyRecordList : TeaModel {
            /// <summary>
            /// <para>The UNIX timestamp when the brute-force attacks IP blocking expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1671506882063</para>
            /// </summary>
            [NameInMap("BlockExpireDate")]
            [Validation(Required=false)]
            public long? BlockExpireDate { get; set; }

            /// <summary>
            /// <para>The IP address blocked for brute-force attacks prevention.</para>
            /// 
            /// <b>Example:</b>
            /// <para>45.227.XX.XX</para>
            /// </summary>
            [NameInMap("BlockIp")]
            [Validation(Required=false)]
            public string BlockIp { get; set; }

            /// <summary>
            /// <para>The direction in which the server brute-force attacks interception policy blocks the IP address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>in</b>: inbound</description></item>
            /// <item><description><b>out</b>: outbound.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>in</para>
            /// </summary>
            [NameInMap("Bound")]
            [Validation(Required=false)]
            public string Bound { get; set; }

            /// <summary>
            /// <para>The number of servers on which the blocking rule has taken effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("EnableCount")]
            [Validation(Required=false)]
            public int? EnableCount { get; set; }

            /// <summary>
            /// <para>The record ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>353376</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The total number of servers on which the blocked IP record needs to take effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("ServerCount")]
            [Validation(Required=false)]
            public int? ServerCount { get; set; }

            /// <summary>
            /// <para>The source from which the rule was delivered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UserRule</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The status of the brute-force attacks defense rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Invalid.</description></item>
            /// <item><description><b>1</b>: Enabled.</description></item>
            /// <item><description><b>2</b>: Failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The servers on which the rule takes effect.</para>
            /// </summary>
            [NameInMap("TargetList")]
            [Validation(Required=false)]
            public List<DescribeCustomBlockRecordsResponseBodyRecordListTargetList> TargetList { get; set; }
            public class DescribeCustomBlockRecordsResponseBodyRecordListTargetList : TeaModel {
                /// <summary>
                /// <para>The ID of the specified target asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>032b618f-b220-4a0d-bd37-fbdc6*******</para>
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public string Target { get; set; }

                /// <summary>
                /// <para>The query type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>uuid</b>: asset ID.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>uuid</para>
                /// </summary>
                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>028CF634-5268-5660-9575-48C9ED6B7T8Y</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
