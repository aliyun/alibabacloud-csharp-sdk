// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateRoutineBuildConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The static asset directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/root/user</para>
        /// </summary>
        [NameInMap("AssetsDirectory")]
        [Validation(Required=false)]
        public string AssetsDirectory { get; set; }

        /// <summary>
        /// <para>The branches that trigger a build. Specify an asterisk (*) to include all branches, or separate multiple specific branch names with commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>feature/test,hotfix/test</para>
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
        /// <para>The environment variables.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NODE_ENV&quot;:&quot;development&quot;}</para>
        /// </summary>
        [NameInMap("EnvironmentVariables")]
        [Validation(Required=false)]
        public Dictionary<string, string> EnvironmentVariables { get; set; }

        /// <summary>
        /// <para>The ID of the Git account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3472021274759488</para>
        /// </summary>
        [NameInMap("GitAccountId")]
        [Validation(Required=false)]
        public long? GitAccountId { get; set; }

        /// <summary>
        /// <para>The Git platform. Valid values: github, gitee, and upload.</para>
        /// 
        /// <b>Example:</b>
        /// <para>github</para>
        /// </summary>
        [NameInMap("GitPlatform")]
        [Validation(Required=false)]
        public string GitPlatform { get; set; }

        /// <summary>
        /// <para>The installation command.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22.x</para>
        /// </summary>
        [NameInMap("NodeVersion")]
        [Validation(Required=false)]
        public string NodeVersion { get; set; }

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
        /// <para>The name of the repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>webdeck</para>
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
        /// <para>The path to the Edge Routine entry file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/home</para>
        /// </summary>
        [NameInMap("RoutineEntry")]
        [Validation(Required=false)]
        public string RoutineEntry { get; set; }

        /// <summary>
        /// <para>The name of the Edge Routine.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rwa-test</para>
        /// </summary>
        [NameInMap("RoutineName")]
        [Validation(Required=false)]
        public string RoutineName { get; set; }

        /// <summary>
        /// <para>The name of the build template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>react-router</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
