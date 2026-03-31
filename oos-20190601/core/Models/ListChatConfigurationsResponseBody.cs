// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListChatConfigurationsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;Name&quot;: &quot;test-wechat&quot;, &quot;CreatedDate&quot;: &quot;2025-12-10T10:09:32+00:00&quot;, &quot;UpdatedDate&quot;: &quot;2025-12-28T13:59:48+00:00&quot;, &quot;RamRole&quot;: &quot;OOSServiceRole&quot;, &quot;Type&quot;: &quot;WeChat&quot;, &quot;Outputs&quot;: &quot;{\&quot;URL\&quot;: \&quot;<a href="https://1407907063606569.appflow.aliyunnes%5C%5C%22%7D%5D%7D">https://1407907063606569.appflow.aliyunnes\\&quot;}]}</a></para>
        /// </summary>
        [NameInMap("ChatConfigurations")]
        [Validation(Required=false)]
        public List<ListChatConfigurationsResponseBodyChatConfigurations> ChatConfigurations { get; set; }
        public class ListChatConfigurationsResponseBodyChatConfigurations : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-12-10T10:09:32+00:00</para>
            /// </summary>
            [NameInMap("CreatedDate")]
            [Validation(Required=false)]
            public string CreatedDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test-wechat</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;URL&quot;: &quot;<a href="https://1407907063606569.appflow.aliyunnes">https://1407907063606569.appflow.aliyunnes</a>&quot;, &quot;AesKey&quot;: &quot;UKAxyRabaJlaDxS3XZ6st18grPteemRtGeDVVgF&quot;}</para>
            /// </summary>
            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public string Outputs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OOSServiceRole</para>
            /// </summary>
            [NameInMap("RamRole")]
            [Validation(Required=false)]
            public string RamRole { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>WeChat</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-12-28T13:59:48+00:00</para>
            /// </summary>
            [NameInMap("UpdatedDate")]
            [Validation(Required=false)]
            public string UpdatedDate { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4DB0****1234</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
