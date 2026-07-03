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
            /// <para>The ID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123xxxxxxx</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The code for the multicloud environment. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>qcloud: Tencent Cloud.</para>
            /// </description></item>
            /// <item><description><para>aliyun: Alibaba Cloud.</para>
            /// </description></item>
            /// <item><description><para>hcloud: Huawei Cloud.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>hcloud</para>
            /// </summary>
            [NameInMap("CloudCode")]
            [Validation(Required=false)]
            public string CloudCode { get; set; }

            /// <summary>
            /// <para>The ID of the data source. The threat analysis service generates the ID by calculating the MD5 hash of specific parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>220ba97c9d1fdb0b9c7e8c7ca328d7ea</para>
            /// </summary>
            [NameInMap("DataSourceInstanceId")]
            [Validation(Required=false)]
            public string DataSourceInstanceId { get; set; }

            /// <summary>
            /// <para>The list of detailed parameters for the data source.</para>
            /// </summary>
            [NameInMap("DataSourceInstanceParams")]
            [Validation(Required=false)]
            public List<DescribeDataSourceInstanceResponseBodyDataDataSourceInstanceParams> DataSourceInstanceParams { get; set; }
            public class DescribeDataSourceInstanceResponseBodyDataDataSourceInstanceParams : TeaModel {
                /// <summary>
                /// <para>The parameter code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>region_code</para>
                /// </summary>
                [NameInMap("ParaCode")]
                [Validation(Required=false)]
                public string ParaCode { get; set; }

                /// <summary>
                /// <para>The parameter value.</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
