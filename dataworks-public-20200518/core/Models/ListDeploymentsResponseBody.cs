// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDeploymentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDeploymentsResponseBodyData Data { get; set; }
        public class ListDeploymentsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The deployment packages.</para>
            /// </summary>
            [NameInMap("Deployments")]
            [Validation(Required=false)]
            public List<ListDeploymentsResponseBodyDataDeployments> Deployments { get; set; }
            public class ListDeploymentsResponseBodyDataDeployments : TeaModel {
                /// <summary>
                /// <para>The time when the deployment package was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1593877765000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account used by the user who created the deployment package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2003****</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>The error message returned when the deployment package failed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OK</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The time when the deployment package was run. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1593877765000</para>
                /// </summary>
                [NameInMap("ExecuteTime")]
                [Validation(Required=false)]
                public long? ExecuteTime { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account used by the user who ran the deployment package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2003****</para>
                /// </summary>
                [NameInMap("Executor")]
                [Validation(Required=false)]
                public string Executor { get; set; }

                /// <summary>
                /// <para>The deployment package ID. You can call the <a href="https://help.aliyun.com/document_detail/173950.html">GetDeployment</a> operation to obtain the ID.</para>
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
                /// <para>The status of the deployment package. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: The deployment package is ready.</description></item>
                /// <item><description>1: The deployment package is deployed.</description></item>
                /// <item><description>2: The deployment package fails to be deployed.</description></item>
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
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
