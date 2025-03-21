// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeLakeCacheSizeResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. The value 200 indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeLakeCacheSizeResponseBodyData Data { get; set; }
        public class DescribeLakeCacheSizeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The size of the lake cache space. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public long? Capacity { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>amv-bp10b6646l07akdt</para>
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// <para>The size of the data that occupies the lake cache space. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("DataSize")]
            [Validation(Required=false)]
            public long? DataSize { get; set; }

            /// <summary>
            /// <para>Indicates whether the lake cache feature is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableLakeCache")]
            [Validation(Required=false)]
            public bool? EnableLakeCache { get; set; }

            /// <summary>
            /// <para>The clusters that share the lake cache space.</para>
            /// </summary>
            [NameInMap("Instances")]
            [Validation(Required=false)]
            public List<string> Instances { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
