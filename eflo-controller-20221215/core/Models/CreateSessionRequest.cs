// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class CreateSessionRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e01-cn-kvw44e6dn04</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The type of the session corresponding to the session package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Valid values: Sol (default): based on serial port Assistant: based on cloud assistant</para>
        /// </summary>
        [NameInMap("SessionType")]
        [Validation(Required=false)]
        public string SessionType { get; set; }

        /// <summary>
        /// <para>The start time. The value is a 13-digit timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1669340937156</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
