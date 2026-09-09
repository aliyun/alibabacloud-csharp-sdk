// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListCrossProjectDeploymentCandidatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The business response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;RequestId&quot;:&quot;735894D1-D5E5-50B8-8A6D-041C90A98B23&quot;,&quot;PageNumber&quot;:1,&quot;PageSize&quot;:10,&quot;TotalCount&quot;:1,&quot;DeploymentCandidates&quot;:[{&quot;ObjectId&quot;:&quot;1&quot;,&quot;ObjectType&quot;:&quot;ODPS_SQL&quot;,&quot;ObjectName&quot;:&quot;object-1&quot;,&quot;ObjectVersion&quot;:&quot;7&quot;,&quot;ChangeType&quot;:&quot;ADD&quot;,&quot;CommitUser&quot;:&quot;operator&quot;,&quot;CommitTime&quot;:1788739200000}]}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCrossProjectDeploymentCandidatesResponseBodyData Data { get; set; }
        public class ListCrossProjectDeploymentCandidatesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of candidate objects from the source workspace that are available for cross-workspace deployment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;ObjectId&quot;:&quot;1&quot;,&quot;ObjectType&quot;:&quot;ODPS_SQL&quot;,&quot;ObjectName&quot;:&quot;object-1&quot;,&quot;ObjectVersion&quot;:&quot;7&quot;,&quot;ChangeType&quot;:&quot;ADD&quot;,&quot;CommitUser&quot;:&quot;operator&quot;,&quot;CommitTime&quot;:1788739200000}]</para>
            /// </summary>
            [NameInMap("DeploymentCandidates")]
            [Validation(Required=false)]
            public List<ListCrossProjectDeploymentCandidatesResponseBodyDataDeploymentCandidates> DeploymentCandidates { get; set; }
            public class ListCrossProjectDeploymentCandidatesResponseBodyDataDeploymentCandidates : TeaModel {
                /// <summary>
                /// <para>The change type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ADD</para>
                /// </summary>
                [NameInMap("ChangeType")]
                [Validation(Required=false)]
                public string ChangeType { get; set; }

                /// <summary>
                /// <para>The commit time. This value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1788739200000</para>
                /// </summary>
                [NameInMap("CommitTime")]
                [Validation(Required=false)]
                public long? CommitTime { get; set; }

                /// <summary>
                /// <para>The committer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>operator</para>
                /// </summary>
                [NameInMap("CommitUser")]
                [Validation(Required=false)]
                public string CommitUser { get; set; }

                /// <summary>
                /// <para>The candidate object ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ObjectId")]
                [Validation(Required=false)]
                public string ObjectId { get; set; }

                /// <summary>
                /// <para>The candidate object name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>object-1</para>
                /// </summary>
                [NameInMap("ObjectName")]
                [Validation(Required=false)]
                public string ObjectName { get; set; }

                /// <summary>
                /// <para>The candidate object type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ODPS_SQL</para>
                /// </summary>
                [NameInMap("ObjectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                /// <summary>
                /// <para>The candidate object version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("ObjectVersion")]
                [Validation(Required=false)]
                public string ObjectVersion { get; set; }

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
