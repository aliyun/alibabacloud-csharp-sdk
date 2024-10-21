// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SaveBatchTaskForReserveDropListDomainResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>B7AB5469-5E38-4AA9-A920-C65B7A9C8E6E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3cb1adc3-20e8-44ae-9e76-e812fa6fc9d8</para>
        /// </summary>
        [NameInMap("TaskNo")]
        [Validation(Required=false)]
        public string TaskNo { get; set; }

    }

}
