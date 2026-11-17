// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ApplyPhysicalConnectionLOARequest : TeaModel {
        /// <summary>
        /// <para>The bandwidth of the Express Connect circuit. Unit: Mbit/s.</para>
        /// <para>Valid values: <b>2</b> to <b>10240</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can generate the value from your client to ensure that the value is unique among different requests. The ClientToken parameter supports only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The name of the customer company that connects to the Express Connect circuit.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>company</para>
        /// </summary>
        [NameInMap("CompanyName")]
        [Validation(Required=false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// <para>The time when the construction unit enters the site. Specify the time in the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-02-28T16:00:00Z</para>
        /// </summary>
        [NameInMap("ConstructionTime")]
        [Validation(Required=false)]
        public string ConstructionTime { get; set; }

        /// <summary>
        /// <para>The instance ID of the Express Connect circuit.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-bp1qrb3044eqi****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The type of the Express Connect circuit. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MSTP</b>: MSTP circuit.</description></item>
        /// <item><description><b>MPLSVPN</b>: MPLS VPN circuit.</description></item>
        /// <item><description><b>FIBRE</b>: Direct optical fiber connection.</description></item>
        /// <item><description><b>Other</b>: Other types of circuits.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FIBRE</para>
        /// </summary>
        [NameInMap("LineType")]
        [Validation(Required=false)]
        public string LineType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The information about the construction engineers.</para>
        /// <remarks>
        /// <para>This parameter is required. Specify the relevant information.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("PMInfo")]
        [Validation(Required=false)]
        public List<ApplyPhysicalConnectionLOARequestPMInfo> PMInfo { get; set; }
        public class ApplyPhysicalConnectionLOARequestPMInfo : TeaModel {
            /// <summary>
            /// <para>The ID number of the construction engineer. You can enter an ID card number or an international passport number.</para>
            /// <para>You can configure the information of up to 16 construction engineers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5****************9</para>
            /// </summary>
            [NameInMap("PMCertificateNo")]
            [Validation(Required=false)]
            public string PMCertificateNo { get; set; }

            /// <summary>
            /// <para>The type of the ID document of the construction engineer. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>IDCard</b>: ID card.</description></item>
            /// <item><description><b>Passport</b>: International passport.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IDCard</para>
            /// </summary>
            [NameInMap("PMCertificateType")]
            [Validation(Required=false)]
            public string PMCertificateType { get; set; }

            /// <summary>
            /// <para>The contact information of the construction engineer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1390000****</para>
            /// </summary>
            [NameInMap("PMContactInfo")]
            [Validation(Required=false)]
            public string PMContactInfo { get; set; }

            /// <summary>
            /// <para>The gender of the construction engineer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Male</para>
            /// </summary>
            [NameInMap("PMGender")]
            [Validation(Required=false)]
            public string PMGender { get; set; }

            /// <summary>
            /// <para>The name of the construction engineer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Zhang San</para>
            /// </summary>
            [NameInMap("PMName")]
            [Validation(Required=false)]
            public string PMName { get; set; }

        }

        /// <summary>
        /// <para>The geographical location where the Express Connect circuit is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hangzhou</para>
        /// </summary>
        [NameInMap("PeerLocation")]
        [Validation(Required=false)]
        public string PeerLocation { get; set; }

        /// <summary>
        /// <para>The region ID of the Express Connect circuit.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The construction unit of the Express Connect circuit.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba</para>
        /// </summary>
        [NameInMap("Si")]
        [Validation(Required=false)]
        public string Si { get; set; }

    }

}
