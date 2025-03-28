// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListChangeSetsResponseBody : TeaModel {
        /// <summary>
        /// <para>The change sets.</para>
        /// </summary>
        [NameInMap("ChangeSets")]
        [Validation(Required=false)]
        public List<ListChangeSetsResponseBodyChangeSets> ChangeSets { get; set; }
        public class ListChangeSetsResponseBodyChangeSets : TeaModel {
            /// <summary>
            /// <para>The ID of the change set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1f6521a4-05af-4975-afe9-bc4b45ad****</para>
            /// </summary>
            [NameInMap("ChangeSetId")]
            [Validation(Required=false)]
            public string ChangeSetId { get; set; }

            /// <summary>
            /// <para>The name of the change set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyChangeSet</para>
            /// </summary>
            [NameInMap("ChangeSetName")]
            [Validation(Required=false)]
            public string ChangeSetName { get; set; }

            /// <summary>
            /// <para>The type of the change set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UPDATE</para>
            /// </summary>
            [NameInMap("ChangeSetType")]
            [Validation(Required=false)]
            public string ChangeSetType { get; set; }

            /// <summary>
            /// <para>The time when the change set was created. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-08-01T05:16:31</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the change set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>It is a demo.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The execution status of the change set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AVAILABLE</para>
            /// </summary>
            [NameInMap("ExecutionStatus")]
            [Validation(Required=false)]
            public string ExecutionStatus { get; set; }

            /// <summary>
            /// <para>The region ID of the change set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the stack with which the change set is associated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</para>
            /// </summary>
            [NameInMap("StackId")]
            [Validation(Required=false)]
            public string StackId { get; set; }

            /// <summary>
            /// <para>The name of the stack with which the change set is associated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyStack</para>
            /// </summary>
            [NameInMap("StackName")]
            [Validation(Required=false)]
            public string StackName { get; set; }

            /// <summary>
            /// <para>The status of the change set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CREATE_COMPLETE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The reason why the change set is in its current state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>too many changes</para>
            /// </summary>
            [NameInMap("StatusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListChangeSetsResponseBodyChangeSetsTags> Tags { get; set; }
            public class ListChangeSetsResponseBodyChangeSetsTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B288A0BE-D927-4888-B0F7-B35EF84B6E6F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of change sets returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
