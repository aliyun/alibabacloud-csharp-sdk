// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SetContentAnalyzeConfigRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Auto")]
        [Validation(Required=false)]
        public bool? Auto { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TEXT,FACE</para>
        /// </summary>
        [NameInMap("SaveType")]
        [Validation(Required=false)]
        public string SaveType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>S00000101-100070</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
