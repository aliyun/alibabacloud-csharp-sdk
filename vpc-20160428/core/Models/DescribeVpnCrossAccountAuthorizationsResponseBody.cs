// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpnCrossAccountAuthorizationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of cross-account authorization information for the IPsec-VPN connection.</para>
        /// </summary>
        [NameInMap("CrossAccountAuthorizations")]
        [Validation(Required=false)]
        public List<DescribeVpnCrossAccountAuthorizationsResponseBodyCrossAccountAuthorizations> CrossAccountAuthorizations { get; set; }
        public class DescribeVpnCrossAccountAuthorizationsResponseBodyCrossAccountAuthorizations : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the IPsec-VPN connection belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1250123456123456</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The instance ID of the CEN instance to which the IPsec-VPN connection authorization is granted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cen-vv8h0t3klfpaae****</para>
            /// </summary>
            [NameInMap("BindInstance")]
            [Validation(Required=false)]
            public string BindInstance { get; set; }

            /// <summary>
            /// <para>The type of resource to which the IPsec-VPN connection is authorized.</para>
            /// <para>The value is <b>CEN</b> only, which indicates that the IPsec-VPN connection is authorized to a cross-account Cloud Enterprise Network (CEN) instance. The IPsec-VPN connection can be attached to a transit router instance under the cross-account CEN instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CEN</para>
            /// </summary>
            [NameInMap("BindProduct")]
            [Validation(Required=false)]
            public string BindProduct { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the IPsec-VPN connection is authorized.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1210123456123456</para>
            /// </summary>
            [NameInMap("BindUid")]
            [Validation(Required=false)]
            public long? BindUid { get; set; }

            /// <summary>
            /// <para>The timestamp when the cross-account authorization was created for the IPsec-VPN connection.</para>
            /// <para>The timestamp is in the UNIX format and represents the total number of seconds that have elapsed since January 1, 1970, 00:00:00 UTC to the time when the cross-account authorization was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1658201810000</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            /// <summary>
            /// <para>The ID of the IPsec-VPN connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vco-p0w2jpkhi2eeop6q6****</para>
            /// </summary>
            [NameInMap("VpnConnectionId")]
            [Validation(Required=false)]
            public string VpnConnectionId { get; set; }

        }

        /// <summary>
        /// <para>The page number of the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paging query.</para>
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
        /// <para>DB04E39A-6F0C-36AC-BCA0-B6D371B90062</para>
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

    }

}
