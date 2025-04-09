// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class GetAfterAnswerDelayPlaybackRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c46001bc-3ead-4bfd-9a69-4b5b66a4a3f4</para>
        /// </summary>
        [NameInMap("EntryId")]
        [Validation(Required=false)]
        public string EntryId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("StrategyLevel")]
        [Validation(Required=false)]
        public int? StrategyLevel { get; set; }

    }

}
