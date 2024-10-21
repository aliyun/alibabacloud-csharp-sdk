// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryRegistrantProfileRealNameVerificationInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>dGVzdA==</para>
        /// </summary>
        [NameInMap("IdentityCredential")]
        [Validation(Required=false)]
        public string IdentityCredential { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4111111111111110**</para>
        /// </summary>
        [NameInMap("IdentityCredentialNo")]
        [Validation(Required=false)]
        public string IdentityCredentialNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SFZ</para>
        /// </summary>
        [NameInMap("IdentityCredentialType")]
        [Validation(Required=false)]
        public string IdentityCredentialType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://test.oss-cn-hangzhou.aliyuncs.com/20170522/1219541161213057_070445190.jpg">http://test.oss-cn-hangzhou.aliyuncs.com/20170522/1219541161213057_070445190.jpg</a></para>
        /// </summary>
        [NameInMap("IdentityCredentialUrl")]
        [Validation(Required=false)]
        public string IdentityCredentialUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2017-05-22 19:04:49</para>
        /// </summary>
        [NameInMap("ModificationDate")]
        [Validation(Required=false)]
        public string ModificationDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234567</para>
        /// </summary>
        [NameInMap("RegistrantProfileId")]
        [Validation(Required=false)]
        public long? RegistrantProfileId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4D73432C-7600-4779-ACBB-C3B5CA145D32</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2017-05-22 19:04:49</para>
        /// </summary>
        [NameInMap("SubmissionDate")]
        [Validation(Required=false)]
        public string SubmissionDate { get; set; }

    }

}
