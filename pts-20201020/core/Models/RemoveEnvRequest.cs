// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class RemoveEnvRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the environment that you want to delete.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10YPA8H</para>
        /// </summary>
        [NameInMap("EnvId")]
        [Validation(Required=false)]
        public string EnvId { get; set; }

    }

}
