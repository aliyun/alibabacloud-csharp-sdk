// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class UpdateCACertificateStatusRequest : TeaModel {
        /// <summary>
        /// <para>A client token used to ensure the idempotence of the request.</para>
        /// <para>Generate a unique parameter value from your client for each request. The ClientToken parameter supports only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request is different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3838B684-3075-582B-9A45-8C99104029DF</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The unique identifier of the CA certificate.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/465957.html">DescribeCACertificateList</a> to query the unique identifiers of all CA certificates.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>160ae6bb538d538c70c01f81dcf2****</para>
        /// </summary>
        [NameInMap("Identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// <para>The operation to perform on the CA certificate. Set the value to <b>REVOKE</b>. This revokes the CA certificate and changes its status to <b>REVOKE</b>.</para>
        /// <remarks>
        /// <para>This operation is supported only when the CA certificate is in the <b>ISSUE</b> state. Call <a href="https://help.aliyun.com/document_detail/465954.html">DescribeCACertificate</a> to query the current status of the CA certificate.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>REVOKE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
