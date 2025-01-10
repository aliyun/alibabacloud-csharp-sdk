// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class ListErRouteMapsResponseBody : TeaModel {
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
        public ListErRouteMapsResponseBodyContent Content { get; set; }
        public class ListErRouteMapsResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>routing policy information list</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListErRouteMapsResponseBodyContentData> Data { get; set; }
            public class ListErRouteMapsResponseBodyContentData : TeaModel {
                /// <summary>
                /// <para>Policy behavior; optional values:</para>
                /// <list type="bullet">
                /// <item><description><b>permit</b>: Allow</description></item>
                /// <item><description><b>deny</b>: Prohibited</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>permit</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The time when the data address was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1601176751000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>Policy description</para>
                /// 
                /// <b>Example:</b>
                /// <para>No description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Destination CIDR Block</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0.0.0/0</para>
                /// </summary>
                [NameInMap("DestinationCidrBlock")]
                [Validation(Required=false)]
                public string DestinationCidrBlock { get; set; }

                /// <summary>
                /// <para>Lingjun HUB ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>er-kkopgtne</para>
                /// </summary>
                [NameInMap("ErId")]
                [Validation(Required=false)]
                public string ErId { get; set; }

                /// <summary>
                /// <para>routing policy ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>er-rmap-uwglhzom</para>
                /// </summary>
                [NameInMap("ErRouteMapId")]
                [Validation(Required=false)]
                public string ErRouteMapId { get; set; }

                /// <summary>
                /// <para>The time when the agent was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1601176751000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The message that is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>Receive Instance ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpd-9rgxqazc</para>
                /// </summary>
                [NameInMap("ReceptionInstanceId")]
                [Validation(Required=false)]
                public string ReceptionInstanceId { get; set; }

                /// <summary>
                /// <para>Receive Instance Name</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpd-reception</para>
                /// </summary>
                [NameInMap("ReceptionInstanceName")]
                [Validation(Required=false)]
                public string ReceptionInstanceName { get; set; }

                /// <summary>
                /// <para>The tenant to which the receiving instance belongs</para>
                /// 
                /// <b>Example:</b>
                /// <para>1620939556166277</para>
                /// </summary>
                [NameInMap("ReceptionInstanceOwner")]
                [Validation(Required=false)]
                public string ReceptionInstanceOwner { get; set; }

                /// <summary>
                /// <para>The type of the received instance. Possible values:</para>
                /// <list type="bullet">
                /// <item><description><b>VPD</b>: Lingjun network segment.</description></item>
                /// <item><description><b>VCC</b>: Lingjun Connection.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>VPD</para>
                /// </summary>
                [NameInMap("ReceptionInstanceType")]
                [Validation(Required=false)]
                public string ReceptionInstanceType { get; set; }

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
                /// <para>The ID of the policy.</para>
                /// <para>A smaller sequence number indicates a lower priority. When a route is matched, a policy with a higher priority is preferentially matched.</para>
                /// <para><b>Valid values: 1001 to 2000</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>1001</para>
                /// </summary>
                [NameInMap("RouteMapNum")]
                [Validation(Required=false)]
                public int? RouteMapNum { get; set; }

                /// <summary>
                /// <para>Status The status of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Available</b></description></item>
                /// <item><description><b>Not Available</b>: Unavailable</description></item>
                /// <item><description><b>Executing</b>: Executing</description></item>
                /// <item><description><b>Deleting</b>: The node is being deleted.</description></item>
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
                /// <para>1655449505171</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// <para>Release Instance ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpd-8rgvqazb</para>
                /// </summary>
                [NameInMap("TransmissionInstanceId")]
                [Validation(Required=false)]
                public string TransmissionInstanceId { get; set; }

                /// <summary>
                /// <para>Release Instance Name</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpd-transmit</para>
                /// </summary>
                [NameInMap("TransmissionInstanceName")]
                [Validation(Required=false)]
                public string TransmissionInstanceName { get; set; }

                /// <summary>
                /// <para>The tenant to which the published instance belongs</para>
                /// 
                /// <b>Example:</b>
                /// <para>1620939556166277</para>
                /// </summary>
                [NameInMap("TransmissionInstanceOwner")]
                [Validation(Required=false)]
                public string TransmissionInstanceOwner { get; set; }

                /// <summary>
                /// <para>The type of the published instance. Possible values:</para>
                /// <list type="bullet">
                /// <item><description><b>VPD</b>: Lingjun network segment.</description></item>
                /// <item><description><b>VCC</b>: Lingjun Connection.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>VPD</para>
                /// </summary>
                [NameInMap("TransmissionInstanceType")]
                [Validation(Required=false)]
                public string TransmissionInstanceType { get; set; }

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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0901F411-28FA-5B9C-BAEE-7776463FF0DC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
