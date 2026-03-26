// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class DatasetFileMetaResponse : TeaModel {
        /// <summary>
        /// <para>The metadata ID of the dataset file.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>07914c9534586e4e7aa6e9dbca5009082df*******8a0d857b33296c59bf6</para>
        /// </summary>
        [NameInMap("DatasetFileMetaId")]
        [Validation(Required=false)]
        public string DatasetFileMetaId { get; set; }

        /// <summary>
        /// <para>The description of the reason why the metadata operation failed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Not Found</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public string Result { get; set; }

        /// <summary>
        /// <para>The file URI.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://l*****-test/dataset/1653421.jpg</para>
        /// </summary>
        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

    }

}
