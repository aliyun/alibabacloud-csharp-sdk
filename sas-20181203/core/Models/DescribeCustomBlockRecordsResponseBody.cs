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
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>708</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>An array that consists of the defense rules.</para>
        /// </summary>
        [NameInMap("RecordList")]
        [Validation(Required=false)]
        public List<DescribeCustomBlockRecordsResponseBodyRecordList> RecordList { get; set; }
        public class DescribeCustomBlockRecordsResponseBodyRecordList : TeaModel {
            /// <summary>
            /// <para>The timestamp generated when the block action on the IP address becomes invalid.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1671506882063</para>
            /// </summary>
            [NameInMap("BlockExpireDate")]
            [Validation(Required=false)]
            public long? BlockExpireDate { get; set; }

            /// <summary>
            /// <para>The blocked IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>45.227.XX.XX</para>
            /// </summary>
            [NameInMap("BlockIp")]
            [Validation(Required=false)]
            public string BlockIp { get; set; }

            /// <summary>
            /// <para>The direction of the traffic that is sent by the blocked IP address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>in</b></description></item>
            /// <item><description><b>out</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>in</para>
            /// </summary>
            [NameInMap("Bound")]
            [Validation(Required=false)]
            public string Bound { get; set; }

            /// <summary>
            /// <para>The number of servers for which the defense rule is enabled.</para>
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
            /// <para>The total number of servers on which the IP address is blocked.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("ServerCount")]
            [Validation(Required=false)]
            public int? ServerCount { get; set; }

            /// <summary>
            /// <para>The source of the defense rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UserRule</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The status of the defense rule against brute-force attacks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: invalid.</description></item>
            /// <item><description><b>1</b>: enabled.</description></item>
            /// <item><description><b>2</b>: failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The servers for which the defense rule is enabled.</para>
            /// </summary>
            [NameInMap("TargetList")]
            [Validation(Required=false)]
            public List<DescribeCustomBlockRecordsResponseBodyRecordListTargetList> TargetList { get; set; }
            public class DescribeCustomBlockRecordsResponseBodyRecordListTargetList : TeaModel {
                /// <summary>
                /// <para>The ID of the destination asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>032b618f-b220-4a0d-bd37-fbdc6*******</para>
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public string Target { get; set; }

                /// <summary>
                /// <para>The type of the query. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Set the value to <b>uuid</b>.</description></item>
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
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>028CF634-5268-5660-9575-48C9ED6B7T8Y</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
