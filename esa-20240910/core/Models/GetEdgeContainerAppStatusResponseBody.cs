// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetEdgeContainerAppStatusResponseBody : TeaModel {
        [NameInMap("AppStatus")]
        [Validation(Required=false)]
        public GetEdgeContainerAppStatusResponseBodyAppStatus AppStatus { get; set; }
        public class GetEdgeContainerAppStatusResponseBodyAppStatus : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ver-123123123123****</para>
            /// </summary>
            [NameInMap("BaseLineVersion")]
            [Validation(Required=false)]
            public string BaseLineVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>undeploy</para>
            /// </summary>
            [NameInMap("DeployStatus")]
            [Validation(Required=false)]
            public string DeployStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-07-25T05:58:05Z</para>
            /// </summary>
            [NameInMap("DeployTime")]
            [Validation(Required=false)]
            public string DeployTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ver-123123123123****</para>
            /// </summary>
            [NameInMap("DeployedVersion")]
            [Validation(Required=false)]
            public string DeployedVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50%</para>
            /// </summary>
            [NameInMap("ExpectPercentage")]
            [Validation(Required=false)]
            public int? ExpectPercentage { get; set; }

            [NameInMap("FullRelease")]
            [Validation(Required=false)]
            public bool? FullRelease { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>prod</para>
            /// </summary>
            [NameInMap("PublishEnv")]
            [Validation(Required=false)]
            public string PublishEnv { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50%</para>
            /// </summary>
            [NameInMap("PublishPercentage")]
            [Validation(Required=false)]
            public int? PublishPercentage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pubishing</para>
            /// </summary>
            [NameInMap("PublishStatus")]
            [Validation(Required=false)]
            public string PublishStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-07-25T05:58:05Z</para>
            /// </summary>
            [NameInMap("PublishTime")]
            [Validation(Required=false)]
            public string PublishTime { get; set; }

            [NameInMap("PublishType")]
            [Validation(Required=false)]
            public string PublishType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ver-123123123123****</para>
            /// </summary>
            [NameInMap("PublishingVersion")]
            [Validation(Required=false)]
            public string PublishingVersion { get; set; }

            [NameInMap("Regions")]
            [Validation(Required=false)]
            public GetEdgeContainerAppStatusResponseBodyAppStatusRegions Regions { get; set; }
            public class GetEdgeContainerAppStatusResponseBodyAppStatusRegions : TeaModel {
                [NameInMap("Region")]
                [Validation(Required=false)]
                public List<string> Region { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-07-25T05:58:05Z</para>
            /// </summary>
            [NameInMap("RollbackTime")]
            [Validation(Required=false)]
            public string RollbackTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-07-25T05:58:05Z</para>
            /// </summary>
            [NameInMap("UnDeployTime")]
            [Validation(Required=false)]
            public string UnDeployTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15C66C7B-671A-4297-9187-2C4477247B78</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
