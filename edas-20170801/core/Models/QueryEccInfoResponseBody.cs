// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class QueryEccInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The information about the ECC.</para>
        /// </summary>
        [NameInMap("EccInfo")]
        [Validation(Required=false)]
        public QueryEccInfoResponseBodyEccInfo EccInfo { get; set; }
        public class QueryEccInfoResponseBodyEccInfo : TeaModel {
            /// <summary>
            /// <para>The ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e809****-43d7-4c6b-8e01-b0d9d1db****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>ECC ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>a5b9****-40b4-4d7b-9c2a-55d6c1c0****</para>
            /// </summary>
            [NameInMap("EccId")]
            [Validation(Required=false)]
            public string EccId { get; set; }

            /// <summary>
            /// <para>ECU ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>0d4e****-6d87-401f-ba81-13df9877****</para>
            /// </summary>
            [NameInMap("EcuId")]
            [Validation(Required=false)]
            public string EcuId { get; set; }

            /// <summary>
            /// <para>The ID of the ECC group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>57cd****-2d3b-496f-bcce-646d0a4d****</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The name of the ECC group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>_DEFAULT_GROUP</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The MD5 hash value of the deployment package version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bab6<b><b>7a090e41ca9445c9b3cd</b></b></para>
            /// </summary>
            [NameInMap("PackageMd5")]
            [Validation(Required=false)]
            public string PackageMd5 { get; set; }

            /// <summary>
            /// <para>The version of the deployment package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20210209.153400</para>
            /// </summary>
            [NameInMap("PackageVersion")]
            [Validation(Required=false)]
            public string PackageVersion { get; set; }

            /// <summary>
            /// <para>VPC ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-23727****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The additional information that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b197-40ab-9155-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
