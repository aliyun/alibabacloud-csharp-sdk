// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class DatasetProxyConfig : TeaModel {
        /// <summary>
        /// <para>Dataset type. Only LABEL is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LABEL</para>
        /// </summary>
        [NameInMap("DatasetType")]
        [Validation(Required=false)]
        public string DatasetType { get; set; }

        /// <summary>
        /// <para>Dataset source. Only PAI is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PAI</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>Source dataset ID. For information about how to obtain a dataset ID, see <a href="https://help.aliyun.com/document_detail/457222.html">ListDatasets</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>214***12514</para>
        /// </summary>
        [NameInMap("SourceDatasetId")]
        [Validation(Required=false)]
        public string SourceDatasetId { get; set; }

    }

}
