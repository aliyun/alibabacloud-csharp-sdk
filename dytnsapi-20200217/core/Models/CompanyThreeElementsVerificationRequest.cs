// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class CompanyThreeElementsVerificationRequest : TeaModel {
        /// <summary>
        /// <para>The authorization code.</para>
        /// <remarks>
        /// <para>Log on to the <a href="https://dytns.console.aliyun.com/overview?spm=a2c4g.608385.0.0.79847f8b3awqUC">Cell Phone Number Service console</a> and go to the <a href="https://dytns.console.aliyun.com/analysis/apply">My Applications</a> page to obtain the authorization ID, which is the authorization code.</para>
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
        /// <para>The company name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>某企业</para>
        /// </summary>
        [NameInMap("EpCertName")]
        [Validation(Required=false)]
        public string EpCertName { get; set; }

        /// <summary>
        /// <para>The company certificate number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9242032*******J627</para>
        /// </summary>
        [NameInMap("EpCertNo")]
        [Validation(Required=false)]
        public string EpCertNo { get; set; }

        /// <summary>
        /// <para>The name of the company\&quot;s legal representative.</para>
        /// <remarks>
        /// <para>If the company has multiple legal representatives, separate the names with the Chinese enumeration comma (&quot;、&quot;).</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("LegalPersonCertName")]
        [Validation(Required=false)]
        public string LegalPersonCertName { get; set; }

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
