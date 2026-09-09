// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListCrossProjectDeploymentEnvironmentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The business response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;RequestId&quot;:&quot;735894D1-D5E5-50B8-8A6D-041C90A98B23&quot;,&quot;PageNumber&quot;:1,&quot;PageSize&quot;:10,&quot;TotalCount&quot;:1,&quot;DeploymentEnvironments&quot;:[{&quot;DeploymentEnvironmentId&quot;:101,&quot;Name&quot;:&quot;environment-101&quot;,&quot;SourceProjectId&quot;:10,&quot;TargetProjectId&quot;:20,&quot;TargetProjectName&quot;:&quot;target&quot;,&quot;Status&quot;:&quot;Enabled&quot;}]}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCrossProjectDeploymentEnvironmentsResponseBodyData Data { get; set; }
        public class ListCrossProjectDeploymentEnvironmentsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of enabled cross-workspace deployment environments in the source project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;DeploymentEnvironmentId&quot;:101,&quot;Name&quot;:&quot;environment-101&quot;,&quot;SourceProjectId&quot;:10,&quot;TargetProjectId&quot;:20,&quot;TargetProjectName&quot;:&quot;target&quot;,&quot;Status&quot;:&quot;Enabled&quot;}]</para>
            /// </summary>
            [NameInMap("DeploymentEnvironments")]
            [Validation(Required=false)]
            public List<ListCrossProjectDeploymentEnvironmentsResponseBodyDataDeploymentEnvironments> DeploymentEnvironments { get; set; }
            public class ListCrossProjectDeploymentEnvironmentsResponseBodyDataDeploymentEnvironments : TeaModel {
                /// <summary>
                /// <para>The cross-workspace deployment environment ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>101</para>
                /// </summary>
                [NameInMap("DeploymentEnvironmentId")]
                [Validation(Required=false)]
                public long? DeploymentEnvironmentId { get; set; }

                /// <summary>
                /// <para>The environment name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>environment-101</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The source project workspace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("SourceProjectId")]
                [Validation(Required=false)]
                public long? SourceProjectId { get; set; }

                /// <summary>
                /// <para>The environment status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Enabled</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The target project workspace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("TargetProjectId")]
                [Validation(Required=false)]
                public long? TargetProjectId { get; set; }

                /// <summary>
                /// <para>The target project workspace name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>target</para>
                /// </summary>
                [NameInMap("TargetProjectName")]
                [Validation(Required=false)]
                public string TargetProjectName { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The request ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>735894D1-D5E5-50B8-8A6D-041C90A98B23</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot this API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>735894D1-D5E5-50B8-8A6D-041C90A98B23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
