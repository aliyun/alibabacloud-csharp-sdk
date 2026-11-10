// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class ListListenerCertificatesRequest : TeaModel {
        /// <summary>
        /// <para>The certificate type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Ca</b>: CA certificate.</description></item>
        /// <item><description><b>Server</b>: Server certificate.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Ca</para>
        /// </summary>
        [NameInMap("CertType")]
        [Validation(Required=false)]
        public string CertType { get; set; }

        /// <summary>
        /// <para>The server certificates. You can add only one server certificate.</para>
        /// <remarks>
        /// <para>This parameter takes effect only for TCPSSL listeners.</para>
        /// </remarks>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("CertificateIds")]
        [Validation(Required=false)]
        public List<string> CertificateIds { get; set; }

        /// <summary>
        /// <para>The listener ID. This parameter is valid only for TCPSSL listeners.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsn-j49ht1jxxqyg45****@80</para>
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// <para>The number of entries to return per page. Valid values: <b>1</b> to <b>50</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next query.</para>
        /// <list type="bullet">
        /// <item><description>Leave this parameter empty for the first query or when no subsequent query is required.</description></item>
        /// <item><description>For subsequent queries, set this parameter to the NextToken value returned by the previous API call.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID of the Network Load Balancer (NLB) instance.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/443657.html">DescribeRegions</a> operation to query region IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
