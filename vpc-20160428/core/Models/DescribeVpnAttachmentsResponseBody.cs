// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpnAttachmentsResponseBody : TeaModel {
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
        /// <para>9F0725BB-186A-3564-91C3-AAE48042F853</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The list of IPsec-VPN connections associated with the transit router.</para>
        /// </summary>
        [NameInMap("VpnAttachments")]
        [Validation(Required=false)]
        public List<DescribeVpnAttachmentsResponseBodyVpnAttachments> VpnAttachments { get; set; }
        public class DescribeVpnAttachmentsResponseBodyVpnAttachments : TeaModel {
            /// <summary>
            /// <para>The type of resource that is associated with the IPsec-VPN connection. The value is set to <b>CEN</b>, which indicates that the IPsec-VPN connection is associated with a transit router.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CEN</para>
            /// </summary>
            [NameInMap("AttachType")]
            [Validation(Required=false)]
            public string AttachType { get; set; }

            /// <summary>
            /// <para>Indicates whether the IPsec-VPN connection is associated with a transit router that belongs to another Alibaba Cloud account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("CrossAccountAuthorized")]
            [Validation(Required=false)]
            public bool? CrossAccountAuthorized { get; set; }

            /// <summary>
            /// <para>The description of the IPsec-VPN connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desctest</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the IPsec-VPN connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vco-p0w2jpkhi2eeop6q6****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the IPsec-VPN connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nametest1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The system tags of the IPsec-VPN connection.</para>
            /// <para>You can check whether an IPsec-VPN connection supports BGP based on the system tags.</para>
            /// <para><b>BGPSupport</b>: indicates whether the IPsec-VPN connection supports BGP.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;description\&quot;:\&quot;forwarding 1.7.22\&quot;,\&quot;VisuallySsl\&quot;:\&quot;true\&quot;,\&quot;PbrPriority\&quot;:\&quot;true\&quot;,\&quot;BGPSupport\&quot;:\&quot;true\&quot;,\&quot;IDaaSNewVersion\&quot;:\&quot;true\&quot;}</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <para>The list of tags to be added to the IPsec-VPN connection.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeVpnAttachmentsResponseBodyVpnAttachmentsTags> Tags { get; set; }
            public class DescribeVpnAttachmentsResponseBodyVpnAttachmentsTags : TeaModel {
                /// <summary>
                /// <para>The tag key of the IPsec-VPN connection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TagKey</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value of the IPsec-VPN connection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TagValue</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The ID of the transit router with which the IPsec-VPN connection is associated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-p0wkh4yryb1dnanqw****</para>
            /// </summary>
            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

            /// <summary>
            /// <para>The name of the transit router.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nametest2</para>
            /// </summary>
            [NameInMap("TransitRouterName")]
            [Validation(Required=false)]
            public string TransitRouterName { get; set; }

            [NameInMap("TunnelBandwidth")]
            [Validation(Required=false)]
            public string TunnelBandwidth { get; set; }

        }

    }

}
