// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeAbnormalCloudResourcesResponseBody : TeaModel {
        [NameInMap("AbnormalCloudResources")]
        [Validation(Required=false)]
        public List<DescribeAbnormalCloudResourcesResponseBodyAbnormalCloudResources> AbnormalCloudResources { get; set; }
        public class DescribeAbnormalCloudResourcesResponseBodyAbnormalCloudResources : TeaModel {
            [NameInMap("CloudResourceId")]
            [Validation(Required=false)]
            public string CloudResourceId { get; set; }

            [NameInMap("Details")]
            [Validation(Required=false)]
            public List<DescribeAbnormalCloudResourcesResponseBodyAbnormalCloudResourcesDetails> Details { get; set; }
            public class DescribeAbnormalCloudResourcesResponseBodyAbnormalCloudResourcesDetails : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("AppliedType")]
                [Validation(Required=false)]
                public string AppliedType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test-name</para>
                /// </summary>
                [NameInMap("CertName")]
                [Validation(Required=false)]
                public string CertName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CertExpired</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://www.test.com">www.test.com</a></para>
                /// </summary>
                [NameInMap("CommonName")]
                [Validation(Required=false)]
                public string CommonName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1735009193</para>
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public long? ExpireTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123-cn-hangzhou</para>
                /// </summary>
                [NameInMap("ProductCertId")]
                [Validation(Required=false)]
                public string ProductCertId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test-name</para>
                /// </summary>
                [NameInMap("ProductCertName")]
                [Validation(Required=false)]
                public string ProductCertName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://www.test.com">www.test.com</a></para>
                /// </summary>
                [NameInMap("ProductDomainExtension")]
                [Validation(Required=false)]
                public string ProductDomainExtension { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CertExpired</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>lb-***</para>
            /// </summary>
            [NameInMap("ResourceInstanceId")]
            [Validation(Required=false)]
            public string ResourceInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test-name</para>
            /// </summary>
            [NameInMap("ResourceInstanceName")]
            [Validation(Required=false)]
            public string ResourceInstanceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("ResourceInstancePort")]
            [Validation(Required=false)]
            public int? ResourceInstancePort { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>clb7</para>
            /// </summary>
            [NameInMap("ResourceProduct")]
            [Validation(Required=false)]
            public string ResourceProduct { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>66A98669-CC6E-4F3E-80A6-***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
