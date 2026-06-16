// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class GetCAInstanceStatusRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the client certificate or server-side certificate to query.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/330884.html">ListClientCertificate</a> to query the unique identifiers of all client certificates and server-side certificates.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>160ae6bb538d538c70c01f81dcf2****</para>
        /// </summary>
        [NameInMap("Identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// <para>The ID of the private CA instance to query.</para>
        /// <remarks>
        /// <para>After you purchase a private CA instance in the <a href="https://yundun.console.aliyun.com/?p=cas#/pca/rootlist">CAS console</a>, you can go to the <b>Private Certificates</b> page and view the <b>details</b> of the instance to obtain its ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cas-member-0hmi****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
