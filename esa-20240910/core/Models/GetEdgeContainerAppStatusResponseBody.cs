// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetEdgeContainerAppStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The object that describes the application status information.</para>
        /// </summary>
        [NameInMap("AppStatus")]
        [Validation(Required=false)]
        public GetEdgeContainerAppStatusResponseBodyAppStatus AppStatus { get; set; }
        public class GetEdgeContainerAppStatusResponseBodyAppStatus : TeaModel {
            /// <summary>
            /// <para>The baseline version of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ver-123123123123****</para>
            /// </summary>
            [NameInMap("BaseLineVersion")]
            [Validation(Required=false)]
            public string BaseLineVersion { get; set; }

            /// <summary>
            /// <para>The deployment status of the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>undeploy</b>: Not deployed.</description></item>
            /// <item><description><b>deploying</b>: Being deployed.</description></item>
            /// <item><description><b>deployed</b>: Deployed.</description></item>
            /// <item><description><b>undeploying</b>: Being undeployed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>undeploy</para>
            /// </summary>
            [NameInMap("DeployStatus")]
            [Validation(Required=false)]
            public string DeployStatus { get; set; }

            /// <summary>
            /// <para>The deployment time of the application. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-25T05:58:05Z</para>
            /// </summary>
            [NameInMap("DeployTime")]
            [Validation(Required=false)]
            public string DeployTime { get; set; }

            /// <summary>
            /// <para>The deployed version of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ver-123123123123****</para>
            /// </summary>
            [NameInMap("DeployedVersion")]
            [Validation(Required=false)]
            public string DeployedVersion { get; set; }

            /// <summary>
            /// <para>The expected publishing percentage of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50%</para>
            /// </summary>
            [NameInMap("ExpectPercentage")]
            [Validation(Required=false)]
            public int? ExpectPercentage { get; set; }

            /// <summary>
            /// <para>Indicates whether the application is fully released. This field takes effect only when PublishType is set to region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("FullRelease")]
            [Validation(Required=false)]
            public bool? FullRelease { get; set; }

            /// <summary>
            /// <para>The publishing environment. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>prod</b>: Production environment.</description></item>
            /// <item><description><b>staging</b>: Staging environment.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>prod</para>
            /// </summary>
            [NameInMap("PublishEnv")]
            [Validation(Required=false)]
            public string PublishEnv { get; set; }

            /// <summary>
            /// <para>The publishing percentage of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50%</para>
            /// </summary>
            [NameInMap("PublishPercentage")]
            [Validation(Required=false)]
            public int? PublishPercentage { get; set; }

            /// <summary>
            /// <para>The publishing status of the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>publishing</b>: Being published.</description></item>
            /// <item><description><b>published</b>: Published.</description></item>
            /// <item><description><b>rollbacking</b>: Being rolled back.</description></item>
            /// <item><description><b>rollbacked</b>: Rolled back.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pubishing</para>
            /// </summary>
            [NameInMap("PublishStatus")]
            [Validation(Required=false)]
            public string PublishStatus { get; set; }

            /// <summary>
            /// <para>The publishing time of the application. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-25T05:58:05Z</para>
            /// </summary>
            [NameInMap("PublishTime")]
            [Validation(Required=false)]
            public string PublishTime { get; set; }

            /// <summary>
            /// <para>The publishing type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>percentage</b>: Publish by percentage.</para>
            /// </description></item>
            /// <item><description><para><b>region</b>: Publish by region.</para>
            /// </description></item>
            /// </list>
            /// <para>If this parameter is not specified, the default value percentage is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>percentage</para>
            /// </summary>
            [NameInMap("PublishType")]
            [Validation(Required=false)]
            public string PublishType { get; set; }

            /// <summary>
            /// <para>The publishing version of the application.</para>
            /// 
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
            /// <para>The most recent rollback time. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-25T05:58:05Z</para>
            /// </summary>
            [NameInMap("RollbackTime")]
            [Validation(Required=false)]
            public string RollbackTime { get; set; }

            /// <summary>
            /// <para>The undeployment time of the application. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
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
