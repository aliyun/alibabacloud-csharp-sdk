// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class GetErRouteEntryResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
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
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public GetErRouteEntryResponseBodyContent Content { get; set; }
        public class GetErRouteEntryResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>Destination CIDR Block</para>
            /// 
            /// <b>Example:</b>
            /// <para>11.0.0.0/16</para>
            /// </summary>
            [NameInMap("DestinationCidrBlock")]
            [Validation(Required=false)]
            public string DestinationCidrBlock { get; set; }

            /// <summary>
            /// <para>Lingjun HUB Instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>er-aueyxxsy</para>
            /// </summary>
            [NameInMap("ErId")]
            [Validation(Required=false)]
            public string ErId { get; set; }

            /// <summary>
            /// <para>The ID of the route entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>er-rte-4q0jbylz</para>
            /// </summary>
            [NameInMap("ErRouteEntryId")]
            [Validation(Required=false)]
            public string ErRouteEntryId { get; set; }

            /// <summary>
            /// <para>The time when the cluster was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1666677783000</para>
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
            /// <para>cn-hangzhou</para>
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
            /// <para>Route type</para>
            /// 
            /// <b>Example:</b>
            /// <para>System</para>
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

        }

        /// <summary>
        /// <para>The error message. (If the instance is in the Exception state, the exception cause is prompted.)</para>
        /// 
        /// <b>Example:</b>
        /// <para>code: 400, Request was denied due to request throttling. request id: 7D177459-C1CF-5690-BB23-321D208B37D5</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID of the current request</para>
        /// 
        /// <b>Example:</b>
        /// <para>1F38A2E6-CB47-5369-95D2-96D0C287B4A5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
