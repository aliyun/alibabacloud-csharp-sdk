// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class QueryRegionConfigResponseBody : TeaModel {
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
        /// <para>The additional information that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The information about region configurations.</para>
        /// </summary>
        [NameInMap("RegionConfig")]
        [Validation(Required=false)]
        public QueryRegionConfigResponseBodyRegionConfig RegionConfig { get; set; }
        public class QueryRegionConfigResponseBodyRegionConfig : TeaModel {
            /// <summary>
            /// <para>The domain name of Address Server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>****.edas.aliyun.com</para>
            /// </summary>
            [NameInMap("AddressServerHost")]
            [Validation(Required=false)]
            public string AddressServerHost { get; set; }

            /// <summary>
            /// <para>The installation path of the script for EDAS Agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://edas-qd.oss-cn-****-internal.aliyuncs.com/****sh">http://edas-qd.oss-cn-****-internal.aliyuncs.com/****sh</a></para>
            /// </summary>
            [NameInMap("AgentInstallScript")]
            [Validation(Required=false)]
            public string AgentInstallScript { get; set; }

            /// <summary>
            /// <para>The information about the file server.</para>
            /// </summary>
            [NameInMap("FileServerConfig")]
            [Validation(Required=false)]
            public QueryRegionConfigResponseBodyRegionConfigFileServerConfig FileServerConfig { get; set; }
            public class QueryRegionConfigResponseBodyRegionConfigFileServerConfig : TeaModel {
                /// <summary>
                /// <para>The Object Storage Service (OSS) bucket of the file server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>edas-bj</para>
                /// </summary>
                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                /// <summary>
                /// <para>The internal endpoint of the file server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss-cn-beijing-****.aliyuncs.com</para>
                /// </summary>
                [NameInMap("InternalUrl")]
                [Validation(Required=false)]
                public string InternalUrl { get; set; }

                /// <summary>
                /// <para>The public endpoint of the file server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss-cn-beijing.aliyuncs.com</para>
                /// </summary>
                [NameInMap("PublicUrl")]
                [Validation(Required=false)]
                public string PublicUrl { get; set; }

                /// <summary>
                /// <para>The virtual private cloud (VPC) endpoint of the file server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v*****-oss-cn-beijing.aliyuncs.com</para>
                /// </summary>
                [NameInMap("VpcUrl")]
                [Validation(Required=false)]
                public string VpcUrl { get; set; }

            }

            /// <summary>
            /// <para>The type of the file server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss</para>
            /// </summary>
            [NameInMap("FileServerType")]
            [Validation(Required=false)]
            public string FileServerType { get; set; }

            /// <summary>
            /// <para>The configured ID of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The ID of the official image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m-2zea4hx8f9zxqah2****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The configured name of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China (Beijing)</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The serial number of the region. This parameter is deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("No")]
            [Validation(Required=false)]
            public int? No { get; set; }

            /// <summary>
            /// <para>The tag of the region. The value is fixed to <c>ALIYUN_SHARE</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN_SHARE</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b197-40ab-9155-7ca7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
