// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class GetCAInstanceStatusRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>160ae6bb538d538c70c01f81dcf2****</para>
        /// </summary>
        [NameInMap("Identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// <para>The ID of the private CA instance.</para>
        /// <remarks>
        /// <para> After you purchase a private CA instance by using the <a href="https://yundun.console.aliyun.com/?p=cas#/pca/rootlist">SSL Certificates Service console</a>, you can click <b>Details</b> for the private CA instance on the <b>Private Certificates</b> page to query the ID of the private CA instance.</para>
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
