// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetADBSparkNecessaryRAMPermissionsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetADBSparkNecessaryRAMPermissionsResponseBodyData Data { get; set; }
        public class GetADBSparkNecessaryRAMPermissionsResponseBodyData : TeaModel {
            [NameInMap("DeniedDetail")]
            [Validation(Required=false)]
            public GetADBSparkNecessaryRAMPermissionsResponseBodyDataDeniedDetail DeniedDetail { get; set; }
            public class GetADBSparkNecessaryRAMPermissionsResponseBodyDataDeniedDetail : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>ListSparkApps</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ImplicitDeny</para>
                /// </summary>
                [NameInMap("NoPermissionType")]
                [Validation(Required=false)]
                public string NoPermissionType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ControlPolicy</para>
                /// </summary>
                [NameInMap("PolicyType")]
                [Validation(Required=false)]
                public string PolicyType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SubUser</para>
                /// </summary>
                [NameInMap("PrincipalType")]
                [Validation(Required=false)]
                public string PrincipalType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>223345695632****</para>
                /// </summary>
                [NameInMap("ResourceAuthTargetInfo")]
                [Validation(Required=false)]
                public string ResourceAuthTargetInfo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>11685695632****</para>
                /// </summary>
                [NameInMap("ResourceOwnerId")]
                [Validation(Required=false)]
                public string ResourceOwnerId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Passed")]
            [Validation(Required=false)]
            public bool? Passed { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Grant the system RAM policy \&quot;AliyunADBDeveloperAccess\&quot; to current RAM user can quickly solve this issue.</para>
            /// </summary>
            [NameInMap("Suggestion")]
            [Validation(Required=false)]
            public string Suggestion { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>642F3512-C628-5D0C-8815-F6670C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
