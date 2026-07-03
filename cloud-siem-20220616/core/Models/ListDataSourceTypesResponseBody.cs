// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListDataSourceTypesResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDataSourceTypesResponseBodyData> Data { get; set; }
        public class ListDataSourceTypesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The code of the multicloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hcloud</para>
            /// </summary>
            [NameInMap("CloudCode")]
            [Validation(Required=false)]
            public string CloudCode { get; set; }

            /// <summary>
            /// <para>The type of the data source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>obs: Huawei Cloud OBS.</para>
            /// </description></item>
            /// <item><description><para>wafApi: Tencent Cloud WAF download API.</para>
            /// </description></item>
            /// <item><description><para>ckafka: Tencent Cloud CKafka.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>obs</para>
            /// </summary>
            [NameInMap("DataSourceType")]
            [Validation(Required=false)]
            public string DataSourceType { get; set; }

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
