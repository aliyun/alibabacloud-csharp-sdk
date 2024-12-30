// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class UpdateFacegroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The drive ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        /// <summary>
        /// <para>The group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>group-abc</para>
        /// </summary>
        [NameInMap("group_id")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

    }

}
