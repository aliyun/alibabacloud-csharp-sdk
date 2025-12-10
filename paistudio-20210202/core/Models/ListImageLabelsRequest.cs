// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20210202.Models
{
    public class ListImageLabelsRequest : TeaModel {
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>a=b,c=d</para>
        /// </summary>
        [NameInMap("LabelFilter")]
        [Validation(Required=false)]
        public string LabelFilter { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ImageType,Framework,Platform</para>
        /// </summary>
        [NameInMap("LabelKeys")]
        [Validation(Required=false)]
        public string LabelKeys { get; set; }

    }

}
