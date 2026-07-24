// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListRoutineBuildsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of ER build tasks.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListRoutineBuildsResponseBodyData> Data { get; set; }
        public class ListRoutineBuildsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The static assets directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/root/usr</para>
            /// </summary>
            [NameInMap("AssetsDirectory")]
            [Validation(Required=false)]
            public string AssetsDirectory { get; set; }

            /// <summary>
            /// <para>The branch used for the build.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dev</para>
            /// </summary>
            [NameInMap("Branch")]
            [Validation(Required=false)]
            public string Branch { get; set; }

            /// <summary>
            /// <para>The build command.</para>
            /// 
            /// <b>Example:</b>
            /// <para>npm run build</para>
            /// </summary>
            [NameInMap("BuildCommand")]
            [Validation(Required=false)]
            public string BuildCommand { get; set; }

            /// <summary>
            /// <para>The ID of the commit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c08057f590f8d5be56fcae1e082128254a708f94</para>
            /// </summary>
            [NameInMap("CommitId")]
            [Validation(Required=false)]
            public string CommitId { get; set; }

            /// <summary>
            /// <para>The commit message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Add static files.</para>
            /// </summary>
            [NameInMap("CommitMessage")]
            [Validation(Required=false)]
            public string CommitMessage { get; set; }

            /// <summary>
            /// <para>The creation time, in the ISO 8601 format in UTC. The format is yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-03-26T02:19:34Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The environment variables.</para>
            /// </summary>
            [NameInMap("EnvironmentVariables")]
            [Validation(Required=false)]
            public Dictionary<string, string> EnvironmentVariables { get; set; }

            /// <summary>
            /// <para>The Git account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>162124764031208</para>
            /// </summary>
            [NameInMap("GitAccountId")]
            [Validation(Required=false)]
            public long? GitAccountId { get; set; }

            /// <summary>
            /// <para>The Git account name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rwa</para>
            /// </summary>
            [NameInMap("GitAccountName")]
            [Validation(Required=false)]
            public string GitAccountName { get; set; }

            /// <summary>
            /// <para>The install command.</para>
            /// 
            /// <b>Example:</b>
            /// <para>npm install</para>
            /// </summary>
            [NameInMap("InstallCommand")]
            [Validation(Required=false)]
            public string InstallCommand { get; set; }

            /// <summary>
            /// <para>Indicates whether the repository is private. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The repository is private.</description></item>
            /// <item><description>false: The repository is not private.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsPrivate")]
            [Validation(Required=false)]
            public bool? IsPrivate { get; set; }

            /// <summary>
            /// <para>The Node.js version. Valid values: <c>22.x</c>, <c>20.x</c>, <c>18.x</c>, <c>16.x</c>, <c>14.x</c>, <c>12.x</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22.x</para>
            /// </summary>
            [NameInMap("NodeVersion")]
            [Validation(Required=false)]
            public string NodeVersion { get; set; }

            /// <summary>
            /// <para>The Yunxiao pipeline ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3850166</para>
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public long? PipelineId { get; set; }

            /// <summary>
            /// <para>The Yunxiao build task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>70</para>
            /// </summary>
            [NameInMap("PipelineRunId")]
            [Validation(Required=false)]
            public long? PipelineRunId { get; set; }

            /// <summary>
            /// <para>The production branch name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>main</para>
            /// </summary>
            [NameInMap("ProductionBranch")]
            [Validation(Required=false)]
            public string ProductionBranch { get; set; }

            /// <summary>
            /// <para>The repository name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rwa-test</para>
            /// </summary>
            [NameInMap("Repository")]
            [Validation(Required=false)]
            public string Repository { get; set; }

            /// <summary>
            /// <para>The root directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/root/admin</para>
            /// </summary>
            [NameInMap("RootDirectory")]
            [Validation(Required=false)]
            public string RootDirectory { get; set; }

            /// <summary>
            /// <para>The ER build task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4133325046294912</para>
            /// </summary>
            [NameInMap("RoutineBuildId")]
            [Validation(Required=false)]
            public long? RoutineBuildId { get; set; }

            /// <summary>
            /// <para>The ER entry file path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/home</para>
            /// </summary>
            [NameInMap("RoutineEntry")]
            [Validation(Required=false)]
            public string RoutineEntry { get; set; }

            /// <summary>
            /// <para>The ER name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-routine</para>
            /// </summary>
            [NameInMap("RoutineName")]
            [Validation(Required=false)]
            public string RoutineName { get; set; }

            /// <summary>
            /// <para>The status of the build task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>int: initialization</description></item>
            /// <item><description>pending: preparing</description></item>
            /// <item><description>building: building</description></item>
            /// <item><description>succeed: build succeeded</description></item>
            /// <item><description>failed: build failed</description></item>
            /// <item><description>canceled: canceled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>succeed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>The modification time, in the ISO 8601 format in UTC. The format is yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-20T00:44:23Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1427812834792318</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        /// <summary>
        /// <para>The page number, which is the same as the PageIndex request parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public long? PageIndex { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ET5BF670-09D5-4D0B-BEBY-D96A2A528000</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public long? TotalPage { get; set; }

    }

}
