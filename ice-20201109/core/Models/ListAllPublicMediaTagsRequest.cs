// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListAllPublicMediaTagsRequest : TeaModel {
        /// <summary>
        /// <para>The business type of the media asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;sticker&quot;</para>
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        /// <summary>
        /// <para>The entity ID, which is used to distinguish between media assets of different types in the public domain.</para>
        /// <para>Set this parameter to Copyright_Music, which indicates music in the public domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Copyright_Music</para>
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public string EntityId { get; set; }

    }

}
