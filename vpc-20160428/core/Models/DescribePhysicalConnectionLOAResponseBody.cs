// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribePhysicalConnectionLOAResponseBody : TeaModel {
        /// <summary>
        /// <para>The LOA information about the Express Connect circuit.</para>
        /// </summary>
        [NameInMap("PhysicalConnectionLOAType")]
        [Validation(Required=false)]
        public DescribePhysicalConnectionLOAResponseBodyPhysicalConnectionLOAType PhysicalConnectionLOAType { get; set; }
        public class DescribePhysicalConnectionLOAResponseBodyPhysicalConnectionLOAType : TeaModel {
            /// <summary>
            /// <para>The name of the construction company.</para>
            /// 
            /// <b>Example:</b>
            /// <para>company</para>
            /// </summary>
            [NameInMap("CompanyLocalizedName")]
            [Validation(Required=false)]
            public string CompanyLocalizedName { get; set; }

            /// <summary>
            /// <para>The name of the organization that requires the Express Connect circuit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test1234</para>
            /// </summary>
            [NameInMap("CompanyName")]
            [Validation(Required=false)]
            public string CompanyName { get; set; }

            /// <summary>
            /// <para>The time when construction starts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-02-26T08:00:00Z</para>
            /// </summary>
            [NameInMap("ConstructionTime")]
            [Validation(Required=false)]
            public string ConstructionTime { get; set; }

            /// <summary>
            /// <para>The ID of the Express Connect circuit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-bp1ca4wca27****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The circuit code provided by the connectivity provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aaa111</para>
            /// </summary>
            [NameInMap("LineCode")]
            [Validation(Required=false)]
            public string LineCode { get; set; }

            /// <summary>
            /// <para>The label of the cable in the data center.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bbb222</para>
            /// </summary>
            [NameInMap("LineLabel")]
            [Validation(Required=false)]
            public string LineLabel { get; set; }

            /// <summary>
            /// <para>The contact information about line O\&amp;M.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1388888****</para>
            /// </summary>
            [NameInMap("LineSPContactInfo")]
            [Validation(Required=false)]
            public string LineSPContactInfo { get; set; }

            /// <summary>
            /// <para>The ISP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>China Telecom</b></description></item>
            /// <item><description><b>China Unicom</b></description></item>
            /// <item><description><b>China Mobile</b></description></item>
            /// <item><description><b>Other ISPs in China</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Other ISPs in China</para>
            /// </summary>
            [NameInMap("LineServiceProvider")]
            [Validation(Required=false)]
            public string LineServiceProvider { get; set; }

            /// <summary>
            /// <para>The type of the Express Connect circuit. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>MSTP</b></description></item>
            /// <item><description><b>MPLSVPN</b></description></item>
            /// <item><description><b>FIBRE</b></description></item>
            /// <item><description><b>Other</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FIBRE</para>
            /// </summary>
            [NameInMap("LineType")]
            [Validation(Required=false)]
            public string LineType { get; set; }

            /// <summary>
            /// <para>The download URL of the LOA file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http://******</para>
            /// </summary>
            [NameInMap("LoaUrl")]
            [Validation(Required=false)]
            public string LoaUrl { get; set; }

            /// <summary>
            /// <para>The information about the construction workers.</para>
            /// </summary>
            [NameInMap("PMInfo")]
            [Validation(Required=false)]
            public DescribePhysicalConnectionLOAResponseBodyPhysicalConnectionLOATypePMInfo PMInfo { get; set; }
            public class DescribePhysicalConnectionLOAResponseBodyPhysicalConnectionLOATypePMInfo : TeaModel {
                [NameInMap("PMInfo")]
                [Validation(Required=false)]
                public List<DescribePhysicalConnectionLOAResponseBodyPhysicalConnectionLOATypePMInfoPMInfo> PMInfo { get; set; }
                public class DescribePhysicalConnectionLOAResponseBodyPhysicalConnectionLOATypePMInfoPMInfo : TeaModel {
                    /// <summary>
                    /// <para>The identity document number of the construction worker.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12345671****</para>
                    /// </summary>
                    [NameInMap("PMCertificateNo")]
                    [Validation(Required=false)]
                    public string PMCertificateNo { get; set; }

                    /// <summary>
                    /// <para>The identity document type of the construction worker. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>IDCard</b></description></item>
                    /// <item><description><b>Passport</b></description></item>
                    /// <item><description><b>Other</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Other</para>
                    /// </summary>
                    [NameInMap("PMCertificateType")]
                    [Validation(Required=false)]
                    public string PMCertificateType { get; set; }

                    /// <summary>
                    /// <para>The phone number of the construction worker.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>18910010****</para>
                    /// </summary>
                    [NameInMap("PMContactInfo")]
                    [Validation(Required=false)]
                    public string PMContactInfo { get; set; }

                    /// <summary>
                    /// <para>The gender of the construction worker. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>Male</b></description></item>
                    /// <item><description><b>Female</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Male</para>
                    /// </summary>
                    [NameInMap("PMGender")]
                    [Validation(Required=false)]
                    public string PMGender { get; set; }

                    /// <summary>
                    /// <para>The name of the construction worker.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>name</para>
                    /// </summary>
                    [NameInMap("PMName")]
                    [Validation(Required=false)]
                    public string PMName { get; set; }

                }

            }

            /// <summary>
            /// <para>The on-site construction company.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ctcu</para>
            /// </summary>
            [NameInMap("SI")]
            [Validation(Required=false)]
            public string SI { get; set; }

            /// <summary>
            /// <para>The status of the LOA. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Applying</b>: The LOA is pending for approval.</description></item>
            /// <item><description><b>Accept</b>: The LOA is approved.</description></item>
            /// <item><description><b>Available</b>: The LOA is available.</description></item>
            /// <item><description><b>Rejected</b>: The LOA is rejected.</description></item>
            /// <item><description><b>Completing</b>: The Express Connect circuit is under construction.</description></item>
            /// <item><description><b>Complete</b>: The Express Connect circuit is installed.</description></item>
            /// <item><description><b>Deleted</b>: The LOA is deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>318BB676-0A2B-43A0-9AD8-F1D34E93750F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
