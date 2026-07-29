// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class RevokeCertificateRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>51001</para>
        /// </summary>
        [NameInMap("CertificateId")]
        [Validation(Required=false)]
        public long? CertificateId { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cas-cn-68n1mm16****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
