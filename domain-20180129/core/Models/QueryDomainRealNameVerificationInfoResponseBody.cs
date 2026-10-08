// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryDomainRealNameVerificationInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>Domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyundoc.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>Base64-encoded image of the real-name verification certificate. Requirements for the image:  </para>
        /// <list type="bullet">
        /// <item><description>Format must be <b>jpg</b> or <b>bmp</b>.  </description></item>
        /// <item><description>Original image size must be between <b>55 KB and 1 MB</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dGVzdA==</para>
        /// </summary>
        [NameInMap("IdentityCredential")]
        [Validation(Required=false)]
        public string IdentityCredential { get; set; }

        /// <summary>
        /// <para>Certificate number used for real-name verification, such as an identity card number or Unified Social Credit Code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5****************9</para>
        /// </summary>
        [NameInMap("IdentityCredentialNo")]
        [Validation(Required=false)]
        public string IdentityCredentialNo { get; set; }

        /// <summary>
        /// <para>The type of certificate used for real-name verification. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>SFZ</b>: Identity card.  </description></item>
        /// <item><description><b>HZ</b>: Passport.  </description></item>
        /// <item><description><b>YYZZ</b>: Business license.  </description></item>
        /// <item><description><b>ORG</b>: Organization code certificate.  </description></item>
        /// <item><description><b>XYDM</b>: Unified Social Credit Code certificate.  </description></item>
        /// <item><description><b>TXZ</b>: Mainland Travel Permits for Hong Kong and Macao Residents.</description></item>
        /// </list>
        /// <para>If your certificate type is not listed above, see the section <a href="https://help.aliyun.com/document_detail/72209.html">Supported Certificate Types for Real-Name Verification</a> for the corresponding value.  </para>
        /// <remarks>
        /// <para>You must select the certificate type that matches the certificate you provide.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SFZ</para>
        /// </summary>
        [NameInMap("IdentityCredentialType")]
        [Validation(Required=false)]
        public string IdentityCredentialType { get; set; }

        /// <summary>
        /// <para>Download URL of the real-name verification image.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://dbu-nap-p.oss-cn-hangzhou.aliyuncs.com/20190219/140692647406xxxx_5d6baea3e7314fd986afdd86e33exxxx.jpg">http://dbu-nap-p.oss-cn-hangzhou.aliyuncs.com/20190219/140692647406xxxx_5d6baea3e7314fd986afdd86e33exxxx.jpg</a></para>
        /// </summary>
        [NameInMap("IdentityCredentialUrl")]
        [Validation(Required=false)]
        public string IdentityCredentialUrl { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>S2019270W570****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Unique request access token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4DF9D693-0D5B-4EB7-8922-7ECA6BD59314</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Updated At.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-03-28 00:41:42</para>
        /// </summary>
        [NameInMap("SubmissionDate")]
        [Validation(Required=false)]
        public string SubmissionDate { get; set; }

    }

}
