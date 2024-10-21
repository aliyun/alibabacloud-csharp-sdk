// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterEcrAttachmentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>461EC1B5-04A8-4706-8764-8F5BCEF48A6F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The information about the ECR connections.</para>
        /// </summary>
        [NameInMap("TransitRouterAttachments")]
        [Validation(Required=false)]
        public List<ListTransitRouterEcrAttachmentsResponseBodyTransitRouterAttachments> TransitRouterAttachments { get; set; }
        public class ListTransitRouterEcrAttachmentsResponseBodyTransitRouterAttachments : TeaModel {
            /// <summary>
            /// <para>Indicates whether the Enterprise Edition transit router can automatically advertise routes to ECRs.</para>
            /// <para>The value is <b>true</b>, which indicates that the Enterprise Edition transit router can automatically advertise routes to ECRs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoPublishRouteEnabled")]
            [Validation(Required=false)]
            public bool? AutoPublishRouteEnabled { get; set; }

            /// <summary>
            /// <para>The ID of the CEN instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cen-j3jzhw1zpau2km****</para>
            /// </summary>
            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            /// <summary>
            /// <para>The time when the ECR connection was created.</para>
            /// <para>The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-15T02:14Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The ID of the ECR with which the ECR connection is associated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecr-n78omt2qsko06y****</para>
            /// </summary>
            [NameInMap("EcrId")]
            [Validation(Required=false)]
            public string EcrId { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the ECR connection belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1688111111111111</para>
            /// </summary>
            [NameInMap("EcrOwnerId")]
            [Validation(Required=false)]
            public long? EcrOwnerId { get; set; }

            /// <summary>
            /// <para>The entity that pays the fees of the network instance. Valid values: Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PayByCenOwner</b>: The Alibaba Cloud account to which the transit router belongs pays the connection and data forwarding fees of the ECR.</description></item>
            /// <item><description><b>PayByResourceOwner</b>: The Alibaba Cloud account to which the ECR belongs pays the connection and data forwarding fees of the ECR.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PayByCenOwner</para>
            /// </summary>
            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public string OrderType { get; set; }

            /// <summary>
            /// <para>The type of resource to which the transit router is connected. Valid values:</para>
            /// <para>The value is <b>ECR</b>, which indicates ECR connections.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECR</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The status of the ECR connection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Attached</b></description></item>
            /// <item><description><b>Attaching</b></description></item>
            /// <item><description><b>Detaching</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Attached</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListTransitRouterEcrAttachmentsResponseBodyTransitRouterAttachmentsTags> Tags { get; set; }
            public class ListTransitRouterEcrAttachmentsResponseBodyTransitRouterAttachmentsTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The description of the ECR connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desctest</para>
            /// </summary>
            [NameInMap("TransitRouterAttachmentDescription")]
            [Validation(Required=false)]
            public string TransitRouterAttachmentDescription { get; set; }

            /// <summary>
            /// <para>The ID of the ECR connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-attach-nls9fzkfat8934****</para>
            /// </summary>
            [NameInMap("TransitRouterAttachmentId")]
            [Validation(Required=false)]
            public string TransitRouterAttachmentId { get; set; }

            /// <summary>
            /// <para>The name of the ECR connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testname</para>
            /// </summary>
            [NameInMap("TransitRouterAttachmentName")]
            [Validation(Required=false)]
            public string TransitRouterAttachmentName { get; set; }

            /// <summary>
            /// <para>The ID of the Enterprise Edition transit router.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-bp1su1ytdxtataupl****</para>
            /// </summary>
            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

            /// <summary>
            /// <para>The region ID of the transit router.</para>
            /// <para>You can call the <a href="https://help.aliyun.com/document_detail/132080.html">DescribeChildInstanceRegions</a> operation to query the most recent region list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("TransitRouterRegionId")]
            [Validation(Required=false)]
            public string TransitRouterRegionId { get; set; }

        }

    }

}
