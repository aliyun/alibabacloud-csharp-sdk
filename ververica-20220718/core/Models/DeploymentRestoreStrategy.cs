// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class DeploymentRestoreStrategy : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>TRUE</para>
        /// </summary>
        [NameInMap("allowNonRestoredState")]
        [Validation(Required=false)]
        public bool? AllowNonRestoredState { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1660293803155</para>
        /// </summary>
        [NameInMap("jobStartTimeInMs")]
        [Validation(Required=false)]
        public long? JobStartTimeInMs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>LATEST_STATE</para>
        /// </summary>
        [NameInMap("kind")]
        [Validation(Required=false)]
        public string Kind { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>354dde66-a3ae-463e-967a-0b4107fd****</para>
        /// </summary>
        [NameInMap("savepointId")]
        [Validation(Required=false)]
        public string SavepointId { get; set; }

    }

}
