// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetEdgeContainerAppStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The status of the application.</para>
        /// </summary>
        [NameInMap("AppStatus")]
        [Validation(Required=false)]
        public GetEdgeContainerAppStatusResponseBodyAppStatus AppStatus { get; set; }
        public class GetEdgeContainerAppStatusResponseBodyAppStatus : TeaModel {
            /// <summary>
            /// <para>The base version of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ver-123123123123****</para>
            /// </summary>
            [NameInMap("BaseLineVersion")]
            [Validation(Required=false)]
            public string BaseLineVersion { get; set; }

            /// <summary>
            /// <para>The deployment status of the application.</para>
            /// <list type="bullet">
            /// <item><description><b>undeploy</b>: The application is not deployed.</description></item>
            /// <item><description><b>deploying</b>: The application is being deployed.</description></item>
            /// <item><description><b>deployed</b>: The application is deployed.</description></item>
            /// <item><description><b>undeploying</b>: The deployment is being canceled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>undeploy</para>
            /// </summary>
            [NameInMap("DeployStatus")]
            [Validation(Required=false)]
            public string DeployStatus { get; set; }

            /// <summary>
            /// <para>The time when the application was deployed. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-25T05:58:05Z</para>
            /// </summary>
            [NameInMap("DeployTime")]
            [Validation(Required=false)]
            public string DeployTime { get; set; }

            /// <summary>
            /// <para>The release version of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ver-123123123123****</para>
            /// </summary>
            [NameInMap("DeployedVersion")]
            [Validation(Required=false)]
            public string DeployedVersion { get; set; }

            /// <summary>
            /// <para>The expected release percentage of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50%</para>
            /// </summary>
            [NameInMap("ExpectPercentage")]
            [Validation(Required=false)]
            public int? ExpectPercentage { get; set; }

            /// <summary>
            /// <para>Specifies whether to fully release the version. This parameter takes effect only when PublishType is set to region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("FullRelease")]
            [Validation(Required=false)]
            public bool? FullRelease { get; set; }

            /// <summary>
            /// <para>The environment to which the application was released. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>prod</b>: the production environment.</description></item>
            /// <item><description><b>staging</b>: the staging environment.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>prod</para>
            /// </summary>
            [NameInMap("PublishEnv")]
            [Validation(Required=false)]
            public string PublishEnv { get; set; }

            /// <summary>
            /// <para>The release percentage of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50%</para>
            /// </summary>
            [NameInMap("PublishPercentage")]
            [Validation(Required=false)]
            public int? PublishPercentage { get; set; }

            /// <summary>
            /// <para>The release status of the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>publishing</b></description></item>
            /// <item><description><b>published</b></description></item>
            /// <item><description><b>rollbacking</b></description></item>
            /// <item><description><b>rollbacked</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pubishing</para>
            /// </summary>
            [NameInMap("PublishStatus")]
            [Validation(Required=false)]
            public string PublishStatus { get; set; }

            /// <summary>
            /// <para>The time when the application was released. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-25T05:58:05Z</para>
            /// </summary>
            [NameInMap("PublishTime")]
            [Validation(Required=false)]
            public string PublishTime { get; set; }

            /// <summary>
            /// <para>Specifies how the version is released. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>percentage: releases the version by percentage.</description></item>
            /// <item><description>region: releases the version by region.</description></item>
            /// </list>
            /// <para>If you do not specify this parameter, the version is released by percentage by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>percentage</para>
            /// </summary>
            [NameInMap("PublishType")]
            [Validation(Required=false)]
            public string PublishType { get; set; }

            /// <summary>
            /// <para>The release version of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ver-123123123123****</para>
            /// </summary>
            [NameInMap("PublishingVersion")]
            [Validation(Required=false)]
            public string PublishingVersion { get; set; }

            /// <summary>
            /// <para>The regions to which the version is released.</para>
            /// </summary>
            [NameInMap("Regions")]
            [Validation(Required=false)]
            public GetEdgeContainerAppStatusResponseBodyAppStatusRegions Regions { get; set; }
            public class GetEdgeContainerAppStatusResponseBodyAppStatusRegions : TeaModel {
                [NameInMap("Region")]
                [Validation(Required=false)]
                public List<string> Region { get; set; }

            }

            /// <summary>
            /// <para>The time when the last rollback was performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-25T05:58:05Z</para>
            /// </summary>
            [NameInMap("RollbackTime")]
            [Validation(Required=false)]
            public string RollbackTime { get; set; }

            /// <summary>
            /// <para>The time when the application deployment was canceled. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-25T05:58:05Z</para>
            /// </summary>
            [NameInMap("UnDeployTime")]
            [Validation(Required=false)]
            public string UnDeployTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15C66C7B-671A-4297-9187-2C4477247B78</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
