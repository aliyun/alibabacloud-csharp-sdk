// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CreateClientKeyRequest : TeaModel {
        /// <summary>
        /// <para>The operation that you want to perform. Set the value to <b>CreateClientKey</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aap_test</para>
        /// </summary>
        [NameInMap("AapName")]
        [Validation(Required=false)]
        public string AapName { get; set; }

        /// <summary>
        /// <para>The encryption password of the client key.</para>
        /// <para>The password must be 8 to 64 characters in length and must contain at least two of the following types: digits, letters, and special characters. Special characters include <c>~ ! @ # $ % ^ &amp; * ? _ -</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2028-08-31T17:14:33Z</para>
        /// </summary>
        [NameInMap("NotAfter")]
        [Validation(Required=false)]
        public string NotAfter { get; set; }

        /// <summary>
        /// <para>The end of the validity period of the client key.</para>
        /// <para>Specify the time in the ISO 8601 standard. The time must be in UTC. The time must be in the yyyy-MM-ddTHH:mm:ssZ format.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If you do not configure NotAfter, the default value is the time when the client key was created plus five years.</description></item>
        /// <item><description>If you configure NotAfter, you must configure NotBefore.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2023-08-31T17:14:33Z</para>
        /// </summary>
        [NameInMap("NotBefore")]
        [Validation(Required=false)]
        public string NotBefore { get; set; }

        /// <summary>
        /// <para>The name of the AAP.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bcfefe15-46f0****</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

    }

}
