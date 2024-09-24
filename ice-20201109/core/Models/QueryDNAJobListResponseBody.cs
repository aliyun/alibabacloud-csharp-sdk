// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class QueryDNAJobListResponseBody : TeaModel {
        [NameInMap("JobList")]
        [Validation(Required=false)]
        public List<QueryDNAJobListResponseBodyJobList> JobList { get; set; }
        public class QueryDNAJobListResponseBodyJobList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;InvalidParameter.ResourceNotFound&quot;</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;SaveType&quot;: &quot;save&quot;,&quot;MediaType&quot;&quot;:&quot;video&quot;}</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-12-28T03:21:37Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2288c6ca184c0e47098a5b665e2a12****</para>
            /// </summary>
            [NameInMap("DBId")]
            [Validation(Required=false)]
            public string DBId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://test_bucket.oss-cn-shanghai.aliyuncs.com/fingerprint/video/search_result/5/5.txt">http://test_bucket.oss-cn-shanghai.aliyuncs.com/fingerprint/video/search_result/5/5.txt</a></para>
            /// </summary>
            [NameInMap("DNAResult")]
            [Validation(Required=false)]
            public string DNAResult { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-12-28T03:21:44Z</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>88c6ca184c0e47098a5b665e2a12****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Input")]
            [Validation(Required=false)]
            public QueryDNAJobListResponseBodyJobListInput Input { get; set; }
            public class QueryDNAJobListResponseBodyJobListInput : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1b1b9cd148034739af413150fded****</para>
                /// </summary>
                [NameInMap("Media")]
                [Validation(Required=false)]
                public string Media { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Media</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;The resource operated \&quot;a887d0b***d805ef6f7f6786302\&quot; cannot be found&quot;</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3ca84a39a9024f19853b21be9cf9****</para>
            /// </summary>
            [NameInMap("PrimaryKey")]
            [Validation(Required=false)]
            public string PrimaryKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Queuing</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testdna</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>25818875-5F78-4A13-BEF6-D7393642CA58</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
