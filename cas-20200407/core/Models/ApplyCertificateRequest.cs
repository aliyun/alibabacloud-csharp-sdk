// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ApplyCertificateRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance. You must call the UpdateInstance operation in advance to ensure that all application information for the instance has been updated and completed before applying for a certificate.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cas_dv-cn-rp643r82d0i1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
