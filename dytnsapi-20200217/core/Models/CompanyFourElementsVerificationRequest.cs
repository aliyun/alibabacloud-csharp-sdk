// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class CompanyFourElementsVerificationRequest : TeaModel {
        /// <summary>
        /// <para>The authorization code.</para>
        /// <remarks>
        /// <para> On the <a href="https://dytns.console.aliyun.com/analysis/apply">My Applications</a> page in the <a href="https://dytns.console.aliyun.com/overview?spm=a2c4g.608385.0.0.79847f8b3awqUC">Cell Phone Number Service console</a>, you can obtain the authorization code (also known as authorization ID).</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Dd1r***4id</para>
        /// </summary>
        [NameInMap("AuthCode")]
        [Validation(Required=false)]
        public string AuthCode { get; set; }

        /// <summary>
        /// <para>The enterprise name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("EpCertName")]
        [Validation(Required=false)]
        public string EpCertName { get; set; }

        /// <summary>
        /// <para>The business license number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9242032*******J627</para>
        /// </summary>
        [NameInMap("EpCertNo")]
        [Validation(Required=false)]
        public string EpCertNo { get; set; }

        /// <summary>
        /// <para>The name of the legal representative.</para>
        /// <remarks>
        /// <para> If an enterprise has multiple legal representatives, separate them with commas (,).</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("LegalPersonCertName")]
        [Validation(Required=false)]
        public string LegalPersonCertName { get; set; }

        /// <summary>
        /// <para>The ID card number of the legal representative.</para>
        /// <remarks>
        /// <para> If an enterprise has multiple legal representatives, separate the ID card numbers with commas (,).</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>331021********0011</para>
        /// </summary>
        [NameInMap("LegalPersonCertNo")]
        [Validation(Required=false)]
        public string LegalPersonCertNo { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
