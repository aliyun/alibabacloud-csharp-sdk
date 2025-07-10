// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: The call was successful.</description></item>
        /// <item><description><b>3xx</b>: The call was redirected.</description></item>
        /// <item><description><b>4xx</b>: The call failed.</description></item>
        /// <item><description><b>5xx</b>: A server error occurred.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The job templates.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListJobsResponseBodyData Data { get; set; }
        public class ListJobsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The job templates.</para>
            /// </summary>
            [NameInMap("Applications")]
            [Validation(Required=false)]
            public List<ListJobsResponseBodyDataApplications> Applications { get; set; }
            public class ListJobsResponseBodyDataApplications : TeaModel {
                /// <summary>
                /// <para>The number of running instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Active")]
                [Validation(Required=false)]
                public long? Active { get; set; }

                /// <summary>
                /// <para>The description of the job template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>description</para>
                /// </summary>
                [NameInMap("AppDescription")]
                [Validation(Required=false)]
                public string AppDescription { get; set; }

                /// <summary>
                /// <para>The ID of the job template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>f7730764-d88f-4b9a-8d8e-cd8efbfe****</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The name of the job template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo-app</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The time when the job was last completed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1657522839</para>
                /// </summary>
                [NameInMap("CompletionTime")]
                [Validation(Required=false)]
                public long? CompletionTime { get; set; }

                /// <summary>
                /// <para>The CPU specifications that are required for each instance. Unit: millicores. This parameter cannot be set to 0. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>500</b></description></item>
                /// <item><description><b>1000</b></description></item>
                /// <item><description><b>2000</b></description></item>
                /// <item><description><b>4000</b></description></item>
                /// <item><description><b>8000</b></description></item>
                /// <item><description><b>16000</b></description></item>
                /// <item><description><b>32000</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                /// <summary>
                /// <para>The number of instances that failed to run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Failed")]
                [Validation(Required=false)]
                public long? Failed { get; set; }

                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                /// <summary>
                /// <para>Indicates whether the latest change order was executed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: The latest change order failed to be executed.</description></item>
                /// <item><description><b>1</b>: The latest change order was executed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LastChangeorderState")]
                [Validation(Required=false)]
                public string LastChangeorderState { get; set; }

                /// <summary>
                /// <para>The status of the latest job. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: The job is not executed.</description></item>
                /// <item><description><b>1</b>: The job was executed.</description></item>
                /// <item><description><b>2</b>: The job failed to be executed.</description></item>
                /// <item><description><b>3</b>: The job is being executed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LastJobState")]
                [Validation(Required=false)]
                public string LastJobState { get; set; }

                /// <summary>
                /// <para>The time when the job was last started.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1657522800</para>
                /// </summary>
                [NameInMap("LastStartTime")]
                [Validation(Required=false)]
                public long? LastStartTime { get; set; }

                /// <summary>
                /// <para>The size of memory that is required by each instance. Unit: MB. This parameter cannot be set to 0. The values of this parameter correspond to the values of the Cpu parameter:</para>
                /// <list type="bullet">
                /// <item><description>This parameter is set to <b>1024</b> if the Cpu parameter is set to 500 or 1000.</description></item>
                /// <item><description>This parameter is set to <b>2048</b> if the Cpu parameter is set to 500, 1000, or 2000.</description></item>
                /// <item><description>This parameter is set to <b>4096</b> if the Cpu parameter is set to 1000, 2000, or 4000.</description></item>
                /// <item><description>This parameter is set to <b>8192</b> if the Cpu parameter is set to 2000, 4000, or 8000.</description></item>
                /// <item><description>This parameter is set to <b>12288</b> if the Cpu parameter is set to 12000.</description></item>
                /// <item><description>This parameter is set to <b>16384</b> if the Cpu parameter is set to 4000, 8000, or 16000.</description></item>
                /// <item><description>This parameter is set to <b>24576</b> if the Cpu parameter is set to 12000.</description></item>
                /// <item><description>This parameter is set to <b>32768</b> if the Cpu parameter is set to 16000.</description></item>
                /// <item><description>This parameter is set to <b>65536</b> if the Cpu parameter is set to 8000, 16000, or 32000.</description></item>
                /// <item><description>This parameter is set to <b>131072</b> if the Cpu parameter is set to 32000.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("Mem")]
                [Validation(Required=false)]
                public int? Mem { get; set; }

                /// <summary>
                /// <para>The returned message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The ID of the namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing:demo</para>
                /// </summary>
                [NameInMap("NamespaceId")]
                [Validation(Required=false)]
                public string NamespaceId { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The number of instances that were successfully run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Succeeded")]
                [Validation(Required=false)]
                public long? Succeeded { get; set; }

                /// <summary>
                /// <para>Indicates whether the job template is suspended.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Suspend")]
                [Validation(Required=false)]
                public bool? Suspend { get; set; }

                /// <summary>
                /// <para>The tags of the job template.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListJobsResponseBodyDataApplicationsTags> Tags { get; set; }
                public class ListJobsResponseBodyDataApplicationsTags : TeaModel {
                    /// <summary>
                    /// <para>The key of the tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>key</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The value of the tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>value</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("TriggerConfig")]
                [Validation(Required=false)]
                public string TriggerConfig { get; set; }

            }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries returned on each page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of job templates.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The error code returned. Take note of the following rules:</para>
        /// <list type="bullet">
        /// <item><description>If the call is successful, <b>ErrorCode</b> is not returned.</description></item>
        /// <item><description>If the call fails, <b>ErrorCode</b> is returned. For more information, see the &quot;<b>Error codes</b>&quot; section in this topic.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Null</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B4D805CA-926D-41B1-8E63-7AD0C1ED****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the applications were obtained. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of job templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalSize")]
        [Validation(Required=false)]
        public int? TotalSize { get; set; }

    }

}
