// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20210602.Models
{
    public class GetParseProgressResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data object for parsing the skill package.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetParseProgressResponseBodyData Data { get; set; }
        public class GetParseProgressResponseBodyData : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The error code returned when an execution exception occurs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Package.ReadFailed</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message returned when an execution exception occurs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Failed to read skill package</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("RequiredEnvVars")]
            [Validation(Required=false)]
            public List<string> RequiredEnvVars { get; set; }

            [NameInMap("RequiresApiKey")]
            [Validation(Required=false)]
            public bool? RequiresApiKey { get; set; }

            /// <summary>
            /// <para>The name in the SKILL.md file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name****</para>
            /// </summary>
            [NameInMap("SkillName")]
            [Validation(Required=false)]
            public string SkillName { get; set; }

            /// <summary>
            /// <para>The skill slug identifier. This is user-defined and unique within the tenant dimension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>admapix******</para>
            /// </summary>
            [NameInMap("Slug")]
            [Validation(Required=false)]
            public string Slug { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PARSING_METADATA: parsing in progress.</description></item>
            /// <item><description>COMPLETED: completed.</description></item>
            /// <item><description>FAILED: failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The task key for parsing the skill package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2E7D8B71-2677-1B4C-9E25-A88B9C5******</para>
            /// </summary>
            [NameInMap("TaskKey")]
            [Validation(Required=false)]
            public string TaskKey { get; set; }

            /// <summary>
            /// <para>The version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
