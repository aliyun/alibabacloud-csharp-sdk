// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class AddressCompareIntlRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DefaultCountry")]
        [Validation(Required=false)]
        public string DefaultCountry { get; set; }

        /// <summary>
        /// <para>ADD_VERIFY</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Text1")]
        [Validation(Required=false)]
        public string Text1 { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Text2")]
        [Validation(Required=false)]
        public string Text2 { get; set; }

    }

}
