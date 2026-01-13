// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class UpdateRecallManagementTableRequest : TeaModel {
        [NameInMap("EnableDataSizeFluctuationThreshold")]
        [Validation(Required=false)]
        public bool? EnableDataSizeFluctuationThreshold { get; set; }

        [NameInMap("EnableRowCountFluctuationThreshold")]
        [Validation(Required=false)]
        public bool? EnableRowCountFluctuationThreshold { get; set; }

        [NameInMap("IndexVersionId")]
        [Validation(Required=false)]
        public string IndexVersionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("MaxDataSizeFluctuationThreshold")]
        [Validation(Required=false)]
        public int? MaxDataSizeFluctuationThreshold { get; set; }

        [NameInMap("MaxRowCountFluctuationThreshold")]
        [Validation(Required=false)]
        public int? MaxRowCountFluctuationThreshold { get; set; }

        [NameInMap("MinDataSizeFluctuationThreshold")]
        [Validation(Required=false)]
        public int? MinDataSizeFluctuationThreshold { get; set; }

        [NameInMap("MinRowCountFluctuationThreshold")]
        [Validation(Required=false)]
        public int? MinRowCountFluctuationThreshold { get; set; }

    }

}
