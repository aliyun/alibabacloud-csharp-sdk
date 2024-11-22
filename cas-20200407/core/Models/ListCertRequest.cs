// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListCertRequest : TeaModel {
        /// <summary>
        /// <para>证书的类型 。取值：</para>
        /// <list type="bullet">
        /// <item><description><b>CA</b>：表示CA证书。</description></item>
        /// <item><description><b>CERT</b>：表示签发的证书。</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CERT</para>
        /// </summary>
        [NameInMap("CertType")]
        [Validation(Required=false)]
        public string CertType { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <para>The keyword for the query. You can enter a name, domain name, or Subject Alternative Name (SAN) extension. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_name</para>
        /// </summary>
        [NameInMap("KeyWord")]
        [Validation(Required=false)]
        public string KeyWord { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public long? ShowSize { get; set; }

        /// <summary>
        /// <para>The source of the certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>upload</b>: uploaded certificate</description></item>
        /// <item><description><b>aliyun</b>: Alibaba Cloud certificate</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The status of the certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ISSUE</b>: issued</description></item>
        /// <item><description><b>REVOKE</b>: revoked</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ISSUE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the certificate repository. You can call the ListCertWarehouse API operation to query the IDs of certificate repositories.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("WarehouseId")]
        [Validation(Required=false)]
        public long? WarehouseId { get; set; }

    }

}
