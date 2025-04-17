// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreateDatasetVersionLabelsRequest : TeaModel {
        /// <summary>
        /// <para>The tags.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<Label> Labels { get; set; }

    }

}
