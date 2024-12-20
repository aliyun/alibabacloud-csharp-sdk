// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class AiccsSmartCallOperateRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>116012854210^102814279****</para>
        /// </summary>
        [NameInMap("CallId")]
        [Validation(Required=false)]
        public string CallId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>parallelBridge</para>
        /// </summary>
        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Param</para>
        /// </summary>
        [NameInMap("Param")]
        [Validation(Required=false)]
        public string Param { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>aiccs</para>
        /// </summary>
        [NameInMap("ProdCode")]
        [Validation(Required=false)]
        public string ProdCode { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
