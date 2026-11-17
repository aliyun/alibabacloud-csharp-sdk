// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class Id2MetaVerifyIntlRequest : TeaModel {
        /// <summary>
        /// <para>The ID card number in plaintext.</para>
        /// 
        /// <b>Example:</b>
        /// <para>429001********8211</para>
        /// </summary>
        [NameInMap("IdentifyNum")]
        [Validation(Required=false)]
        public string IdentifyNum { get; set; }

        /// <summary>
        /// <para>The parameter type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>normal: The original value in plaintext.</description></item>
        /// <item><description>Note: Due to the limitations of the authoritative data source, two-element identity verification does not support the MD5 encryption method.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("ParamType")]
        [Validation(Required=false)]
        public string ParamType { get; set; }

        /// <summary>
        /// <para>The product solution. Fixed value: ID_2META.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ID_2META</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The name in plaintext.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Zhang*</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
