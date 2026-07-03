// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListBindAccountResponseBody : TeaModel {
        /// <summary>
        /// <para>The result set.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListBindAccountResponseBodyData> Data { get; set; }
        public class ListBindAccountResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The AccessKey ID of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ABCXXXXXXXX</para>
            /// </summary>
            [NameInMap("AccessId")]
            [Validation(Required=false)]
            public string AccessId { get; set; }

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
            /// <para>The name of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>XXXX Company</para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>The binding ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123xxxxxxx</para>
            /// </summary>
            [NameInMap("BindId")]
            [Validation(Required=false)]
            public long? BindId { get; set; }

            /// <summary>
            /// <para>The code of the cloud service provider. Valid values:</para>
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
            /// <para>The user who bound the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123xxxxxxx</para>
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// <para>The number of data sources that are bound to the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("DataSourceCount")]
            [Validation(Required=false)]
            public long? DataSourceCount { get; set; }

            /// <summary>
            /// <para>The time when the binding was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-11-10 12:20:35</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

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
