// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class ListErRouteEntriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

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
        public ListErRouteEntriesResponseBodyContent Content { get; set; }
        public class ListErRouteEntriesResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>Lingjun HUB Route Entry Information List</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListErRouteEntriesResponseBodyContentData> Data { get; set; }
            public class ListErRouteEntriesResponseBodyContentData : TeaModel {
                /// <summary>
                /// <para>Destination CIDR Block</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.64.1.100/32</para>
                /// </summary>
                [NameInMap("DestinationCidrBlock")]
                [Validation(Required=false)]
                public string DestinationCidrBlock { get; set; }

                /// <summary>
                /// <para>Lingjun HUB Instance ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>er-kkopgtne</para>
                /// </summary>
                [NameInMap("ErId")]
                [Validation(Required=false)]
                public string ErId { get; set; }

                /// <summary>
                /// <para>The ID of the route entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>er-rte-maysfadg</para>
                /// </summary>
                [NameInMap("ErRouteEntryId")]
                [Validation(Required=false)]
                public string ErRouteEntryId { get; set; }

                /// <summary>
                /// <para>The time when the cluster was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1640930901000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>Next Hop Instance</para>
                /// 
                /// <b>Example:</b>
                /// <para>vcc-cn-209300qha01</para>
                /// </summary>
                [NameInMap("NextHopId")]
                [Validation(Required=false)]
                public string NextHopId { get; set; }

                /// <summary>
                /// <para>Next Hop Instance Type</para>
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
                /// <para>rg-aekzb3n5lgk2ieq</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The ID of the tenant to which the resource belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1111156667137893</para>
                /// </summary>
                [NameInMap("ResourceTenantId")]
                [Validation(Required=false)]
                public string ResourceTenantId { get; set; }

                /// <summary>
                /// <para>Route type</para>
                /// 
                /// <b>Example:</b>
                /// <para>VCC</para>
                /// </summary>
                [NameInMap("RouteType")]
                [Validation(Required=false)]
                public string RouteType { get; set; }

                /// <summary>
                /// <para>The task status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Synchronizing</description></item>
                /// <item><description>Available</description></item>
                /// </list>
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
                /// <para>1111156667137893</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

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
        /// <para>The error message. (If the instance is in the Exception state, the exception cause is prompted.)</para>
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
