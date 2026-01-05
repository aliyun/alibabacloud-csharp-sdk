// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIElasticDatasetAccelerator20220801.Models
{
    public class SlotStatusDetail : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1000000</para>
        /// </summary>
        [NameInMap("LoadedFileNum")]
        [Validation(Required=false)]
        public long? LoadedFileNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200G</para>
        /// </summary>
        [NameInMap("LoadedFileSize")]
        [Validation(Required=false)]
        public string LoadedFileSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1800000</para>
        /// </summary>
        [NameInMap("LoadingTimeCost")]
        [Validation(Required=false)]
        public long? LoadingTimeCost { get; set; }

    }

}
