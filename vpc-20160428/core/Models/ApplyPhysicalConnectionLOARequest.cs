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
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The name of the customer company that requires the Express Connect circuit.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>company</para>
        /// </summary>
        [NameInMap("CompanyName")]
        [Validation(Required=false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// <para>The time when construction started. Specify the time in the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-02-28T16:00:00Z</para>
        /// </summary>
        [NameInMap("ConstructionTime")]
        [Validation(Required=false)]
        public string ConstructionTime { get; set; }

        /// <summary>
        /// <para>The ID of the Express Connect circuit.</para>
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
        /// <item><description><b>MSTP</b>: MSTP line</description></item>
        /// <item><description><b>MPLSVPN</b>: MPLSVPN line</description></item>
        /// <item><description><b>FIBRE</b>: fiber line</description></item>
        /// <item><description><b>Other</b>: other types</description></item>
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
        /// <para>The information about the construction engineer.</para>
        /// </summary>
        [NameInMap("PMInfo")]
        [Validation(Required=false)]
        public List<ApplyPhysicalConnectionLOARequestPMInfo> PMInfo { get; set; }
        public class ApplyPhysicalConnectionLOARequestPMInfo : TeaModel {
            /// <summary>
            /// <para>The ID number of the construction engineer. You can specify the ID number of an ID card or an international passport.</para>
            /// <para>You can configure information for up to 16 construction engineers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5****************9</para>
            /// </summary>
            [NameInMap("PMCertificateNo")]
            [Validation(Required=false)]
            public string PMCertificateNo { get; set; }

            /// <summary>
            /// <para>The type of the identity document of the construction engineer. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>IDCard</b></description></item>
            /// <item><description><b>Passport</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IDCard</para>
            /// </summary>
            [NameInMap("PMCertificateType")]
            [Validation(Required=false)]
            public string PMCertificateType { get; set; }

            /// <summary>
            /// <para>The contact information about the construction engineer.</para>
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
            /// <para>Zhangsan</para>
            /// </summary>
            [NameInMap("PMName")]
            [Validation(Required=false)]
            public string PMName { get; set; }

        }

        /// <summary>
        /// <para>The geographic location where the Express Connect circuit is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("PeerLocation")]
        [Validation(Required=false)]
        public string PeerLocation { get; set; }

        /// <summary>
        /// <para>The region ID of the Express Connect circuit.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
        /// <para>The construction company.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>company</para>
        /// </summary>
        [NameInMap("Si")]
        [Validation(Required=false)]
        public string Si { get; set; }

    }

}
