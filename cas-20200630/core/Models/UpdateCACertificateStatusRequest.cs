// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class UpdateCACertificateStatusRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the CA certificate whose status you want to change.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/328095.html">DescribeCACertificateList</a> operation to query the unique identifiers of all CA certificates.</para>
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
        /// <para>The state to which you want to change the CA certificate. Set to the value to <b>REVOKE</b>. After this operation is called, the status of the CA certificate is changed to <b>REVOKE</b>.</para>
        /// <remarks>
        /// <para> You can call this operation only if the status of a CA certificate is <b>ISSUE</b>. You can call the <a href="https://help.aliyun.com/document_detail/328096.html">DescribeCACertificate</a> operation to query the status of a CA certificate.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>REVOKE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
