// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class Permission : TeaModel {
        /// <summary>
        /// <para>IsEnabled</para>
        /// </summary>
        [NameInMap("IsEnabled")]
        [Validation(Required=false)]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// <para>ResourceType</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ecs</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
