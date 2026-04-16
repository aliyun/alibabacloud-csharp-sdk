// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class CostQueryModelsDTO : TeaModel {
        [NameInMap("columns")]
        [Validation(Required=false)]
        public List<MetricDefRespDTO> Columns { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>model_id</para>
        /// </summary>
        [NameInMap("idField")]
        [Validation(Required=false)]
        public string IdField { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>model_name</para>
        /// </summary>
        [NameInMap("nameField")]
        [Validation(Required=false)]
        public string NameField { get; set; }

        [NameInMap("rows")]
        [Validation(Required=false)]
        public List<ModelRowDTO> Rows { get; set; }

    }

}
