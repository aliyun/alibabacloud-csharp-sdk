// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddCasterProgramResponseBody : TeaModel {
        [NameInMap("EpisodeIds")]
        [Validation(Required=false)]
        public AddCasterProgramResponseBodyEpisodeIds EpisodeIds { get; set; }
        public class AddCasterProgramResponseBodyEpisodeIds : TeaModel {
            [NameInMap("EpisodeId")]
            [Validation(Required=false)]
            public List<AddCasterProgramResponseBodyEpisodeIdsEpisodeId> EpisodeId { get; set; }
            public class AddCasterProgramResponseBodyEpisodeIdsEpisodeId : TeaModel {
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
