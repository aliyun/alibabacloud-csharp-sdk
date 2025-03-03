// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class CreateSessionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>e01-cn-kvw44e6dn04</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        [NameInMap("SessionType")]
        [Validation(Required=false)]
        public string SessionType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1669340937156</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
