// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class UpdateVolumeRequest : TeaModel {
        /// <summary>
        /// <para>The request parameters for updating the storage volume.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateVolumeInput Body { get; set; }

        /// <summary>
        /// <para>The ID of the team to which the storage volume belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9f5a1fe9-****</para>
        /// </summary>
        [NameInMap("teamID")]
        [Validation(Required=false)]
        public string TeamID { get; set; }

    }

}
