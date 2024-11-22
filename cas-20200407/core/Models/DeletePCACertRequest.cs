// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class DeletePCACertRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the certificate. You can call the <a href="https://help.aliyun.com/document_detail/452331.html">ListCert</a> operation to query the unique identifiers of certificates.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccaf0c629c2be1e2ab</para>
        /// </summary>
        [NameInMap("Identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

    }

}
