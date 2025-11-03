// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListImageRegistryExtraRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the image repository.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~PageImageRegistry~~">PageImageRegistry</a> operation to obtain the ID.</para>
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
