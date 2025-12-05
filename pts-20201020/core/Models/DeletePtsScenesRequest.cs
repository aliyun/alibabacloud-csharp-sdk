// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class DeletePtsScenesRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;XVB4DF&quot;,&quot;AFG3CV&quot;]</para>
        /// </summary>
        [NameInMap("SceneIds")]
        [Validation(Required=false)]
        public List<string> SceneIds { get; set; }

    }

}
