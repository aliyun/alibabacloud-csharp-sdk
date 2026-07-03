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
            /// <summary>
            /// <para>The number of automatically connected Alibaba Cloud products.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AliyunImportedCount")]
            [Validation(Required=false)]
            public int? AliyunImportedCount { get; set; }

            /// <summary>
            /// <para>The number of Alibaba Cloud products.</para>
            /// 
            /// <b>Example:</b>
            /// <para>19</para>
            /// </summary>
            [NameInMap("AliyunProdCount")]
            [Validation(Required=false)]
            public int? AliyunProdCount { get; set; }

            /// <summary>
            /// <para>The number of automatically connected Huawei Cloud products.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("HcloudImportedCount")]
            [Validation(Required=false)]
            public int? HcloudImportedCount { get; set; }

            /// <summary>
            /// <para>The number of Huawei Cloud products.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("HcloudProdCount")]
            [Validation(Required=false)]
            public int? HcloudProdCount { get; set; }

            /// <summary>
            /// <para>The number of automatically connected IDC products.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("IdcImportedCount")]
            [Validation(Required=false)]
            public int? IdcImportedCount { get; set; }

            /// <summary>
            /// <para>The number of IDC products.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("IdcProdCount")]
            [Validation(Required=false)]
            public int? IdcProdCount { get; set; }

            /// <summary>
            /// <para>The number of automatically connected Tencent Cloud products.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("QcloudImportedCount")]
            [Validation(Required=false)]
            public int? QcloudImportedCount { get; set; }

            /// <summary>
            /// <para>The number of Tencent Cloud products.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("QcloudProdCount")]
            [Validation(Required=false)]
            public int? QcloudProdCount { get; set; }

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
