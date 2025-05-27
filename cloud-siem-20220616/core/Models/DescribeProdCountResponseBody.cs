// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeProdCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeProdCountResponseBodyData Data { get; set; }
        public class DescribeProdCountResponseBodyData : TeaModel {
            [NameInMap("AliyunImportedCount")]
            [Validation(Required=false)]
            public int? AliyunImportedCount { get; set; }

            /// <summary>
            /// <para>The number of Alibaba Cloud services.</para>
            /// 
            /// <b>Example:</b>
            /// <para>19</para>
            /// </summary>
            [NameInMap("AliyunProdCount")]
            [Validation(Required=false)]
            public int? AliyunProdCount { get; set; }

            [NameInMap("HcloudImportedCount")]
            [Validation(Required=false)]
            public int? HcloudImportedCount { get; set; }

            /// <summary>
            /// <para>The number of Huawei Cloud services.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("HcloudProdCount")]
            [Validation(Required=false)]
            public int? HcloudProdCount { get; set; }

            [NameInMap("IdcImportedCount")]
            [Validation(Required=false)]
            public int? IdcImportedCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("IdcProdCount")]
            [Validation(Required=false)]
            public int? IdcProdCount { get; set; }

            [NameInMap("QcloudImportedCount")]
            [Validation(Required=false)]
            public int? QcloudImportedCount { get; set; }

            /// <summary>
            /// <para>The number of Tencent Cloud services.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("QcloudProdCount")]
            [Validation(Required=false)]
            public int? QcloudProdCount { get; set; }

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
