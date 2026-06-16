// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiSearchEngine20260417.Models
{
    public class GetDatasetResourceUrlRequest : TeaModel {
        /// <summary>
        /// <para>The dataset ID. You can view this in the dataset list on the console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>730</para>
        /// </summary>
        [NameInMap("datasetId")]
        [Validation(Required=false)]
        public string DatasetId { get; set; }

        /// <summary>
        /// <para>The primary key value of the data record in the dataset.</para>
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
