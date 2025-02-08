// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDeploymentResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the deployment package.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDeploymentResponseBodyData Data { get; set; }
        public class GetDeploymentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The deployed items.</para>
            /// </summary>
            [NameInMap("DeployedItems")]
            [Validation(Required=false)]
            public List<GetDeploymentResponseBodyDataDeployedItems> DeployedItems { get; set; }
            public class GetDeploymentResponseBodyDataDeployedItems : TeaModel {
                /// <summary>
                /// <para>The file ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>507642378</para>
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
                /// <list type="bullet">
                /// <item><description>UNPUBLISHED(0): not published</description></item>
                /// <item><description>SUCCESS(1): Published</description></item>
                /// <item><description>ERROR(2): Publishing failed</description></item>
                /// <item><description>CLONED(3): successfully CLONED</description></item>
                /// <item><description>DEPLOY_ERROR(4): Publishing failed</description></item>
                /// <item><description>CLONING(5): CLONING</description></item>
                /// <item><description>REJECT(6): release rejected</description></item>
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
            public GetDeploymentResponseBodyDataDeployment Deployment { get; set; }
            public class GetDeploymentResponseBodyDataDeployment : TeaModel {
                /// <summary>
                /// <para>The check status of one or more files in the deployment task. If the value of the ToEnvironment parameter is 1, the files can be deployed to the production environment only when the value of the Status parameter is 1 and the CheckingStatus parameter is empty. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>7: The file failed the check.</description></item>
                /// <item><description>8: The file is being checked.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("CheckingStatus")]
                [Validation(Required=false)]
                public int? CheckingStatus { get; set; }

                /// <summary>
                /// <para>The time when the deployment task was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1593877765000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account used by the user who created the deployment task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20030****</para>
                /// </summary>
                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                /// <summary>
                /// <para>The error message that was returned when the deployment package failed. In this case, the value of the Status parameter is 2.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The time when the deployment task was run. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1593877765000</para>
                /// </summary>
                [NameInMap("ExecuteTime")]
                [Validation(Required=false)]
                public long? ExecuteTime { get; set; }

                /// <summary>
                /// <para>The environment in which the deployment task was run. Valid values: 0 and 1. A value of 0 indicates the on-premises environment. A value of 1 indicates the development environment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("FromEnvironment")]
                [Validation(Required=false)]
                public int? FromEnvironment { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account used by the user who ran the deployment task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2003****</para>
                /// </summary>
                [NameInMap("HandlerId")]
                [Validation(Required=false)]
                public string HandlerId { get; set; }

                /// <summary>
                /// <para>The name of the deployment task. The value is the same as the name of the specific deployment task that is displayed on the Release Package page in the Deploy module.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ods_user_info_d-2020-07-04_20030****</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The status of the deployment task. Valid values: 0, 1, and 2. A value of 0 indicates that the task is ready. A value of 1 indicates that the task was successful. A value of 2 indicates that the task failed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The environment to which the file was deployed. Valid values: 1 and 2. A value of 1 indicates the development environment. A value of 2 indicates the production environment.</para>
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
        /// <para>The error code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid.Tenant.ConnectionNotExists</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The connection does not exist.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The ID of the request. You can troubleshoot errors based on the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
