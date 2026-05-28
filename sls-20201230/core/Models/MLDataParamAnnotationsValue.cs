// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class MLDataParamAnnotationsValue : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud account ID of the annotator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("annotatedBy")]
        [Validation(Required=false)]
        public string AnnotatedBy { get; set; }

        /// <summary>
        /// <para>The update time. The value is a UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1694761550</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

        /// <summary>
        /// <para>The annotation results.</para>
        /// </summary>
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> Results { get; set; }

    }

}
