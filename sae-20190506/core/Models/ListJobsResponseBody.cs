// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status of the interface or the POP error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>2xx</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>3xx</b>: Redirection.</para>
        /// </description></item>
        /// <item><description><para><b>4xx</b>: A request error occurred.</para>
        /// </description></item>
        /// <item><description><para><b>5xx</b>: A server error occurred.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The list of job templates.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListJobsResponseBodyData Data { get; set; }
        public class ListJobsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of job templates.</para>
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
                /// <para>The time when the last job was completed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1657522839</para>
                /// </summary>
                [NameInMap("CompletionTime")]
                [Validation(Required=false)]
                public long? CompletionTime { get; set; }

                /// <summary>
                /// <para>The CPU required for each instance, in millicores. The value cannot be 0. Only the following defined specifications are supported:</para>
                /// <list type="bullet">
                /// <item><description><para><b>500</b></para>
                /// </description></item>
                /// <item><description><para><b>1000</b></para>
                /// </description></item>
                /// <item><description><para><b>2000</b></para>
                /// </description></item>
                /// <item><description><para><b>4000</b></para>
                /// </description></item>
                /// <item><description><para><b>8000</b></para>
                /// </description></item>
                /// <item><description><para><b>16000</b></para>
                /// </description></item>
                /// <item><description><para><b>32000</b></para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                /// <summary>
                /// <para>The number of failed instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Failed")]
                [Validation(Required=false)]
                public long? Failed { get; set; }

                /// <summary>
                /// <para>The image URL.</para>
                /// </summary>
                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                /// <summary>
                /// <para>Indicates whether the last release order was successfully executed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>0</b>: The release order failed to be executed.</para>
                /// </description></item>
                /// <item><description><para><b>1</b>: The release order was successfully executed.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LastChangeorderState")]
                [Validation(Required=false)]
                public string LastChangeorderState { get; set; }

                /// <summary>
                /// <para>The state of the last job. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>0</b>: Not executed.</para>
                /// </description></item>
                /// <item><description><para><b>1</b>: Successful.</para>
                /// </description></item>
                /// <item><description><para><b>2</b>: Failed.</para>
                /// </description></item>
                /// <item><description><para><b>3</b>: Running.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LastJobState")]
                [Validation(Required=false)]
                public string LastJobState { get; set; }

                /// <summary>
                /// <para>The time when the last job was started.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1657522800</para>
                /// </summary>
                [NameInMap("LastStartTime")]
                [Validation(Required=false)]
                public long? LastStartTime { get; set; }

                /// <summary>
                /// <para>The memory required for each instance, in MB. The value cannot be 0. This parameter corresponds to the CPU parameter. Only the following defined specifications are supported:</para>
                /// <list type="bullet">
                /// <item><description><para><b>1024</b>: corresponds to 500 and 1,000 millicores of CPU.</para>
                /// </description></item>
                /// <item><description><para><b>2048</b>: corresponds to 500, 1,000, and 2,000 millicores of CPU.</para>
                /// </description></item>
                /// <item><description><para><b>4096</b>: corresponds to 1,000, 2,000, and 4,000 millicores of CPU.</para>
                /// </description></item>
                /// <item><description><para><b>8192</b>: corresponds to 2,000, 4,000, and 8,000 millicores of CPU.</para>
                /// </description></item>
                /// <item><description><para><b>12288</b>: corresponds to 12,000 millicores of CPU.</para>
                /// </description></item>
                /// <item><description><para><b>16384</b>: corresponds to 4,000, 8,000, and 16,000 millicores of CPU.</para>
                /// </description></item>
                /// <item><description><para><b>24576</b>: corresponds to 12,000 millicores of CPU.</para>
                /// </description></item>
                /// <item><description><para><b>32768</b>: corresponds to 16,000 millicores of CPU.</para>
                /// </description></item>
                /// <item><description><para><b>65536</b>: corresponds to 8,000, 16,000, and 32,000 millicores of CPU.</para>
                /// </description></item>
                /// <item><description><para><b>131072</b>: corresponds to 32,000 millicores of CPU.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("Mem")]
                [Validation(Required=false)]
                public int? Mem { get; set; }

                /// <summary>
                /// <para>Additional information about the call.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The namespace ID.</para>
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
                /// <para>The number of successful instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Succeeded")]
                [Validation(Required=false)]
                public long? Succeeded { get; set; }

                /// <summary>
                /// <para>Indicates whether the job template is paused.</para>
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
                    /// <para>The tag key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>key</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The tag value.</para>
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
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
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
        /// <para>The error code.</para>
        /// <list type="bullet">
        /// <item><description><para>If the request is successful, this parameter is not returned.</para>
        /// </description></item>
        /// <item><description><para>If the request fails, this parameter is returned. For more information, see the <b>Error codes</b> section of this topic.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>Additional information about the call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
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
        /// <para>Indicates whether the list of job templates was obtained. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The list was obtained.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The list failed to be obtained.</para>
        /// </description></item>
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
