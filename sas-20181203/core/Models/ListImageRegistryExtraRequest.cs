// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListImageRegistryExtraRequest : TeaModel {
        /// <summary>
        /// <para>Image registry ID.</para>
        /// <remarks>
        /// <para>You can obtain this parameter by calling the <a href="~~PageImageRegistry~~">PageImageRegistry</a> interface.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25363</para>
        /// </summary>
        [NameInMap("RegistryId")]
        [Validation(Required=false)]
        public long? RegistryId { get; set; }

    }

}
