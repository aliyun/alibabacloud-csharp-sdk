// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetDeploymentPackageResponseBody : TeaModel {
        /// <summary>
        /// <para>The deployment package details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDeploymentPackageResponseBodyData Data { get; set; }
        public class GetDeploymentPackageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The deployment item details.</para>
            /// </summary>
            [NameInMap("DeployedItems")]
            [Validation(Required=false)]
            public List<GetDeploymentPackageResponseBodyDataDeployedItems> DeployedItems { get; set; }
            public class GetDeploymentPackageResponseBodyDataDeployedItems : TeaModel {
                /// <summary>
                /// <para>The file ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5076****</para>
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public long? FileId { get; set; }

                /// <summary>
                /// <para>The file version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("FileVersion")]
                [Validation(Required=false)]
                public long? FileVersion { get; set; }

                /// <summary>
                /// <list type="bullet">
                /// <item><description>UNPUBLISHED(0)</description></item>
                /// <item><description>SUCCESS(1)</description></item>
                /// <item><description>ERROR(2)</description></item>
                /// <item><description>CLONED(3)</description></item>
                /// <item><description>DEPLOY_ERROR(4)</description></item>
                /// <item><description>CLONING(5)</description></item>
                /// <item><description>REJECT(6)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            /// <summary>
            /// <para>The deployment package details.</para>
            /// </summary>
            [NameInMap("Deployment")]
            [Validation(Required=false)]
            public GetDeploymentPackageResponseBodyDataDeployment Deployment { get; set; }
            public class GetDeploymentPackageResponseBodyDataDeployment : TeaModel {
                /// <summary>
                /// <para>The validation status of nodes in the deployment package. For packages deployed to the development environment (toEnviroment=1), you can only proceed to deploy to production if the package Status is 1 (succeeded) and CheckingStatus is empty (validation complete).</para>
                /// <list type="bullet">
                /// <item><description>7: Validation failed</description></item>
                /// <item><description>8: Validation in progress</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("CheckingStatus")]
                [Validation(Required=false)]
                public int? CheckingStatus { get; set; }

                /// <summary>
                /// <para>The timestamp (in milliseconds) when the deployment package was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1593877765000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud account ID of the user who created the deployment package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20030****</para>
                /// </summary>
                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                /// <summary>
                /// <para>The detailed error message when the deployment package fails (status is 2).</para>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The timestamp (in milliseconds) when the deployment started.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1593877765000</para>
                /// </summary>
                [NameInMap("ExecuteTime")]
                [Validation(Required=false)]
                public long? ExecuteTime { get; set; }

                /// <summary>
                /// <para>The environment where the deployment is executed. Valid values: 0 (local) and 1 (development).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("FromEnvironment")]
                [Validation(Required=false)]
                public int? FromEnvironment { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud account ID of the user who executed the deployment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2003****</para>
                /// </summary>
                [NameInMap("HandlerId")]
                [Validation(Required=false)]
                public string HandlerId { get; set; }

                /// <summary>
                /// <para>The deployment package name, displayed on the Deploy Center &gt; Deployment Packages page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ods_user_info_d-2020-07-04_20030****</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The current status of the deployment package. Valid values: 0 (ready), 1 (succeeded), and 2 (failed).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The target environment for the deployment. Valid values: 1 (development) and 2 (production).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ToEnvironment")]
                [Validation(Required=false)]
                public int? ToEnvironment { get; set; }

            }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid.Tenant.ConnectionNotExists</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>You have no permission.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID. Use this ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc1ec92159376****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call succeeded. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
