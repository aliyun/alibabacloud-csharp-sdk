// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DeleteLiveAIStudioRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the template. You can obtain the ID from the response to the CreateLiveAIStudio operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>369ced1f-c33a-49e5-91da-bdaae3d6c1c2</para>
        /// </summary>
        [NameInMap("StudioId")]
        [Validation(Required=false)]
        public string StudioId { get; set; }

    }

}
