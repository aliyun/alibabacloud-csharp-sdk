// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListCertRequest : TeaModel {
        /// <summary>
        /// <para>The certificate type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>CA</b>: CA certificate</para>
        /// </description></item>
        /// <item><description><para><b>CERT</b>: issued certificate</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CERT</para>
        /// </summary>
        [NameInMap("CertType")]
        [Validation(Required=false)]
        public string CertType { get; set; }

        /// <summary>
        /// <para>The page number to return. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <para>A comma-separated list of certificate identifiers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aaa,bbb</para>
        /// </summary>
        [NameInMap("Identifiers")]
        [Validation(Required=false)]
        public string Identifiers { get; set; }

        /// <summary>
        /// <para>The keyword for a fuzzy search by name, domain name, or subject alternative name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_name</para>
        /// </summary>
        [NameInMap("KeyWord")]
        [Validation(Required=false)]
        public string KeyWord { get; set; }

        /// <summary>
        /// <para>The number of entries per page. The default value is 50.</para>
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
        /// <item><description><para><b>upload</b>: uploaded certificate</para>
        /// </description></item>
        /// <item><description><para><b>aliyun</b>: Alibaba Cloud certificate</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The certificate status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ISSUE</b>: issued</para>
        /// </description></item>
        /// <item><description><para><b>REVOKE</b>: revoked</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ISSUE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The warehouse ID. You can obtain this ID by calling the <a href="https://help.aliyun.com/document_detail/453246.html">ListCertWarehouse</a> API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("WarehouseId")]
        [Validation(Required=false)]
        public long? WarehouseId { get; set; }

    }

}
