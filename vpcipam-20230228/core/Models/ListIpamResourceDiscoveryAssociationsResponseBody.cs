// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VpcIpam20230228.Models
{
    public class ListIpamResourceDiscoveryAssociationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The list of associations.</para>
        /// </summary>
        [NameInMap("IpamResourceDiscoveryAssociations")]
        [Validation(Required=false)]
        public List<ListIpamResourceDiscoveryAssociationsResponseBodyIpamResourceDiscoveryAssociations> IpamResourceDiscoveryAssociations { get; set; }
        public class ListIpamResourceDiscoveryAssociationsResponseBodyIpamResourceDiscoveryAssociations : TeaModel {
            /// <summary>
            /// <para>The ID of the IPAM.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ipam-ccxbnsbhew0d6t****</para>
            /// </summary>
            [NameInMap("IpamId")]
            [Validation(Required=false)]
            public string IpamId { get; set; }

            /// <summary>
            /// <para>The ID of resource discovery instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ipam-res-disco-jt5f2af2u6nk2z321****</para>
            /// </summary>
            [NameInMap("IpamResourceDiscoveryId")]
            [Validation(Required=false)]
            public string IpamResourceDiscoveryId { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the resource discovery belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1210123456******</para>
            /// </summary>
            [NameInMap("IpamResourceDiscoveryOwnerId")]
            [Validation(Required=false)]
            public string IpamResourceDiscoveryOwnerId { get; set; }

            /// <summary>
            /// <para>The status of the resource discovery instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Creating</b></description></item>
            /// <item><description><b>Created</b></description></item>
            /// <item><description><b>Modifying</b></description></item>
            /// <item><description><b>Deleting</b></description></item>
            /// <item><description><b>Deleted</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Created</para>
            /// </summary>
            [NameInMap("IpamResourceDiscoveryStatus")]
            [Validation(Required=false)]
            public string IpamResourceDiscoveryStatus { get; set; }

            /// <summary>
            /// <para>The type of resource discovery. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>system</b>: default resource discovery created by the system.</description></item>
            /// <item><description><b>custom</b>: custom resource discovery created by users.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("IpamResourceDiscoveryType")]
            [Validation(Required=false)]
            public string IpamResourceDiscoveryType { get; set; }

            /// <summary>
            /// <para>The status of the associations. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Created</b></description></item>
            /// <item><description><b>Deleted</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Created</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries on each page. Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, there is no next page.</description></item>
        /// <item><description>If a value of <b>NextToken</b> is returned, it indicates the token that is used for the next query.</description></item>
        /// </list>
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
        /// <para>F28A239E-F88D-500E-ADE7-FA5E8CA3A170</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
