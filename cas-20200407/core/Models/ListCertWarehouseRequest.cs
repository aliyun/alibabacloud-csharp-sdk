// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListCertWarehouseRequest : TeaModel {
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
        /// <para>The instance ID of the certificate application repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14dcc8afc7578e1f</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the certificate application repository. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

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
        /// <para>The type of the certificate application repository. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ssl</b>: certificate application repository of SSL certificates</description></item>
        /// <item><description><b>uploadPCA</b>: certificate application repository of uploaded private certificates</description></item>
        /// <item><description><b>free</b>: certificate application repository of free certificates, available only on the China site (aliyun.com)</description></item>
        /// <item><description><b>aliyunPCA</b>: certificate application repository of private certificates purchased from Alibaba Cloud Private Certificate Authority (PCA), available only on the China site (aliyun.com)</description></item>
        /// <item><description><b>disable</b>: disabled certificate application repository</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>aliyunPCA</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
