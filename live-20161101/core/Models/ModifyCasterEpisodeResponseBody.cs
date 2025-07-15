// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ModifyCasterEpisodeResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the production studio. You can use the ID as a request parameter in the API operation that is used to copy the configurations of a scene, update the configurations of a scene, query the scenes of a production studio, query the audio configurations of a scene, start a scene in the production studio, or stop a scene in the production studio.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LIVEPRODUCER_POST-cn-0pp1czt****</para>
        /// </summary>
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        /// <summary>
        /// <para>The ID of the episode. You can use the ID as a request parameter in the API operation that is used to delete an episode list from a production studio, add episodes to an episode list, remove episodes from an episode list, query the information about episodes in an episode list, update episodes in an episode list, delete an episode list, query the information about an episode list, start an episode list, or stop an episode list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a2b8e671-2fe5-4642-a2ec-bf938623****</para>
        /// </summary>
        [NameInMap("EpisodeId")]
        [Validation(Required=false)]
        public string EpisodeId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
