// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class Lock : TeaModel {
        /// <summary>
        /// <para>The ID of the lock holder.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18389966****</para>
        /// </summary>
        [NameInMap("holderId")]
        [Validation(Required=false)]
        public string HolderId { get; set; }

        /// <summary>
        /// <para>The username of the lock holder.</para>
        /// 
        /// <b>Example:</b>
        /// <para>userA</para>
        /// </summary>
        [NameInMap("holderName")]
        [Validation(Required=false)]
        public string HolderName { get; set; }

        /// <summary>
        /// <para>The lock ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>stt-fu1658tbk6mnkk2****</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The name of the namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default-namespace</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a14bd5d90a****</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
