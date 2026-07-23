// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetRoutineBuildConfigurationResponseBody : TeaModel {
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
        /// <para>The branches that trigger builds. A value of * indicates all branches. Multiple specific branches are separated by commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>int,abc</para>
        /// </summary>
        [NameInMap("BuildBranches")]
        [Validation(Required=false)]
        public string BuildBranches { get; set; }

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
        /// <para>The creation time, in ISO 8601 format using UTC time. Format: yyyy-MM-ddTHH:mm:ssZ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-03-11T01:23:21Z</para>
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
        /// <para>4695144764942144</para>
        /// </summary>
        [NameInMap("GitAccountId")]
        [Validation(Required=false)]
        public long? GitAccountId { get; set; }

        /// <summary>
        /// <para>The Git account type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>User: individual account.</description></item>
        /// <item><description>Organization: organization account.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>User</para>
        /// </summary>
        [NameInMap("GitAccountType")]
        [Validation(Required=false)]
        public string GitAccountType { get; set; }

        /// <summary>
        /// <para>The Git platform.</para>
        /// 
        /// <b>Example:</b>
        /// <para>github</para>
        /// </summary>
        [NameInMap("GitPlatform")]
        [Validation(Required=false)]
        public string GitPlatform { get; set; }

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
        /// <para>The Node.js version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22.x</para>
        /// </summary>
        [NameInMap("NodeVersion")]
        [Validation(Required=false)]
        public string NodeVersion { get; set; }

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
        /// <para>example-test</para>
        /// </summary>
        [NameInMap("Repository")]
        [Validation(Required=false)]
        public string Repository { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D1D7BBB5-9B5B-5A29-8848-398F3CA18A8A</para>
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
        /// <para>The ER build configuration ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3472165674357056</para>
        /// </summary>
        [NameInMap("RoutineBuildConfigurationId")]
        [Validation(Required=false)]
        public long? RoutineBuildConfigurationId { get; set; }

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
        /// <para>The modification time, in ISO 8601 format using UTC time. Format: yyyy-MM-ddTHH:mm:ssZ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-04-19T11:15:20Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
