// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListVersionsResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataNotExists</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Business data</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListVersionsResponseBodyData> Data { get; set; }
        public class ListVersionsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Concurrency</para>
            /// 
            /// <b>Example:</b>
            /// <para>43</para>
            /// </summary>
            [NameInMap("ConcurrentCount")]
            [Validation(Required=false)]
            public int? ConcurrentCount { get; set; }

            /// <summary>
            /// <para>Service expiration time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-23 02:00:34</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>Number of instances</para>
            /// 
            /// <b>Example:</b>
            /// <para>55</para>
            /// </summary>
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public int? InstanceCount { get; set; }

            /// <summary>
            /// <para>Instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>ga-bp12pismsw4v3tzhf62p1</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Order ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            /// <summary>
            /// <para>Version type (TRIAL: trial edition, STANDARD: Standard Edition, CUSTOMIZE: custom edition)</para>
            /// 
            /// <b>Example:</b>
            /// <para>CUSTOMIZE</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <para>Trial edition quota</para>
            /// 
            /// <b>Example:</b>
            /// <para>13</para>
            /// </summary>
            [NameInMap("Quota")]
            [Validation(Required=false)]
            public int? Quota { get; set; }

            /// <summary>
            /// <para>Service start time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-05-27 04:11:00</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>Trial edition usage count</para>
            /// 
            /// <b>Example:</b>
            /// <para>65</para>
            /// </summary>
            [NameInMap("UseQuota")]
            [Validation(Required=false)]
            public int? UseQuota { get; set; }

            /// <summary>
            /// <para>Version details</para>
            /// 
            /// <b>Example:</b>
            /// <para>标准版-公共并发：1并发</para>
            /// </summary>
            [NameInMap("VersionDetail")]
            [Validation(Required=false)]
            public string VersionDetail { get; set; }

            /// <summary>
            /// <para>Version</para>
            /// 
            /// <b>Example:</b>
            /// <para>试用版</para>
            /// </summary>
            [NameInMap("VersionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

            /// <summary>
            /// <para>Validity status: 0 indicates active, 1 indicates expired (go to the renewal page), and 2 indicates unavailable (go to the purchase page)</para>
            /// 
            /// <b>Example:</b>
            /// <para>87</para>
            /// </summary>
            [NameInMap("VersionStatus")]
            [Validation(Required=false)]
            public int? VersionStatus { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>数据不存在</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates success: true for success, false for failure</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
