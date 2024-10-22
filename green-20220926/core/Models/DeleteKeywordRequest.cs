// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class DeleteKeywordRequest : TeaModel {
        [NameInMap("KeywordIdList")]
        [Validation(Required=false)]
        public string KeywordIdList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[16754493]</para>
        /// </summary>
        [NameInMap("KeywordIds")]
        [Validation(Required=false)]
        public string KeywordIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>customxx_xxxx</para>
        /// </summary>
        [NameInMap("LibId")]
        [Validation(Required=false)]
        public string LibId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
