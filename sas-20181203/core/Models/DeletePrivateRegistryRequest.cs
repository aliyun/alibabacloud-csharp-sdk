// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeletePrivateRegistryRequest : TeaModel {
        /// <summary>
        /// <para>The image repository ID.</para>
        /// <remarks>
        /// <para>Call the <a href="~~PageImageRegistry~~">PageImageRegistry</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22233</para>
        /// </summary>
        [NameInMap("RegistryId")]
        [Validation(Required=false)]
        public long? RegistryId { get; set; }

    }

}
