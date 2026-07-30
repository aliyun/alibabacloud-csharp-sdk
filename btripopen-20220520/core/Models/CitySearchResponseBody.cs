// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CitySearchResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The response data. A non-null value is returned for a successful request. Null is returned for a failed request.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public CitySearchResponseBodyModule Module { get; set; }
        public class CitySearchResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The list of cities. An empty array [] is returned if no results are found.</para>
            /// </summary>
            [NameInMap("cities")]
            [Validation(Required=false)]
            public List<CitySearchResponseBodyModuleCities> Cities { get; set; }
            public class CitySearchResponseBodyModuleCities : TeaModel {
                /// <summary>
                /// <para>The city code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>330100</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The city name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The region type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: domestic.</description></item>
                /// <item><description>1: international.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("region")]
                [Validation(Required=false)]
                public int? Region { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5009956-1077-52FB-B520-EA8C7E91D722</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID of the log.</para>
        /// 
        /// <b>Example:</b>
        /// <para>210f079e16603757182131635d866a</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
