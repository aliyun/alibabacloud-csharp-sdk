// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ArtifactLifecyclePolicy : TeaModel {
        /// <summary>
        /// <para>The retention conditions for artifact versions.</para>
        /// </summary>
        [NameInMap("Condition")]
        [Validation(Required=false)]
        public ArtifactLifecyclePolicyCondition Condition { get; set; }
        public class ArtifactLifecyclePolicyCondition : TeaModel {
            /// <summary>
            /// <para>Retains artifact versions whose most recent pull time is within the specified number of days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("LastPullOlderThanDays")]
            [Validation(Required=false)]
            public int? LastPullOlderThanDays { get; set; }

            /// <summary>
            /// <para>Retains artifact versions whose most recent push time is within the specified number of days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("LastPushOlderThanDays")]
            [Validation(Required=false)]
            public int? LastPushOlderThanDays { get; set; }

            /// <summary>
            /// <para>The number of most recently pushed artifact versions to retain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("LatestTagCount")]
            [Validation(Required=false)]
            public int? LatestTagCount { get; set; }

        }

        /// <summary>
        /// <para>The filter conditions for artifact versions.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public ArtifactLifecyclePolicyFilter Filter { get; set; }
        public class ArtifactLifecyclePolicyFilter : TeaModel {
            /// <summary>
            /// <para>The matching expression for the names of additionally retained artifact versions.</para>
            /// </summary>
            [NameInMap("TagWildcard")]
            [Validation(Required=false)]
            public string TagWildcard { get; set; }

        }

        /// <summary>
        /// <para>The type of the artifact version data retention policy.</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
