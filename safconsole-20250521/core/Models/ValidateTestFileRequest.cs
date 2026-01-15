// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Safconsole20250521.Models
{
    public class ValidateTestFileRequest : TeaModel {
        /// <summary>
        /// <para>Model ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>456</para>
        /// </summary>
        [NameInMap("CustomerModuleId")]
        [Validation(Required=false)]
        public string CustomerModuleId { get; set; }

        /// <summary>
        /// <para>File path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>saf/xxxxxx/xxxxx.pmml</para>
        /// </summary>
        [NameInMap("FilePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

    }

}
