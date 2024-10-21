// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterVbrAttachmentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dd20****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F42D9616-29EB-4E75-8CA8-9654D4E07501</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>A list of VBR connections.</para>
        /// </summary>
        [NameInMap("TransitRouterAttachments")]
        [Validation(Required=false)]
        public List<ListTransitRouterVbrAttachmentsResponseBodyTransitRouterAttachments> TransitRouterAttachments { get; set; }
        public class ListTransitRouterVbrAttachmentsResponseBodyTransitRouterAttachments : TeaModel {
            /// <summary>
            /// <para>Indicates whether the Enterprise Edition transit router is allowed to automatically advertise routes to the VBR. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>false</b> (default)</description></item>
            /// <item><description><b>true</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
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
            /// <para>The time when the VBR connection was created.</para>
            /// <para>The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-15T15:20Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The entity that pays the fees of the network instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PayByCenOwner</b>: the Alibaba Cloud account that owns the CEN instance.</description></item>
            /// <item><description><b>PayByResourceOwner</b>: the Alibaba Cloud account that owns the network instance.</description></item>
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
            /// <list type="bullet">
            /// <item><description><b>VPC</b></description></item>
            /// <item><description><b>CCN</b></description></item>
            /// <item><description><b>VBR</b></description></item>
            /// <item><description><b>TR</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VBR</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The status of the VBR connection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Attached</b></description></item>
            /// <item><description><b>Attaching</b></description></item>
            /// <item><description><b>Detaching</b></description></item>
            /// <item><description><b>Detached</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Attached</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>A list of tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListTransitRouterVbrAttachmentsResponseBodyTransitRouterAttachmentsTags> Tags { get; set; }
            public class ListTransitRouterVbrAttachmentsResponseBodyTransitRouterAttachmentsTags : TeaModel {
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
                /// <para>value_A1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The description of the VBR connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testdesc</para>
            /// </summary>
            [NameInMap("TransitRouterAttachmentDescription")]
            [Validation(Required=false)]
            public string TransitRouterAttachmentDescription { get; set; }

            /// <summary>
            /// <para>The ID of the VBR connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-attach-oyf70wfuorwx87****</para>
            /// </summary>
            [NameInMap("TransitRouterAttachmentId")]
            [Validation(Required=false)]
            public string TransitRouterAttachmentId { get; set; }

            /// <summary>
            /// <para>The name of the VBR connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testa</para>
            /// </summary>
            [NameInMap("TransitRouterAttachmentName")]
            [Validation(Required=false)]
            public string TransitRouterAttachmentName { get; set; }

            /// <summary>
            /// <para>The description of the Enterprise Edition transit router.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-bp1su1ytdxtataupl****</para>
            /// </summary>
            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

            /// <summary>
            /// <para>The VBR ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vbr-bp1svadp4lq38janc****</para>
            /// </summary>
            [NameInMap("VbrId")]
            [Validation(Required=false)]
            public string VbrId { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the VBR belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1688111111111111</para>
            /// </summary>
            [NameInMap("VbrOwnerId")]
            [Validation(Required=false)]
            public long? VbrOwnerId { get; set; }

            /// <summary>
            /// <para>The region ID of the VBR.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("VbrRegionId")]
            [Validation(Required=false)]
            public string VbrRegionId { get; set; }

        }

    }

}
