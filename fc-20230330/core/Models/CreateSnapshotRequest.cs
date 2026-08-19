// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class CreateSnapshotRequest : TeaModel {
        /// <summary>
        /// <para>The request body for creating a snapshot.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public CreateSnapshotInput Body { get; set; }

        /// <summary>
        /// <para>The function alias.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alias</para>
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

    }

}
