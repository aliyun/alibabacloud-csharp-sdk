// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeElasticQpsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the burstable QPS.</para>
        /// </summary>
        [NameInMap("ElasticQps")]
        [Validation(Required=false)]
        public List<DescribeElasticQpsResponseBodyElasticQps> ElasticQps { get; set; }
        public class DescribeElasticQpsResponseBodyElasticQps : TeaModel {
            /// <summary>
            /// <para>The index number of the returned data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

            /// <summary>
            /// <para>The peak QPS of the normal service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("MaxNormalQps")]
            [Validation(Required=false)]
            public long? MaxNormalQps { get; set; }

            /// <summary>
            /// <para>The peak inbound QPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("MaxQps")]
            [Validation(Required=false)]
            public long? MaxQps { get; set; }

            /// <summary>
            /// <para>The total number of requests during the step size period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15104</para>
            /// </summary>
            [NameInMap("Pv")]
            [Validation(Required=false)]
            public long? Pv { get; set; }

            /// <summary>
            /// <para>The total number of HTTP 2xx status codes during the step size period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>455</para>
            /// </summary>
            [NameInMap("Status2")]
            [Validation(Required=false)]
            public long? Status2 { get; set; }

            /// <summary>
            /// <para>The total number of HTTP 3xx status codes during the step size period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Status3")]
            [Validation(Required=false)]
            public long? Status3 { get; set; }

            /// <summary>
            /// <para>The total number of HTTP 4xx status codes during the step size period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>34</para>
            /// </summary>
            [NameInMap("Status4")]
            [Validation(Required=false)]
            public long? Status4 { get; set; }

            /// <summary>
            /// <para>The total number of HTTP 5xx status codes during the step size period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status5")]
            [Validation(Required=false)]
            public long? Status5 { get; set; }

            /// <summary>
            /// <para>The total number of origin requests during the step size period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1223</para>
            /// </summary>
            [NameInMap("Ups")]
            [Validation(Required=false)]
            public long? Ups { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2E7F7F7B-39A8-5D92-BAB4-D89D9DCE7D4F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
