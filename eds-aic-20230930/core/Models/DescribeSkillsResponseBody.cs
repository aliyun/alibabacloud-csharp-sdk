// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeSkillsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1A923337-44D9-5CAD-9A53-95084BD4****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The skill information.</para>
        /// </summary>
        [NameInMap("SkillInfo")]
        [Validation(Required=false)]
        public List<DescribeSkillsResponseBodySkillInfo> SkillInfo { get; set; }
        public class DescribeSkillsResponseBodySkillInfo : TeaModel {
            /// <summary>
            /// <para>The skill category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>System</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-03-13 15:40:51</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The skill description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Current weather and forecasts with wttr.in via curl for locations, rain, temperature, travel planning.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The OSS download URL of the skill icon.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aHR0cDovL2Nsb3VkLXBob25lLWFpLXRlc3QwLm9zcy1jbi1oYW5nemhv****</para>
            /// </summary>
            [NameInMap("IconOssUrl")]
            [Validation(Required=false)]
            public string IconOssUrl { get; set; }

            /// <summary>
            /// <para>The number of instances that have the skill installed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("InstalledCount")]
            [Validation(Required=false)]
            public int? InstalledCount { get; set; }

            /// <summary>
            /// <para>The information about the installed instances.</para>
            /// </summary>
            [NameInMap("InstalledInstances")]
            [Validation(Required=false)]
            public List<DescribeSkillsResponseBodySkillInfoInstalledInstances> InstalledInstances { get; set; }
            public class DescribeSkillsResponseBodySkillInfoInstalledInstances : TeaModel {
                /// <summary>
                /// <para>The installation status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>INSTALLED</para>
                /// </summary>
                [NameInMap("InstallStatus")]
                [Validation(Required=false)]
                public string InstallStatus { get; set; }

                /// <summary>
                /// <para>The cloud phone instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acp-6g3nocu5y9vaf****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

            /// <summary>
            /// <para>The skill summary.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Current weather and forecasts.</para>
            /// </summary>
            [NameInMap("Instruction")]
            [Validation(Required=false)]
            public string Instruction { get; set; }

            /// <summary>
            /// <para>The skill ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s-04zzrgosj6xd1****</para>
            /// </summary>
            [NameInMap("SkillId")]
            [Validation(Required=false)]
            public string SkillId { get; set; }

            /// <summary>
            /// <para>The skill name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>weather</para>
            /// </summary>
            [NameInMap("SkillName")]
            [Validation(Required=false)]
            public string SkillName { get; set; }

            /// <summary>
            /// <para>The skill source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>USER_UPLOAD</para>
            /// </summary>
            [NameInMap("SkillSource")]
            [Validation(Required=false)]
            public string SkillSource { get; set; }

            /// <summary>
            /// <para>The skill lifecycle status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UPLOADED</para>
            /// </summary>
            [NameInMap("SkillStatus")]
            [Validation(Required=false)]
            public string SkillStatus { get; set; }

            /// <summary>
            /// <para>The source node ID of the skill created from a conversation. This value is empty for user-uploaded skills.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acp-bp4du4v74mc7qw8****</para>
            /// </summary>
            [NameInMap("SourceInstanceId")]
            [Validation(Required=false)]
            public string SourceInstanceId { get; set; }

            /// <summary>
            /// <para>The skill status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The skill type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>System</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The skill version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
