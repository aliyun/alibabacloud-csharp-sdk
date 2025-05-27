// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListAllProdsResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAllProdsResponseBodyData Data { get; set; }
        public class ListAllProdsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The cloud services.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ProdList")]
            [Validation(Required=false)]
            public List<ListAllProdsResponseBodyDataProdList> ProdList { get; set; }
            public class ListAllProdsResponseBodyDataProdList : TeaModel {
                /// <summary>
                /// <para>The code of the cloud service provider. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>qcloud: Tencent Cloud.</description></item>
                /// <item><description>aliyun: Alibaba Cloud.</description></item>
                /// <item><description>hcloud: Huawei Cloud.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>hcloud</para>
                /// </summary>
                [NameInMap("CloudCode")]
                [Validation(Required=false)]
                public string CloudCode { get; set; }

                /// <summary>
                /// <para>The number of logs within the cloud service that are added to the threat analysis feature.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ImportedLogCount")]
                [Validation(Required=false)]
                public int? ImportedLogCount { get; set; }

                /// <summary>
                /// <para>The time when the logs within the cloud service were last added to the threat analysis feature.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-11-23 12:12:12</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// <para>The code of the cloud service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sas</para>
                /// </summary>
                [NameInMap("ProdCode")]
                [Validation(Required=false)]
                public string ProdCode { get; set; }

                /// <summary>
                /// <para>The total number of logs within the cloud service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>19</para>
                /// </summary>
                [NameInMap("TotalLogCount")]
                [Validation(Required=false)]
                public int? TotalLogCount { get; set; }

            }

            /// <summary>
            /// <para>The total number of logs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>19</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

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
