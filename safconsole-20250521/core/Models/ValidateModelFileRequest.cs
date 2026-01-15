// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Safconsole20250521.Models
{
    public class ValidateModelFileRequest : TeaModel {
        /// <summary>
        /// <para>File path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>saf/xxxxxxx/xxx.pmml</para>
        /// </summary>
        [NameInMap("FilePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

    }

}
