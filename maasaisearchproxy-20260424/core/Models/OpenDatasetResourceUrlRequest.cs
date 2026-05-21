// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaasAISearchProxy20260424.Models
{
    public class OpenDatasetResourceUrlRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>730</para>
        /// </summary>
        [NameInMap("datasetId")]
        [Validation(Required=false)]
        public long? DatasetId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01KQCJBPM9JVDTXWV50G2AKXXX</para>
        /// </summary>
        [NameInMap("primaryKey")]
        [Validation(Required=false)]
        public string PrimaryKey { get; set; }

    }

}
