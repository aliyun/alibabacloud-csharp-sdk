// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListCertWarehouseResponseBody : TeaModel {
        /// <summary>
        /// <para>The certificate application repositories.</para>
        /// </summary>
        [NameInMap("CertWarehouseList")]
        [Validation(Required=false)]
        public List<ListCertWarehouseResponseBodyCertWarehouseList> CertWarehouseList { get; set; }
        public class ListCertWarehouseResponseBodyCertWarehouseList : TeaModel {
            /// <summary>
            /// <para>The timestamp when the certificate application repository expires. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1665819958000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

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
            /// <para>Indicates whether the certificate application repository has expired. Valid values:</para>
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
            /// <para>The name of the certificate application repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The instance ID of the private CA.</para>
            /// 
            /// <b>Example:</b>
            /// <para>14dcc8afc7578e1f</para>
            /// </summary>
            [NameInMap("PcaInstanceId")]
            [Validation(Required=false)]
            public string PcaInstanceId { get; set; }

            /// <summary>
            /// <para>The queries per second (QPS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Qps")]
            [Validation(Required=false)]
            public long? Qps { get; set; }

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

            /// <summary>
            /// <para>The ID of the certificate application repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("WhId")]
            [Validation(Required=false)]
            public long? WhId { get; set; }

        }

        /// <summary>
        /// <para>The page number of the returned page. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15C66C7B-671A-4297-9187-2C4477247A74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page. Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public long? ShowSize { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
