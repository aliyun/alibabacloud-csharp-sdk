// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeSensitiveRequestsResponseBody : TeaModel {
        /// <summary>
        /// <para>The tracing results of the data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeSensitiveRequestsResponseBodyData> Data { get; set; }
        public class DescribeSensitiveRequestsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of risks in the previous 30 days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("AbnormalCount")]
            [Validation(Required=false)]
            public long? AbnormalCount { get; set; }

            /// <summary>
            /// <para>The API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/api/users/login</para>
            /// </summary>
            [NameInMap("ApiFormat")]
            [Validation(Required=false)]
            public string ApiFormat { get; set; }

            /// <summary>
            /// <para>The ID of the API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>09559c0d71ca2ffc996b81***836d8</para>
            /// </summary>
            [NameInMap("ApiId")]
            [Validation(Required=false)]
            public string ApiId { get; set; }

            /// <summary>
            /// <para>The IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>103.118.55.**</para>
            /// </summary>
            [NameInMap("ClientIP")]
            [Validation(Required=false)]
            public string ClientIP { get; set; }

            /// <summary>
            /// <para>The evaluation result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>leak</b>: Data leaks may occur.</description></item>
            /// <item><description><b>none</b>: No data leak can occur.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>leak</para>
            /// </summary>
            [NameInMap("DetectionResult")]
            [Validation(Required=false)]
            public string DetectionResult { get; set; }

            /// <summary>
            /// <para>The number of events in the previous 30 days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>679</para>
            /// </summary>
            [NameInMap("EventCount")]
            [Validation(Required=false)]
            public long? EventCount { get; set; }

            /// <summary>
            /// <para>The statistics of the sensitive data.</para>
            /// </summary>
            [NameInMap("InfoCount")]
            [Validation(Required=false)]
            public List<DescribeSensitiveRequestsResponseBodyDataInfoCount> InfoCount { get; set; }
            public class DescribeSensitiveRequestsResponseBodyDataInfoCount : TeaModel {
                /// <summary>
                /// <para>The type of the sensitive data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1001</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The number of sensitive data entries.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

            }

            /// <summary>
            /// <para>The domain name of the API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a.****.com</para>
            /// </summary>
            [NameInMap("MatchedHost")]
            [Validation(Required=false)]
            public string MatchedHost { get; set; }

            /// <summary>
            /// <para>The sensitive data.</para>
            /// </summary>
            [NameInMap("SensitiveList")]
            [Validation(Required=false)]
            public List<string> SensitiveList { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>26E46541-7AAB-5565-801D-F14DBDC5****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
