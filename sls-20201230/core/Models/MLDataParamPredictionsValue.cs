// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class MLDataParamPredictionsValue : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("annotatedBy")]
        [Validation(Required=false)]
        public string AnnotatedBy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1694761550</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

        [NameInMap("results")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> Results { get; set; }

    }

}
