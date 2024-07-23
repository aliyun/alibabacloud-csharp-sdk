// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListSmartJobsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CBB6BC61D08</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b>9262E3DA-07FA-4862-FCBB6BC61D08</b></b>*</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SmartJobList")]
        [Validation(Required=false)]
        public List<ListSmartJobsResponseBodySmartJobList> SmartJobList { get; set; }
        public class ListSmartJobsResponseBodySmartJobList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-12-26T04:11:10Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试描述</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;AudioConfig&quot;:{},&quot;InputConfig&quot;:&quot;&quot;}</para>
            /// </summary>
            [NameInMap("EditingConfig")]
            [Validation(Required=false)]
            public string EditingConfig { get; set; }

            [NameInMap("InputConfig")]
            [Validation(Required=false)]
            public ListSmartJobsResponseBodySmartJobListInputConfig InputConfig { get; set; }
            public class ListSmartJobsResponseBodySmartJobListInputConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>oss://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4</para>
                /// </summary>
                [NameInMap("InputFile")]
                [Validation(Required=false)]
                public string InputFile { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>测试关键词</para>
                /// </summary>
                [NameInMap("Keyword")]
                [Validation(Required=false)]
                public string Keyword { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Finished</para>
            /// </summary>
            [NameInMap("JobState")]
            [Validation(Required=false)]
            public string JobState { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ASR</para>
            /// </summary>
            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-12-26T04:11:10Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            [NameInMap("OutputConfig")]
            [Validation(Required=false)]
            public ListSmartJobsResponseBodySmartJobListOutputConfig OutputConfig { get; set; }
            public class ListSmartJobsResponseBodySmartJobListOutputConfig : TeaModel {
                /// <summary>
                /// <para>OSS Bucket</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-bucket</para>
                /// </summary>
                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                /// <summary>
                /// <para>OSS Object</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-object</para>
                /// </summary>
                [NameInMap("Object")]
                [Validation(Required=false)]
                public string Object { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试标题</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;user&quot;:&quot;data&quot;}</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1084506228******</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>110</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
