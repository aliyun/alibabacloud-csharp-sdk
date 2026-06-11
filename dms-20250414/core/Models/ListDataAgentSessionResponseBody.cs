// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListDataAgentSessionResponseBody : TeaModel {
        /// <summary>
        /// <para>Response data</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDataAgentSessionResponseBodyData> Data { get; set; }
        public class ListDataAgentSessionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Current Agent ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>cu0cs*******mf</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>Current Agent status</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("AgentStatus")]
            [Validation(Required=false)]
            public string AgentStatus { get; set; }

            /// <summary>
            /// <para>Session creation time</para>
            /// 
            /// <b>Example:</b>
            /// <para>1731645908000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>Whether the session is saved by the current user in the workspace</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("FavoriteInWorkspace")]
            [Validation(Required=false)]
            public bool? FavoriteInWorkspace { get; set; }

            /// <summary>
            /// <para>File ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>f-8*******01m</para>
            /// </summary>
            [NameInMap("File")]
            [Validation(Required=false)]
            public string File { get; set; }

            /// <summary>
            /// <para>Whether the session is saved by the current user</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Saved")]
            [Validation(Required=false)]
            public bool? Saved { get; set; }

            /// <summary>
            /// <para>Session configuration</para>
            /// </summary>
            [NameInMap("SessionConfig")]
            [Validation(Required=false)]
            public ListDataAgentSessionResponseBodyDataSessionConfig SessionConfig { get; set; }
            public class ListDataAgentSessionResponseBodyDataSessionConfig : TeaModel {
                /// <summary>
                /// <para>Custom Agent ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>ca-e*******ckd</para>
                /// </summary>
                [NameInMap("CustomAgentId")]
                [Validation(Required=false)]
                public string CustomAgentId { get; set; }

                /// <summary>
                /// <para>Custom Agent usage stage:</para>
                /// <list type="bullet">
                /// <item><description><para><b>debug</b> Debug stage</para>
                /// </description></item>
                /// <item><description><para><b>prod</b> Production stage</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>prod</para>
                /// </summary>
                [NameInMap("CustomAgentStage")]
                [Validation(Required=false)]
                public string CustomAgentStage { get; set; }

                /// <summary>
                /// <para>Whether web search is enabled</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableSearch")]
                [Validation(Required=false)]
                public bool? EnableSearch { get; set; }

                /// <summary>
                /// <para>Language</para>
                /// <list type="bullet">
                /// <item><description><para><b>CHINESE</b> Chinese</para>
                /// </description></item>
                /// <item><description><para><b>ENGLISH</b> English</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CHINESE</para>
                /// </summary>
                [NameInMap("Language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                /// <summary>
                /// <para>Mode:</para>
                /// <list type="bullet">
                /// <item><description><para><b>ASK_DATA</b> Quick Inquiry Mode</para>
                /// </description></item>
                /// <item><description><para><b>ANALYSIS</b> Analysis mode</para>
                /// </description></item>
                /// <item><description><para><b>INSIGHT</b> Insight mode</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ANALYSIS</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <para>User OSS bucket name</para>
                /// <list type="bullet">
                /// <item><description>Files and reports generated during analysis can be uploaded to the user-specified OSS bucket.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>user-oss-bucket</para>
                /// </summary>
                [NameInMap("UserOssBucket")]
                [Validation(Required=false)]
                public string UserOssBucket { get; set; }

            }

            /// <summary>
            /// <para>Data Agent session ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>h8r********4fch</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>Session status</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("SessionStatus")]
            [Validation(Required=false)]
            public string SessionStatus { get; set; }

            /// <summary>
            /// <para>Title</para>
            /// 
            /// <b>Example:</b>
            /// <para>分析一下这份文件，给出报告。</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>Session owner ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>2096******</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>Error code. Returned when the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>Error message returned when the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>Current page number</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Current page size</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>E0D21075-CD3E-4D98-8264-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether the request succeeded. Possible values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request succeeded.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
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
        /// <para>Total number of records</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        /// <summary>
        /// <para>Total number of pages</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
