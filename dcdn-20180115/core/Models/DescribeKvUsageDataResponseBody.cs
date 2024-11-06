// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeKvUsageDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The end of the time range during which data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-11-18T15:59:59Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The usage details.</para>
        /// </summary>
        [NameInMap("KvUsageData")]
        [Validation(Required=false)]
        public List<DescribeKvUsageDataResponseBodyKvUsageData> KvUsageData { get; set; }
        public class DescribeKvUsageDataResponseBodyKvUsageData : TeaModel {
            /// <summary>
            /// <para>The number of visits.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1340000</para>
            /// </summary>
            [NameInMap("Acc")]
            [Validation(Required=false)]
            public long? Acc { get; set; }

            /// <summary>
            /// <para>The request method. This parameter is available only when the <b>SplitBy</b> parameter is set to <b>type</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>get</para>
            /// </summary>
            [NameInMap("AccessType")]
            [Validation(Required=false)]
            public string AccessType { get; set; }

            /// <summary>
            /// <para>The namespace ID. This parameter is available only when the <b>SplitBy</b> parameter is set to <b>namespace</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>534167033424646144</para>
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            /// <summary>
            /// <para>The timestamp of the data returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-14T15:00:03Z</para>
            /// </summary>
            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9732E117-8A37-49FD-A36F-ABBB87556CA7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range during which data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-11-06T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
