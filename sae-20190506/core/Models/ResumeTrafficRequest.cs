// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ResumeTrafficRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>017f39b8-dfa4-4e16-a84b-1dcee4b1****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>c-668727a8-17d86664-41e5bb******,c-668727a8-17d86664-7e4958******</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

    }

}
