// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class MultimodalSearchOutput : TeaModel {
        /// <summary>
        /// <para>Image List</para>
        /// </summary>
        [NameInMap("imageItems")]
        [Validation(Required=false)]
        public List<UnifiedImageItem> ImageItems { get; set; }

        /// <summary>
        /// <para>Query context information</para>
        /// </summary>
        [NameInMap("queryContext")]
        [Validation(Required=false)]
        public MultimodalQueryContext QueryContext { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>sdfsd234-2vxcg345-345vc</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Search basic information</para>
        /// </summary>
        [NameInMap("searchInformation")]
        [Validation(Required=false)]
        public SearchInformation SearchInformation { get; set; }

    }

}
