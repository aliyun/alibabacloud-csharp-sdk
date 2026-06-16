// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class ListCACertificateLogRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the CA certificate to query.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/328095.html">DescribeCACertificateList</a> to query the unique identifiers of all CA certificates.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>160ae6bb538d538c70c01f81dcf2****</para>
        /// </summary>
        [NameInMap("Identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

    }

}
