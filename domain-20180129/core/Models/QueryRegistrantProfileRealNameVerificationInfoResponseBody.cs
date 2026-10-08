// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryRegistrantProfileRealNameVerificationInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The Base64-encoded image of the identity verification documents.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dGVzdA==</para>
        /// </summary>
        [NameInMap("IdentityCredential")]
        [Validation(Required=false)]
        public string IdentityCredential { get; set; }

        /// <summary>
        /// <para>The certificate number used for identity verification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4111111111111110**</para>
        /// </summary>
        [NameInMap("IdentityCredentialNo")]
        [Validation(Required=false)]
        public string IdentityCredentialNo { get; set; }

        /// <summary>
        /// <para>The type of certificate used for identity verification. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>SFZ</b>: Identity card.  </description></item>
        /// <item><description><b>HZ</b>: Passport.  </description></item>
        /// <item><description><b>YYZZ</b>: Business license.  </description></item>
        /// <item><description><b>ORG</b>: Organization code certificate.  </description></item>
        /// <item><description><b>XYDM</b>: Unified Social Credit Code certificate.  </description></item>
        /// <item><description><b>TXZ</b>: Mainland Travel Permits for Hong Kong and Macao Residents.</description></item>
        /// </list>
        /// <remarks>
        /// <para>For more certificate types, see <a href="https://help.aliyun.com/document_detail/72209.html">Certificate Types Supported for Identity Verification</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SFZ</para>
        /// </summary>
        [NameInMap("IdentityCredentialType")]
        [Validation(Required=false)]
        public string IdentityCredentialType { get; set; }

        /// <summary>
        /// <para>The download URL of the identity verification image.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://test.oss-cn-hangzhou.aliyuncs.com/20170522/1219541161213057_070445190.jpg">http://test.oss-cn-hangzhou.aliyuncs.com/20170522/1219541161213057_070445190.jpg</a></para>
        /// </summary>
        [NameInMap("IdentityCredentialUrl")]
        [Validation(Required=false)]
        public string IdentityCredentialUrl { get; set; }

        /// <summary>
        /// <para>The update time of the identity verification documents.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-05-22 19:04:49</para>
        /// </summary>
        [NameInMap("ModificationDate")]
        [Validation(Required=false)]
        public string ModificationDate { get; set; }

        /// <summary>
        /// <para>The ID of the queried information template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567</para>
        /// </summary>
        [NameInMap("RegistrantProfileId")]
        [Validation(Required=false)]
        public long? RegistrantProfileId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4D73432C-7600-4779-ACBB-C3B5CA145D32</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The submission time of the identity verification documents.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-05-22 19:04:49</para>
        /// </summary>
        [NameInMap("SubmissionDate")]
        [Validation(Required=false)]
        public string SubmissionDate { get; set; }

    }

}
