// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListListenerCertificatesRequest : TeaModel {
        /// <summary>
        /// <para>The certificate IDs.</para>
        /// </summary>
        [NameInMap("CertificateIds")]
        [Validation(Required=false)]
        public List<string> CertificateIds { get; set; }

        /// <summary>
        /// <para>The type of the certificate. Valid values: <b>Ca</b> and <b>Server</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Server</para>
        /// </summary>
        [NameInMap("CertificateType")]
        [Validation(Required=false)]
        public string CertificateType { get; set; }

        /// <summary>
        /// <para>The listener ID. You must specify the ID of an HTTPS listener or a QUIC listener.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsr-bp1bpn0kn908w4nbw****</para>
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return. Valid values: <b>1 to 100</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>You do not need to specify this parameter for the first request.</description></item>
        /// <item><description>You must specify the token that is obtained from the previous query as the value of <b>NextToken</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
