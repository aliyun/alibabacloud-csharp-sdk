// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VpcIpam20230228.Models
{
    public class ListIpamResourceDiscoveryAssociationsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("IpamResourceDiscoveryAssociations")]
        [Validation(Required=false)]
        public List<ListIpamResourceDiscoveryAssociationsResponseBodyIpamResourceDiscoveryAssociations> IpamResourceDiscoveryAssociations { get; set; }
        public class ListIpamResourceDiscoveryAssociationsResponseBodyIpamResourceDiscoveryAssociations : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ipam-ccxbnsbhew0d6t****</para>
            /// </summary>
            [NameInMap("IpamId")]
            [Validation(Required=false)]
            public string IpamId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ipam-res-disco-jt5f2af2u6nk2z321****</para>
            /// </summary>
            [NameInMap("IpamResourceDiscoveryId")]
            [Validation(Required=false)]
            public string IpamResourceDiscoveryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1210123456******</para>
            /// </summary>
            [NameInMap("IpamResourceDiscoveryOwnerId")]
            [Validation(Required=false)]
            public string IpamResourceDiscoveryOwnerId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Created</para>
            /// </summary>
            [NameInMap("IpamResourceDiscoveryStatus")]
            [Validation(Required=false)]
            public string IpamResourceDiscoveryStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("IpamResourceDiscoveryType")]
            [Validation(Required=false)]
            public string IpamResourceDiscoveryType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Created</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F28A239E-F88D-500E-ADE7-FA5E8CA3A170</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
