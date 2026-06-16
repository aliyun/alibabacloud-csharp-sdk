// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiSearchEngine20260417.Models
{
    public class ImportDatasetDataRequest : TeaModel {
        /// <summary>
        /// <para>The dataset ID. You can view this ID in the dataset list in the console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>730</para>
        /// </summary>
        [NameInMap("datasetId")]
        [Validation(Required=false)]
        public string DatasetId { get; set; }

        /// <summary>
        /// <para>The list of data records to add or update. A maximum of 100 records can be included in a single batch operation.</para>
        /// <para>Note: The records must strictly follow the schema configured for the target dataset in the console. The add or update logic depends on the primary key type of the target dataset. For detailed example requests, see the Request Description section below.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("records")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Records { get; set; }

    }

}
