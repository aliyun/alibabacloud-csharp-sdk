// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class StartRestoreTaskRequest : TeaModel {
        /// <summary>
        /// <para>A client token. It ensures the idempotence of the request and prevents the same request from being submitted multiple times.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCzxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the restore job.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s102h7rfXXXX</para>
        /// </summary>
        [NameInMap("RestoreTaskId")]
        [Validation(Required=false)]
        public string RestoreTaskId { get; set; }

    }

}
