// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ReleaseKmsInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to forcibly release the KMS instance if it has not been backed up.</para>
        /// <list type="bullet">
        /// <item><description><para>true: forcibly releases the instance.</para>
        /// </description></item>
        /// <item><description><para>false (default): does not release the instance.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ForceDeleteWithoutBackup")]
        [Validation(Required=false)]
        public string ForceDeleteWithoutBackup { get; set; }

        /// <summary>
        /// <para>The ID of the KMS instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kst-hzz6****</para>
        /// </summary>
        [NameInMap("KmsInstanceId")]
        [Validation(Required=false)]
        public string KmsInstanceId { get; set; }

    }

}
