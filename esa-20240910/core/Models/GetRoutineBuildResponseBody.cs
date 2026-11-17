// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetRoutineBuildResponseBody : TeaModel {
        /// <summary>
        /// <para>The static assets directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/root/user</para>
        /// </summary>
        [NameInMap("AssetsDirectory")]
        [Validation(Required=false)]
        public string AssetsDirectory { get; set; }

        /// <summary>
        /// <para>The build branch.</para>
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
        /// <para>9bf55641a1a608b9e7297d3fe51e39baa4b68ba0</para>
        /// </summary>
        [NameInMap("CommitId")]
        [Validation(Required=false)]
        public string CommitId { get; set; }

        /// <summary>
        /// <para>The commit message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Add a configuration file</para>
        /// </summary>
        [NameInMap("CommitMessage")]
        [Validation(Required=false)]
        public string CommitMessage { get; set; }

        /// <summary>
        /// <para>The creation time. The time is displayed in UTC and follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-02-28T09:03:42Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The environment variables.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NODE_ENV&quot;:&quot;development&quot;}</para>
        /// </summary>
        [NameInMap("EnvironmentVariables")]
        [Validation(Required=false)]
        public Dictionary<string, string> EnvironmentVariables { get; set; }

        /// <summary>
        /// <para>The name of the file uploaded for the build task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>index.html</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The Git account ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4580717755793600</para>
        /// </summary>
        [NameInMap("GitAccountId")]
        [Validation(Required=false)]
        public long? GitAccountId { get; set; }

        /// <summary>
        /// <para>The ID of the ER build task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>164557372123356</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

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
        /// <para>Specifies whether the repository is private. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Yes.</description></item>
        /// <item><description>false: No.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsPrivate")]
        [Validation(Required=false)]
        public bool? IsPrivate { get; set; }

        /// <summary>
        /// <para>The Node.js version. Valid values: <c>22.x</c>, <c>20.x</c>, <c>18.x</c>, <c>16.x</c>, <c>14.x</c>, and <c>12.x</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22.x</para>
        /// </summary>
        [NameInMap("NodeVersion")]
        [Validation(Required=false)]
        public string NodeVersion { get; set; }

        /// <summary>
        /// <para>The ID of the Yunxiao pipeline.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4371588</para>
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public long? PipelineId { get; set; }

        /// <summary>
        /// <para>The ID of the Yunxiao build task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70</para>
        /// </summary>
        [NameInMap("PipelineRunId")]
        [Validation(Required=false)]
        public long? PipelineRunId { get; set; }

        /// <summary>
        /// <para>The name of the production branch.</para>
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
        /// <para>example-test</para>
        /// </summary>
        [NameInMap("Repository")]
        [Validation(Required=false)]
        public string Repository { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8C3CC8AF-7C4C-5841-BDAE-B295FD9AE913</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
        /// <para>The path to the ER entry file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/home</para>
        /// </summary>
        [NameInMap("RoutineEntry")]
        [Validation(Required=false)]
        public string RoutineEntry { get; set; }

        /// <summary>
        /// <para>The name of the ER.</para>
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
        /// <item><description>int: Initialized.</description></item>
        /// <item><description>pending: Preparing.</description></item>
        /// <item><description>building: Building.</description></item>
        /// <item><description>succeed: Succeeded.</description></item>
        /// <item><description>failed: Failed.</description></item>
        /// <item><description>canceled: Canceled.</description></item>
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
        /// <para>The update time. The time is displayed in UTC and follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-07-20T09:59:28+08:00</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
