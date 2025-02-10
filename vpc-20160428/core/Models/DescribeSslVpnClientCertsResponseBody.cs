// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeSslVpnClientCertsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5BE01CD7-5A50-472D-AC14-CA181C5C03BE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the SSL client certificates.</para>
        /// </summary>
        [NameInMap("SslVpnClientCertKeys")]
        [Validation(Required=false)]
        public DescribeSslVpnClientCertsResponseBodySslVpnClientCertKeys SslVpnClientCertKeys { get; set; }
        public class DescribeSslVpnClientCertsResponseBodySslVpnClientCertKeys : TeaModel {
            [NameInMap("SslVpnClientCertKey")]
            [Validation(Required=false)]
            public List<DescribeSslVpnClientCertsResponseBodySslVpnClientCertKeysSslVpnClientCertKey> SslVpnClientCertKey { get; set; }
            public class DescribeSslVpnClientCertsResponseBodySslVpnClientCertKeysSslVpnClientCertKey : TeaModel {
                /// <summary>
                /// <para>The timestamp generated when the SSL client certificate was created. Unit: milliseconds.</para>
                /// <para>This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1492747187000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The timestamp generated when the SSL client certificate expires. Unit: milliseconds.</para>
                /// <para>This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1494966335000</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The name of the SSL client certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cert1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The region ID of the SSL client certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The ID of the resource group to which the SSL client certificate belongs.</para>
                /// <para>You can call the <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> operation to query resource groups.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmzs372yg****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The ID of the SSL client certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsc-bp1n8wcf134yl0osr****</para>
                /// </summary>
                [NameInMap("SslVpnClientCertId")]
                [Validation(Required=false)]
                public string SslVpnClientCertId { get; set; }

                /// <summary>
                /// <para>The ID of the SSL server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vss-bp18q7hzj6largv4v****</para>
                /// </summary>
                [NameInMap("SslVpnServerId")]
                [Validation(Required=false)]
                public string SslVpnServerId { get; set; }

                /// <summary>
                /// <para>The status of the SSL client certificate. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>expiring-soon</b>: The certificate expires in one week.</description></item>
                /// <item><description><b>normal</b></description></item>
                /// <item><description><b>expired</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
