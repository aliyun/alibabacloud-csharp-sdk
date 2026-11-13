// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDataServiceGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination result of the business flows.</para>
        /// </summary>
        [NameInMap("GroupPagingResult")]
        [Validation(Required=false)]
        public ListDataServiceGroupsResponseBodyGroupPagingResult GroupPagingResult { get; set; }
        public class ListDataServiceGroupsResponseBodyGroupPagingResult : TeaModel {
            /// <summary>
            /// <para>The list of business flows.</para>
            /// </summary>
            [NameInMap("Groups")]
            [Validation(Required=false)]
            public List<ListDataServiceGroupsResponseBodyGroupPagingResultGroups> Groups { get; set; }
            public class ListDataServiceGroupsResponseBodyGroupPagingResultGroups : TeaModel {
                /// <summary>
                /// <para>The ID of the API Gateway group bound to the business flow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100abc</para>
                /// </summary>
                [NameInMap("ApiGatewayGroupId")]
                [Validation(Required=false)]
                public string ApiGatewayGroupId { get; set; }

                /// <summary>
                /// <para>The gateway version. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: API Gateway.</description></item>
                /// <item><description>2: Cloud-native API Gateway.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ApigwVersion")]
                [Validation(Required=false)]
                public int? ApigwVersion { get; set; }

                /// <summary>
                /// <para>The ID of the destination REST API in the cloud-native API Gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>api-xxx</para>
                /// </summary>
                [NameInMap("CloudNativeApigwGroupId")]
                [Validation(Required=false)]
                public string CloudNativeApigwGroupId { get; set; }

                /// <summary>
                /// <para>The creation time of the business flow. The format is <c>yyyy-MM-dd\\&quot;T\\&quot;HH:mm:ssZ</c>, such as <c>2020-09-24T18:37:51+0800</c>. The time zone offset in this example is <c>+0800</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-09-24T18:37:51+0800</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// <para>The UID of the creator. The creator UID of some historical business flows may be empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10001</para>
                /// </summary>
                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                /// <summary>
                /// <para>The description of the business flow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Business flow description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the business flow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ds_123abc</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The name of the business flow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Business flow name</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The modification time of the business flow. The format is <c>yyyy-MM-dd\\&quot;T\\&quot;HH:mm:ssZ</c>, such as <c>2020-09-24T18:37:51+0800</c>. The time zone offset in this example is <c>+0800</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-09-24T18:37:51+0800</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <para>The ID of the workspace.</para>
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
            /// <para>The page number. The value is the same as the PageNumber parameter in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries returned on each page. Default value: 10. Maximum value: 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
