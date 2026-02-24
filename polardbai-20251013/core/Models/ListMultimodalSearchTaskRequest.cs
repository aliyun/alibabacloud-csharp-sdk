// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PolardbAI20251013.Models
{
    public class ListMultimodalSearchTaskRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-2ze454l20me07****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("DatasetIds")]
        [Validation(Required=false)]
        public List<string> DatasetIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>红绿灯</para>
        /// </summary>
        [NameInMap("InputField")]
        [Validation(Required=false)]
        public string InputField { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>flash，plus</para>
        /// </summary>
        [NameInMap("ModelMode")]
        [Validation(Required=false)]
        public string ModelMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("SourceRegionId")]
        [Validation(Required=false)]
        public string SourceRegionId { get; set; }

    }

}
