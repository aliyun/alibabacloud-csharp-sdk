// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListCertWarehouseResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of certificate repositories.</para>
        /// </summary>
        [NameInMap("CertWarehouseList")]
        [Validation(Required=false)]
        public List<ListCertWarehouseResponseBodyCertWarehouseList> CertWarehouseList { get; set; }
        public class ListCertWarehouseResponseBodyCertWarehouseList : TeaModel {
            /// <summary>
            /// <para>The expiration time, in timestamp format. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1665819958000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The sales instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>14dcc8afc7578e1f</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Indicates whether the repository has expired. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsExpired")]
            [Validation(Required=false)]
            public bool? IsExpired { get; set; }

            /// <summary>
            /// <para>The repository name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The PCA instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>14dcc8afc7578e1f</para>
            /// </summary>
            [NameInMap("PcaInstanceId")]
            [Validation(Required=false)]
            public string PcaInstanceId { get; set; }

            /// <summary>
            /// <para>Qps。</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Qps")]
            [Validation(Required=false)]
            public long? Qps { get; set; }

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

            /// <summary>
            /// <para>The repository ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("WhId")]
            [Validation(Required=false)]
            public long? WhId { get; set; }

        }

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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15C66C7B-671A-4297-9187-2C4477247A74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
