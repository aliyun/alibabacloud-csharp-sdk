// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListRoutineBuildConfigurationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6abd807e-ed2a-44de-ac54-ac38a62472e6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of ER build configurations.</para>
        /// </summary>
        [NameInMap("RoutineBuildConfigurations")]
        [Validation(Required=false)]
        public List<ListRoutineBuildConfigurationsResponseBodyRoutineBuildConfigurations> RoutineBuildConfigurations { get; set; }
        public class ListRoutineBuildConfigurationsResponseBodyRoutineBuildConfigurations : TeaModel {
            /// <summary>
            /// <para>The ER build task information.</para>
            /// </summary>
            [NameInMap("LatestRoutineBuildTask")]
            [Validation(Required=false)]
            public ListRoutineBuildConfigurationsResponseBodyRoutineBuildConfigurationsLatestRoutineBuildTask LatestRoutineBuildTask { get; set; }
            public class ListRoutineBuildConfigurationsResponseBodyRoutineBuildConfigurationsLatestRoutineBuildTask : TeaModel {
                /// <summary>
                /// <para>The creation time. The time is displayed in UTC and follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-03-10T02:18:55Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The ER name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rwa-test</para>
                /// </summary>
                [NameInMap("RoutineName")]
                [Validation(Required=false)]
                public string RoutineName { get; set; }

                /// <summary>
                /// <para>The status of the build task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>int: initialized</description></item>
                /// <item><description>pending: preparing</description></item>
                /// <item><description>building: building</description></item>
                /// <item><description>succeed: succeeded</description></item>
                /// <item><description>failed: failed</description></item>
                /// <item><description>canceled: canceled</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>building</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The ER build configuration information.</para>
            /// </summary>
            [NameInMap("RoutineBuildConfiguration")]
            [Validation(Required=false)]
            public ListRoutineBuildConfigurationsResponseBodyRoutineBuildConfigurationsRoutineBuildConfiguration RoutineBuildConfiguration { get; set; }
            public class ListRoutineBuildConfigurationsResponseBodyRoutineBuildConfigurationsRoutineBuildConfiguration : TeaModel {
                /// <summary>
                /// <para>The Git account name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("GitAccountName")]
                [Validation(Required=false)]
                public string GitAccountName { get; set; }

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
                /// <para>The ER name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rwa-test</para>
                /// </summary>
                [NameInMap("RoutineName")]
                [Validation(Required=false)]
                public string RoutineName { get; set; }

            }

        }

    }

}
