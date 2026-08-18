// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetDeploymentPackageResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the deployment package.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDeploymentPackageResponseBodyData Data { get; set; }
        public class GetDeploymentPackageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The details of the deployed items.</para>
            /// </summary>
            [NameInMap("DeployedItems")]
            [Validation(Required=false)]
            public List<GetDeploymentPackageResponseBodyDataDeployedItems> DeployedItems { get; set; }
            public class GetDeploymentPackageResponseBodyDataDeployedItems : TeaModel {
                /// <summary>
                /// <para>The ID of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5076****</para>
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public long? FileId { get; set; }

                /// <summary>
                /// <para>The version of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("FileVersion")]
                [Validation(Required=false)]
                public long? FileVersion { get; set; }

                /// <summary>
                /// <para>The status of the deployed item. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>UNPUBLISHED(0): not published</description></item>
                /// <item><description>SUCCESS(1): published successfully</description></item>
                /// <item><description>ERROR(2): publishing failed</description></item>
                /// <item><description>CLONED(3): cloned successfully</description></item>
                /// <item><description>DEPLOY_ERROR(4): publishing failed</description></item>
                /// <item><description>CLONING(5): cloning in progress</description></item>
                /// <item><description>REJECT(6): publishing rejected</description></item>
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
            /// <para>The details of the deployment package.</para>
            /// </summary>
            [NameInMap("Deployment")]
            [Validation(Required=false)]
            public GetDeploymentPackageResponseBodyDataDeployment Deployment { get; set; }
            public class GetDeploymentPackageResponseBodyDataDeployment : TeaModel {
                /// <summary>
                /// <para>The check status of the nodes involved in the deployment package. When the target environment is the development environment (toEnvironment=1), you can publish the file to the production environment only when the Status of the deployment package is 1 and CheckingStatus is empty.</para>
                /// <list type="bullet">
                /// <item><description>7: The check failed.</description></item>
                /// <item><description>8: The check is in progress.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("CheckingStatus")]
                [Validation(Required=false)]
                public int? CheckingStatus { get; set; }

                /// <summary>
                /// <para>The timestamp when the deployment package was generated, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1593877765000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud user ID of the user who created the deployment package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20030****</para>
                /// </summary>
                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                /// <summary>
                /// <para>The error message recorded when the deployment package fails to run (status is 2).</para>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The timestamp when the deployment package started to run, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1593877765000</para>
                /// </summary>
                [NameInMap("ExecuteTime")]
                [Validation(Required=false)]
                public long? ExecuteTime { get; set; }

                /// <summary>
                /// <para>The environment from which the deployment is initiated. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: local</description></item>
                /// <item><description>1: development environment</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("FromEnvironment")]
                [Validation(Required=false)]
                public int? FromEnvironment { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud user ID of the user who executed the deployment package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2003****</para>
                /// </summary>
                [NameInMap("HandlerId")]
                [Validation(Required=false)]
                public string HandlerId { get; set; }

                /// <summary>
                /// <para>The name of the deployment package, which is displayed on the Task Publish &gt; Deployment Package List page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ods_user_info_d-2020-07-04_20030****</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The current status of the deployment package. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: ready</description></item>
                /// <item><description>1: successful</description></item>
                /// <item><description>2: failed</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The target environment to which the file information is published. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: development environment</description></item>
                /// <item><description>2: production environment</description></item>
                /// </list>
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
        /// <para>The request ID. You can use this ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc1ec92159376****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call was successful.</description></item>
        /// <item><description><b>false</b>: The call failed.</description></item>
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
