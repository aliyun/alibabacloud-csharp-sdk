// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddCasterProgramResponseBody : TeaModel {
        /// <summary>
        /// <para>The IDs of the episodes. The episode IDs are listed in the same order as specified by the variable N.</para>
        /// </summary>
        [NameInMap("EpisodeIds")]
        [Validation(Required=false)]
        public AddCasterProgramResponseBodyEpisodeIds EpisodeIds { get; set; }
        public class AddCasterProgramResponseBodyEpisodeIds : TeaModel {
            [NameInMap("EpisodeId")]
            [Validation(Required=false)]
            public List<AddCasterProgramResponseBodyEpisodeIdsEpisodeId> EpisodeId { get; set; }
            public class AddCasterProgramResponseBodyEpisodeIdsEpisodeId : TeaModel {
                /// <summary>
                /// <para>The ID of the episode. You can use the ID as a request parameter in the API operation that is used to modify the episode list, query the information about the episode list, delete the episode, or modify the configurations of the episode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F****</para>
                /// </summary>
                [NameInMap("EpisodeId")]
                [Validation(Required=false)]
                public string EpisodeId { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
