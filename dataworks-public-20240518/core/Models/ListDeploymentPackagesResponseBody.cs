// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDeploymentPackagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of deployment packages that meet the query conditions.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDeploymentPackagesResponseBodyData Data { get; set; }
        public class ListDeploymentPackagesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of deployment packages.</para>
            /// </summary>
            [NameInMap("Deployments")]
            [Validation(Required=false)]
            public List<ListDeploymentPackagesResponseBodyDataDeployments> Deployments { get; set; }
            public class ListDeploymentPackagesResponseBodyDataDeployments : TeaModel {
                /// <summary>
                /// <para>The timestamp when the deployment package was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1593877765000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud user ID of the deployment package creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2003****</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>The error message recorded when the deployment package fails to be executed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OK</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The timestamp when the deployment package was executed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1593877765000</para>
                /// </summary>
                [NameInMap("ExecuteTime")]
                [Validation(Required=false)]
                public long? ExecuteTime { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud user ID of the deployment package executor.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2003****</para>
                /// </summary>
                [NameInMap("Executor")]
                [Validation(Required=false)]
                public string Executor { get; set; }

                /// <summary>
                /// <para>The ID of the deployment package. You can use this ID to call the <a href="https://help.aliyun.com/document_detail/173950.html">GetDeployment</a> operation to obtain the details of the deployment package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11111</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The name of the deployment package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>auto_created</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The current status of the deployment package. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: The deployment package is ready.</description></item>
                /// <item><description>1: The deployment package is published.</description></item>
                /// <item><description>2: The deployment package failed to be published.</description></item>
                /// <item><description>6: The deployment package is rejected.</description></item>
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
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries that meet the conditions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>952795279527ab****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
