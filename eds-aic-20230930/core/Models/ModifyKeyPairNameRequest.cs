// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ModifyKeyPairNameRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ADB key pair.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kp-6v2q33ae4tw3a****</para>
        /// </summary>
        [NameInMap("KeyPairId")]
        [Validation(Required=false)]
        public string KeyPairId { get; set; }

        /// <summary>
        /// <para>The name of the ADB key pair.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>newKeyPairName</para>
        /// </summary>
        [NameInMap("NewKeyPairName")]
        [Validation(Required=false)]
        public string NewKeyPairName { get; set; }

    }

}
