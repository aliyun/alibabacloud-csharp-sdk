// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class ListVccRouteEntriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public ListVccRouteEntriesResponseBodyContent Content { get; set; }
        public class ListVccRouteEntriesResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>List of Lingjun Connection Route Entries</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListVccRouteEntriesResponseBodyContentData> Data { get; set; }
            public class ListVccRouteEntriesResponseBodyContentData : TeaModel {
                /// <summary>
                /// <para>Destination CIDR block</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.192.32.0/24</para>
                /// </summary>
                [NameInMap("DestinationCidrBlock")]
                [Validation(Required=false)]
                public string DestinationCidrBlock { get; set; }

                /// <summary>
                /// <para>The time when the cluster was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1642745758000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The returned message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>Next Hop Instance</para>
                /// 
                /// <b>Example:</b>
                /// <para>vcc-cn-zvp2w222001</para>
                /// </summary>
                [NameInMap("NextHopId")]
                [Validation(Required=false)]
                public string NextHopId { get; set; }

                /// <summary>
                /// <para>Next Hop Type</para>
                /// 
                /// <b>Example:</b>
                /// <para>VCC</para>
                /// </summary>
                [NameInMap("NextHopType")]
                [Validation(Required=false)]
                public string NextHopType { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-wulanchabu</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>Resource group instance ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-aek2l4sq6l7unhi</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The ID of the tenant to which the resource belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1655449505171</para>
                /// </summary>
                [NameInMap("ResourceTenantId")]
                [Validation(Required=false)]
                public string ResourceTenantId { get; set; }

                /// <summary>
                /// <para>Route type</para>
                /// 
                /// <b>Example:</b>
                /// <para>BGP</para>
                /// </summary>
                [NameInMap("RouteType")]
                [Validation(Required=false)]
                public string RouteType { get; set; }

                /// <summary>
                /// <para>The status of the intervention entry. Valid value:</para>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The ID of the tenant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1655449505171</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// <para>The ID of the Lingjun connection instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vcc-cn-zvp2w222001</para>
                /// </summary>
                [NameInMap("VccId")]
                [Validation(Required=false)]
                public string VccId { get; set; }

                /// <summary>
                /// <para>The ID of the route entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vcc-rte-maysfadg</para>
                /// </summary>
                [NameInMap("VccRouteEntryId")]
                [Validation(Required=false)]
                public string VccRouteEntryId { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>response message, if the success request is</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID of the current request</para>
        /// 
        /// <b>Example:</b>
        /// <para>A88DFED5-24B7-5A3E-87DE-380BF06F3C90</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
