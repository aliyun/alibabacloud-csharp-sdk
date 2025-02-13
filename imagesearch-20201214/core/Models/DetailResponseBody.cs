// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20201214.Models
{
    public class DetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the instance.</para>
        /// </summary>
        [NameInMap("Instance")]
        [Validation(Required=false)]
        public DetailResponseBodyInstance Instance { get; set; }
        public class DetailResponseBodyInstance : TeaModel {
            /// <summary>
            /// <para>The capacity of the plan. Unit: × 10,000 images.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public int? Capacity { get; set; }

            /// <summary>
            /// <para>The name of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>imagesearchName</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The number of queries per second supported by the plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Qps")]
            [Validation(Required=false)]
            public int? Qps { get; set; }

            /// <summary>
            /// <para>The information about the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The Image Search model.</para>
            /// <para>0: commodity search. 1: generic image search.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public int? ServiceType { get; set; }

            /// <summary>
            /// <para>The number of images.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10063</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            /// <summary>
            /// <para>The time when the instance was created. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1620382716000</para>
            /// </summary>
            [NameInMap("UtcCreate")]
            [Validation(Required=false)]
            public string UtcCreate { get; set; }

            /// <summary>
            /// <para>The time when the instance expires. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1623081600000</para>
            /// </summary>
            [NameInMap("UtcExpireTime")]
            [Validation(Required=false)]
            public string UtcExpireTime { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36C43E96-8F68-44AA-B1AF-B1F7AB94A6C1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
