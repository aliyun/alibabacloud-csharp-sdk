// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribePolarClawAgentToolsResponseBody : TeaModel {
        /// <summary>
        /// <para>Agent ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>main</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-xxx</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The current tool configuration.</para>
        /// </summary>
        [NameInMap("CurrentConfig")]
        [Validation(Required=false)]
        public DescribePolarClawAgentToolsResponseBodyCurrentConfig CurrentConfig { get; set; }
        public class DescribePolarClawAgentToolsResponseBodyCurrentConfig : TeaModel {
            /// <summary>
            /// <para>The list of explicitly allowed tools.</para>
            /// </summary>
            [NameInMap("Allow")]
            [Validation(Required=false)]
            public List<string> Allow { get; set; }

            /// <summary>
            /// <para>The list of additionally allowed tools.</para>
            /// </summary>
            [NameInMap("AlsoAllow")]
            [Validation(Required=false)]
            public List<string> AlsoAllow { get; set; }

            /// <summary>
            /// <para>The list of denied tools.</para>
            /// </summary>
            [NameInMap("Deny")]
            [Validation(Required=false)]
            public List<string> Deny { get; set; }

            /// <summary>
            /// <para>The tool profile.</para>
            /// 
            /// <b>Example:</b>
            /// <para>full</para>
            /// </summary>
            [NameInMap("Profile")]
            [Validation(Required=false)]
            public string Profile { get; set; }

        }

        /// <summary>
        /// <para>The list of tool groups.</para>
        /// </summary>
        [NameInMap("Groups")]
        [Validation(Required=false)]
        public List<DescribePolarClawAgentToolsResponseBodyGroups> Groups { get; set; }
        public class DescribePolarClawAgentToolsResponseBodyGroups : TeaModel {
            /// <summary>
            /// <para>The group identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>file</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>文件操作</para>
            /// </summary>
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// <para>The source, which is core or a plugin ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>core</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The list of tools.</para>
            /// </summary>
            [NameInMap("Tools")]
            [Validation(Required=false)]
            public List<DescribePolarClawAgentToolsResponseBodyGroupsTools> Tools { get; set; }
            public class DescribePolarClawAgentToolsResponseBodyGroupsTools : TeaModel {
                /// <summary>
                /// <para>The list of profiles that include this tool by default.</para>
                /// </summary>
                [NameInMap("DefaultProfiles")]
                [Validation(Required=false)]
                public List<string> DefaultProfiles { get; set; }

                /// <summary>
                /// <para>The tool description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>读取指定文件内容</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The tool identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>read</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The tool name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>读取文件</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>core</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

            }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The list of available profiles.</para>
        /// </summary>
        [NameInMap("Profiles")]
        [Validation(Required=false)]
        public List<DescribePolarClawAgentToolsResponseBodyProfiles> Profiles { get; set; }
        public class DescribePolarClawAgentToolsResponseBodyProfiles : TeaModel {
            /// <summary>
            /// <para>The profile identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>full</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The display name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>全部工具</para>
            /// </summary>
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>F45FFACC-xxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
