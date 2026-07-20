// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateRoutineBuildConfigurationShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The static resource directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/root/user</para>
        /// </summary>
        [NameInMap("AssetsDirectory")]
        [Validation(Required=false)]
        public string AssetsDirectory { get; set; }

        /// <summary>
        /// <para>The branches that trigger a build. Set this parameter to * for all branches. To specify multiple branches, separate branch names with commas.</para>
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
        /// <para>npm xxx</para>
        /// </summary>
        [NameInMap("BuildCommand")]
        [Validation(Required=false)]
        public string BuildCommand { get; set; }

        /// <summary>
        /// <para>The environment variables.</para>
        /// </summary>
        [NameInMap("EnvironmentVariables")]
        [Validation(Required=false)]
        public string EnvironmentVariablesShrink { get; set; }

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
        /// <para>The install command.</para>
        /// 
        /// <b>Example:</b>
        /// <para>npm install xxx</para>
        /// </summary>
        [NameInMap("InstallCommand")]
        [Validation(Required=false)]
        public string InstallCommand { get; set; }

        /// <summary>
        /// <para>Specifies whether the repository is private. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The repository is private.</description></item>
        /// <item><description><c>false</c>: The repository is not private.</description></item>
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
        /// <para>The root directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/root/admin</para>
        /// </summary>
        [NameInMap("RootDirectory")]
        [Validation(Required=false)]
        public string RootDirectory { get; set; }

        /// <summary>
        /// <para>The path of the ER entry file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/home</para>
        /// </summary>
        [NameInMap("RoutineEntry")]
        [Validation(Required=false)]
        public string RoutineEntry { get; set; }

        /// <summary>
        /// <para>The ER name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-routine</para>
        /// </summary>
        [NameInMap("RoutineName")]
        [Validation(Required=false)]
        public string RoutineName { get; set; }

    }

}
