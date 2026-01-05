// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateDatasetRequest : TeaModel {
        /// <summary>
        /// <para>The dataset description. Length not exceeding 1024.</para>
        /// 
        /// <b>Example:</b>
        /// <para>new comment</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The dataset ID. Only DataWorks datasets are supported for update.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dataworks-dataset:3pXXXb8o0ngr07njhps1</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The dataset name. A non-empty string, length not exceeding 128.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_oss_dataset_new</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The user guide, supports Markdown formatted rich text.</para>
        /// 
        /// <b>Example:</b>
        /// <h2>introduction</h2>
        /// </summary>
        [NameInMap("Readme")]
        [Validation(Required=false)]
        public string Readme { get; set; }

    }

}
