// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeDataSourceInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDataSourceInstanceResponseBodyData Data { get; set; }
        public class DescribeDataSourceInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123xxxxxxx</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The code of the cloud service provider. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>qcloud: Tencent Cloud</description></item>
            /// <item><description>aliyun: Alibaba Cloud</description></item>
            /// <item><description>hcloud: Huawei Cloud</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>hcloud</para>
            /// </summary>
            [NameInMap("CloudCode")]
            [Validation(Required=false)]
            public string CloudCode { get; set; }

            /// <summary>
            /// <para>The ID of the data source. The ID is an MD5 hash value that is calculated by the threat analysis feature based on specific parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>220ba97c9d1fdb0b9c7e8c7ca328d7ea</para>
            /// </summary>
            [NameInMap("DataSourceInstanceId")]
            [Validation(Required=false)]
            public string DataSourceInstanceId { get; set; }

            /// <summary>
            /// <para>The parameters of the data source.</para>
            /// </summary>
            [NameInMap("DataSourceInstanceParams")]
            [Validation(Required=false)]
            public List<DescribeDataSourceInstanceResponseBodyDataDataSourceInstanceParams> DataSourceInstanceParams { get; set; }
            public class DescribeDataSourceInstanceResponseBodyDataDataSourceInstanceParams : TeaModel {
                /// <summary>
                /// <para>The code of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>region_code</para>
                /// </summary>
                [NameInMap("ParaCode")]
                [Validation(Required=false)]
                public string ParaCode { get; set; }

                /// <summary>
                /// <para>The value of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ap-guangzhou</para>
                /// </summary>
                [NameInMap("ParaValue")]
                [Validation(Required=false)]
                public string ParaValue { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
