// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class CheckSmsVerifyCodeRequest : TeaModel {
        /// <summary>
        /// <para>The verification policy for uppercase and lowercase letters of the verification code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: The verification policy does not distinguish uppercase and lowercase letters.</description></item>
        /// <item><description>2: The verification policy distinguishes uppercase and lowercase letters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CaseAuthPolicy")]
        [Validation(Required=false)]
        public long? CaseAuthPolicy { get; set; }

        /// <summary>
        /// <para>The country code of the phone number. Default value: 86.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86</para>
        /// </summary>
        [NameInMap("CountryCode")]
        [Validation(Required=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// <para>The external ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12123231</para>
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The phone number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18653529399</para>
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The verification service name. If this parameter is not specified, the default service is used. The name can be up to 20 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Aliyun</para>
        /// </summary>
        [NameInMap("SchemeName")]
        [Validation(Required=false)]
        public string SchemeName { get; set; }

        /// <summary>
        /// <para>The verification code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1231</para>
        /// </summary>
        [NameInMap("VerifyCode")]
        [Validation(Required=false)]
        public string VerifyCode { get; set; }

    }

}
