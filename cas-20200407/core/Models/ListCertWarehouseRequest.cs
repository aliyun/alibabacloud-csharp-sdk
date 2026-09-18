// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListCertWarehouseRequest : TeaModel {
        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <para>The repository instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14dcc8afc7578e1f</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The repository name. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public long? ShowSize { get; set; }

        /// <summary>
        /// <para>The repository type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>uploadCA</b>: an uploaded CA certificate that contains a complete certificate chain.</description></item>
        /// <item><description><b>uploadPCA</b>: an uploaded certificate, including a self-signed certificate, a certificate issued by a third party, or a certificate issued by Alibaba Cloud.</description></item>
        /// <item><description><b>aliyunPCA</b>: an Alibaba Cloud PCA certificate.</description></item>
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
