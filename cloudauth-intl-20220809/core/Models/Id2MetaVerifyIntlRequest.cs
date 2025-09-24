// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class Id2MetaVerifyIntlRequest : TeaModel {
        /// <summary>
        /// <para>The ID card number.</para>
        /// <remarks>
        /// <para>Only ID cards of residents in the Chinese mainland are supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>429001********8211</para>
        /// </summary>
        [NameInMap("IdentifyNum")]
        [Validation(Required=false)]
        public string IdentifyNum { get; set; }

        /// <summary>
        /// <para>The parameter type.</para>
        /// <para><b>normal</b>: The original value in plaintext.</para>
        /// <remarks>
        /// <para>Due to limitations of the authoritative data source, two-factor ID verification does not support MD5 encryption.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("ParamType")]
        [Validation(Required=false)]
        public string ParamType { get; set; }

        /// <summary>
        /// <para>The product plan. This is a static field. Set the value to <b>ID_2META</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ID_2META</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Zhang*</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
