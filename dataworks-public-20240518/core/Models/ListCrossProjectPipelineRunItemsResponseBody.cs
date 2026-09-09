// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListCrossProjectPipelineRunItemsResponseBody : TeaModel {
        /// <summary>
        /// <para>The business response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;RequestId&quot;:&quot;735894D1-D5E5-50B8-8A6D-041C90A98B23&quot;,&quot;PageNumber&quot;:1,&quot;PageSize&quot;:10,&quot;TotalCount&quot;:1,&quot;PipelineRunItems&quot;:[{&quot;ObjectId&quot;:&quot;1&quot;,&quot;ObjectType&quot;:&quot;ODPS_SQL&quot;,&quot;ObjectName&quot;:&quot;object-1&quot;,&quot;ObjectVersion&quot;:&quot;7&quot;,&quot;ChangeType&quot;:&quot;ADD&quot;,&quot;IsRoot&quot;:true,&quot;Status&quot;:&quot;Ready&quot;}]}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCrossProjectPipelineRunItemsResponseBodyData Data { get; set; }
        public class ListCrossProjectPipelineRunItemsResponseBodyData : TeaModel {
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
            /// <para>The list of publish items for the root objects and their child objects that are included in the cross-workspace publish pipeline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;ObjectId&quot;:&quot;1&quot;,&quot;ObjectType&quot;:&quot;ODPS_SQL&quot;,&quot;ObjectName&quot;:&quot;object-1&quot;,&quot;ObjectVersion&quot;:&quot;7&quot;,&quot;ChangeType&quot;:&quot;ADD&quot;,&quot;IsRoot&quot;:true,&quot;Status&quot;:&quot;Ready&quot;}]</para>
            /// </summary>
            [NameInMap("PipelineRunItems")]
            [Validation(Required=false)]
            public List<ListCrossProjectPipelineRunItemsResponseBodyDataPipelineRunItems> PipelineRunItems { get; set; }
            public class ListCrossProjectPipelineRunItemsResponseBodyDataPipelineRunItems : TeaModel {
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
                /// <para>The error code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DeploymentItemFailed</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Deployment failed</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>Indicates whether the object is a root object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsRoot")]
                [Validation(Required=false)]
                public bool? IsRoot { get; set; }

                /// <summary>
                /// <para>The ID of the publish object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ObjectId")]
                [Validation(Required=false)]
                public string ObjectId { get; set; }

                /// <summary>
                /// <para>The name of the publish object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>object-1</para>
                /// </summary>
                [NameInMap("ObjectName")]
                [Validation(Required=false)]
                public string ObjectName { get; set; }

                /// <summary>
                /// <para>The object type of the publish object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ODPS_SQL</para>
                /// </summary>
                [NameInMap("ObjectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                /// <summary>
                /// <para>The version of the publish object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("ObjectVersion")]
                [Validation(Required=false)]
                public string ObjectVersion { get; set; }

                /// <summary>
                /// <para>The ID of the parent object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ParentObjectId")]
                [Validation(Required=false)]
                public string ParentObjectId { get; set; }

                /// <summary>
                /// <para>The status of the publish item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Ready</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

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
