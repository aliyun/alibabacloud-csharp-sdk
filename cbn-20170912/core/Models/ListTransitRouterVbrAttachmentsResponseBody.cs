// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterVbrAttachmentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that determines the start point of the query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If this is the first query or no subsequent query is to be sent, you do not need to specify this parameter.</description></item>
        /// <item><description>If a subsequent query is to be sent, set the value to the NextToken value returned by the previous API call.</description></item>
        /// </list>
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
        /// <para>The list of VBR connections.</para>
        /// </summary>
        [NameInMap("TransitRouterAttachments")]
        [Validation(Required=false)]
        public List<ListTransitRouterVbrAttachmentsResponseBodyTransitRouterAttachments> TransitRouterAttachments { get; set; }
        public class ListTransitRouterVbrAttachmentsResponseBodyTransitRouterAttachments : TeaModel {
            /// <summary>
            /// <para>Indicates whether the Enterprise Edition forward routing automatically publishes route entries to the VBR instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>false</b>: The Enterprise Edition forward routing does not automatically publish route entries to the VBR instance.</description></item>
            /// <item><description><b>true</b>: The Enterprise Edition forward routing automatically publishes route entries to the VBR instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AutoPublishRouteEnabled")]
            [Validation(Required=false)]
            public bool? AutoPublishRouteEnabled { get; set; }

            /// <summary>
            /// <para>The CEN instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cen-j3jzhw1zpau2km****</para>
            /// </summary>
            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            /// <summary>
            /// <para>The time when the VBR connection was created.</para>
            /// <para>The time is displayed in the ISO 8601 standard in UTC. Format: YYYY-MM-DDThh:mmZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-15T15:20Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The cloud service that manages the VBR connection. This parameter is returned only when the VBR connection is managed by a cloud service. The standard code of the cloud service is returned. If the VBR connection is managed by you, this parameter is not returned.</para>
            /// </summary>
            [NameInMap("ManagedService")]
            [Validation(Required=false)]
            public string ManagedService { get; set; }

            /// <summary>
            /// <para>The payer of the network instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PayByCenOwner</b>: The connection fee and data processing fee of the VBR instance are paid by the account to which the transit router instance belongs.</description></item>
            /// <item><description><b>PayByResourceOwner</b>: The connection fee and data processing fee of the VBR instance are paid by the account to which the VBR instance belongs.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PayByCenOwner</para>
            /// </summary>
            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public string OrderType { get; set; }

            /// <summary>
            /// <para>The type of resource to which the connection belongs.</para>
            /// <para>The value is <b>VBR</b>, which indicates a virtual border router instance.</para>
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
            /// <item><description><b>Attached</b>: The VBR connection is attached.</description></item>
            /// <item><description><b>Attaching</b>: The VBR connection is being attached.</description></item>
            /// <item><description><b>Detaching</b>: The VBR connection is being detached.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Attached</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The list of tags.</para>
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
            /// <para>The Enterprise Edition forward routing instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-bp1su1ytdxtataupl****</para>
            /// </summary>
            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

            /// <summary>
            /// <para>The VBR instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vbr-bp1svadp4lq38janc****</para>
            /// </summary>
            [NameInMap("VbrId")]
            [Validation(Required=false)]
            public string VbrId { get; set; }

            /// <summary>
            /// <para>The ID of the account to which the VBR instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1688111111111111</para>
            /// </summary>
            [NameInMap("VbrOwnerId")]
            [Validation(Required=false)]
            public long? VbrOwnerId { get; set; }

            /// <summary>
            /// <para>The region ID of the VBR instance.</para>
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
