// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class RebootRenderingServerRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to perform only an admission check without actually restarting the hosts. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Precheck")]
        [Validation(Required=false)]
        public bool? Precheck { get; set; }

        /// <summary>
        /// <para>The list of cloud application service instance IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RenderingInstanceIds")]
        [Validation(Required=false)]
        public List<string> RenderingInstanceIds { get; set; }

    }

}
