// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListAIAgentVoiceprintsRequest : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Value values: [1,100].</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>A unique identifier for the voiceprint. This parameter is optional. If provided, only the information for that ID is returned. If not specified, all voiceprints under the account are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vp_1699123456_8527</para>
        /// </summary>
        [NameInMap("VoiceprintId")]
        [Validation(Required=false)]
        public string VoiceprintId { get; set; }

    }

}
