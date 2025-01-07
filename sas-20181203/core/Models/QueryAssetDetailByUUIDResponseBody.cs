// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class QueryAssetDetailByUUIDResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>200</b>: The request was successful.</description></item>
        /// <item><description><b>Other codes</b>: The request failed. For a list of error codes, see <a href="https://help.aliyun.com/document_detail/145071.html">Service error codes</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryAssetDetailByUUIDResponseBodyData> Data { get; set; }
        public class QueryAssetDetailByUUIDResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1766185894104***</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The edition of Security Center that is authorized to protect the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Basic.</description></item>
            /// <item><description><b>6</b>: Anti-virus.</description></item>
            /// <item><description><b>5</b>: Advanced.</description></item>
            /// <item><description><b>3</b>: Enterprise.</description></item>
            /// <item><description><b>7</b>: Ultimate.</description></item>
            /// <item><description><b>10</b>: Value-added Plan.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("AuthVersion")]
            [Validation(Required=false)]
            public int? AuthVersion { get; set; }

            /// <summary>
            /// <para>The virtual network operator (VNO).</para>
            /// 
            /// <b>Example:</b>
            /// <para>26842</para>
            /// </summary>
            [NameInMap("Bid")]
            [Validation(Required=false)]
            public string Bid { get; set; }

            /// <summary>
            /// <para>Indicates whether Security Center is authorized to protect the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Bind")]
            [Validation(Required=false)]
            public bool? Bind { get; set; }

            /// <summary>
            /// <para>The status of the Security Center agent. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>online</b></description></item>
            /// <item><description><b>offline</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("ClientStatus")]
            [Validation(Required=false)]
            public string ClientStatus { get; set; }

            /// <summary>
            /// <para>The ID of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c8ca91e0907d94efaba7fb0827eb9****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The IP address of the elastic network interface (ENI).</para>
            /// 
            /// <b>Example:</b>
            /// <para>116.162.XX.XX</para>
            /// </summary>
            [NameInMap("Eip")]
            [Validation(Required=false)]
            public string Eip { get; set; }

            /// <summary>
            /// <para>Indicates whether the asset is provided by Alibaba Cloud. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: yes.</description></item>
            /// <item><description><b>1</b>: no.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Flag")]
            [Validation(Required=false)]
            public int? Flag { get; set; }

            /// <summary>
            /// <para>The time at which the asset was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-10-16 18:17:16</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time at which the asset was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-21 10:40:01</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The ID of the group to which the server belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12208928</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            /// <summary>
            /// <para>The ID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>443496</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The public IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.42.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The instance ID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c8ca91e0907d94efaba7fb0827eb9</para>
            /// </summary>
            [NameInMap("MachineInstanceId")]
            [Validation(Required=false)]
            public string MachineInstanceId { get; set; }

            /// <summary>
            /// <para>The IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.XX.XX</para>
            /// </summary>
            [NameInMap("MachineIp")]
            [Validation(Required=false)]
            public string MachineIp { get; set; }

            /// <summary>
            /// <para>The type of the IP address for the server. Valid values include the following values:</para>
            /// <list type="bullet">
            /// <item><description><b>ecs</b>: the IP address of the Elastic Compute Service (ECS) instance.</description></item>
            /// <item><description><b>slb</b>: the IP address of the Server Load Balancer (SLB) instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SLB</para>
            /// </summary>
            [NameInMap("MachineIpType")]
            [Validation(Required=false)]
            public string MachineIpType { get; set; }

            /// <summary>
            /// <para>The name of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>security</para>
            /// </summary>
            [NameInMap("MachineName")]
            [Validation(Required=false)]
            public string MachineName { get; set; }

            /// <summary>
            /// <para>The region in which the server resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("MachineRegion")]
            [Validation(Required=false)]
            public string MachineRegion { get; set; }

            /// <summary>
            /// <para>The instance type of the server. Valid values include the following values:</para>
            /// <list type="bullet">
            /// <item><description><b>ecs</b></description></item>
            /// <item><description><b>slb</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("MachineType")]
            [Validation(Required=false)]
            public string MachineType { get; set; }

            /// <summary>
            /// <para>Indicates whether the Security Center agent is online. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Online")]
            [Validation(Required=false)]
            public bool? Online { get; set; }

            /// <summary>
            /// <para>The operating system of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>linux</para>
            /// </summary>
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            /// <summary>
            /// <para>The name of the operating system for the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Debian  10.3 64</para>
            /// </summary>
            [NameInMap("OsName")]
            [Validation(Required=false)]
            public string OsName { get; set; }

            /// <summary>
            /// <para>The ID of the region in which the server resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The status of the server. Valid values include the following values:</para>
            /// <list type="bullet">
            /// <item><description><b>Running</b></description></item>
            /// <item><description><b>Waiting</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The UUID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6690a46c-0edb-4663-a641-3629d1a9****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7532B7EE-7CE7-5F4D-BF04-B12447DDCAE1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The consumed time of the request. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TimeCost")]
        [Validation(Required=false)]
        public long? TimeCost { get; set; }

    }

}
