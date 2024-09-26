// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDataServiceGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The paging result for the business processes.</para>
        /// </summary>
        [NameInMap("GroupPagingResult")]
        [Validation(Required=false)]
        public ListDataServiceGroupsResponseBodyGroupPagingResult GroupPagingResult { get; set; }
        public class ListDataServiceGroupsResponseBodyGroupPagingResult : TeaModel {
            /// <summary>
            /// <para>The business processes.</para>
            /// </summary>
            [NameInMap("Groups")]
            [Validation(Required=false)]
            public List<ListDataServiceGroupsResponseBodyGroupPagingResultGroups> Groups { get; set; }
            public class ListDataServiceGroupsResponseBodyGroupPagingResultGroups : TeaModel {
                /// <summary>
                /// <para>The ID of the API Gateway group to which the workflow is bound.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100abc</para>
                /// </summary>
                [NameInMap("ApiGatewayGroupId")]
                [Validation(Required=false)]
                public string ApiGatewayGroupId { get; set; }

                /// <summary>
                /// <para>The time when the business process was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-09-24T18:37:51+0800</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// <para>The user identifier (UID) of the creator of the business process. The value of this parameter may be empty for creators of some existing business processes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10001</para>
                /// </summary>
                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                /// <summary>
                /// <para>The description of the business process.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The business process ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ds_123abc</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The name of the business process.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The time when the business process was modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-09-24T18:37:51+0800</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <para>The workspace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10002</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The tenant ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10003</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public long? TenantId { get; set; }

            }

            /// <summary>
            /// <para>The page number. The value of this parameter is the same as that of the PageNumber parameter in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
