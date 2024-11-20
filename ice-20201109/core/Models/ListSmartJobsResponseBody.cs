// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListSmartJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries returned on a single page. The value is set to the maximum number of entries returned on each page except for the last page. Valid example: 10,10,5. Invalid example: 10,5,10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBB6BC61D08</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>9262E3DA-07FA-4862-FCBB6BC61D08</b></b>*</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The queried intelligent jobs.</para>
        /// </summary>
        [NameInMap("SmartJobList")]
        [Validation(Required=false)]
        public List<ListSmartJobsResponseBodySmartJobList> SmartJobList { get; set; }
        public class ListSmartJobsResponseBodySmartJobList : TeaModel {
            /// <summary>
            /// <para>The time when the job was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-26T04:11:10Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The job description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试描述</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The editing configurations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;AudioConfig&quot;:{},&quot;InputConfig&quot;:&quot;&quot;}</para>
            /// </summary>
            [NameInMap("EditingConfig")]
            [Validation(Required=false)]
            public string EditingConfig { get; set; }

            /// <summary>
            /// <para>The input configurations.</para>
            /// </summary>
            [NameInMap("InputConfig")]
            [Validation(Required=false)]
            public ListSmartJobsResponseBodySmartJobListInputConfig InputConfig { get; set; }
            public class ListSmartJobsResponseBodySmartJobListInputConfig : TeaModel {
                /// <summary>
                /// <para>The information about the input file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4</para>
                /// </summary>
                [NameInMap("InputFile")]
                [Validation(Required=false)]
                public string InputFile { get; set; }

                /// <summary>
                /// <para>The keyword information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试关键词</para>
                /// </summary>
                [NameInMap("Keyword")]
                [Validation(Required=false)]
                public string Keyword { get; set; }

            }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The job state.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Finished: The job is complete.</description></item>
            /// <item><description>Failed: The job failed.</description></item>
            /// <item><description>Executing: The job is in progress.</description></item>
            /// <item><description>Created: The job is created.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Finished</para>
            /// </summary>
            [NameInMap("JobState")]
            [Validation(Required=false)]
            public string JobState { get; set; }

            /// <summary>
            /// <para>The job type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ASR: ASR job.</description></item>
            /// <item><description>DynamicChart: dynamic chart job.</description></item>
            /// <item><description>TextToSpeech: intelligent audio production job.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ASR</para>
            /// </summary>
            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }

            /// <summary>
            /// <para>The time when the job was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-26T04:11:10Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The output configurations.</para>
            /// </summary>
            [NameInMap("OutputConfig")]
            [Validation(Required=false)]
            public ListSmartJobsResponseBodySmartJobListOutputConfig OutputConfig { get; set; }
            public class ListSmartJobsResponseBodySmartJobListOutputConfig : TeaModel {
                /// <summary>
                /// <para>The Object Storage Service (OSS) bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-bucket</para>
                /// </summary>
                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                /// <summary>
                /// <para>The OSS object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-object</para>
                /// </summary>
                [NameInMap("Object")]
                [Validation(Required=false)]
                public string Object { get; set; }

            }

            /// <summary>
            /// <para>The job title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试标题</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The user-defined data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;user&quot;:&quot;data&quot;}</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1084506228******</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        /// <summary>
        /// <para>Optional. The total number of entries returned. By default, this parameter is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>110</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
