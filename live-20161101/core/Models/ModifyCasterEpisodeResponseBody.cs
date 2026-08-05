// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ModifyCasterEpisodeResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the production studio. You can use this ID to perform operations on the scenario. These operations include copying, updating, querying, starting, and stopping the scenario. You can also use the ID to query the audio configuration of the scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LIVEPRODUCER_POST-cn-0pp1czt****</para>
        /// </summary>
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        /// <summary>
        /// <para>The ID of the episode. You can use this ID to manage the episode list and its items. For the episode list, you can perform operations such as query, edit, delete, start, and stop. For episode items, you can perform operations such as create, add, delete, and query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a2b8e671-2fe5-4642-a2ec-bf938623****</para>
        /// </summary>
        [NameInMap("EpisodeId")]
        [Validation(Required=false)]
        public string EpisodeId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
