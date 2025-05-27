// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeAlertSceneByEventResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeAlertSceneByEventResponseBodyData> Data { get; set; }
        public class DescribeAlertSceneByEventResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The alert name. The display name of the alert name varies based on the language of the system, such as Chinese and English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>login_common_ip</para>
            /// </summary>
            [NameInMap("AlertName")]
            [Validation(Required=false)]
            public string AlertName { get; set; }

            /// <summary>
            /// <para>The ID of the alert name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>login_common_ip</para>
            /// </summary>
            [NameInMap("AlertNameId")]
            [Validation(Required=false)]
            public string AlertNameId { get; set; }

            /// <summary>
            /// <para>The alert title. The display name of the alert title varies based on the language of the system, such as Chinese and English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Unusual Logon-login_common_ip</para>
            /// </summary>
            [NameInMap("AlertTile")]
            [Validation(Required=false)]
            public string AlertTile { get; set; }

            /// <summary>
            /// <para>The ID of the alert title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Unusual Logon-login_common_ip</para>
            /// </summary>
            [NameInMap("AlertTileId")]
            [Validation(Required=false)]
            public string AlertTileId { get; set; }

            /// <summary>
            /// <para>The alert type. The display name of the alert type varies based on the language of the system, such as Chinese and English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Unusual Logon</para>
            /// </summary>
            [NameInMap("AlertType")]
            [Validation(Required=false)]
            public string AlertType { get; set; }

            /// <summary>
            /// <para>The ID of the alert type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Unusual Logon</para>
            /// </summary>
            [NameInMap("AlertTypeId")]
            [Validation(Required=false)]
            public string AlertTypeId { get; set; }

            /// <summary>
            /// <para>The objects that can be added to the whitelist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;Type&quot;: &quot;host_uuid&quot;,&quot;Value&quot;: &quot;441862da-a539-4cc0-a00d-473955826881&quot;,&quot;Values&quot;: [&quot;441862da-a539-4cc0-a00d-473955826881&quot;],&quot;Name&quot;: &quot;${aliyun.siem.entity.host_uuid}&quot;}]</para>
            /// </summary>
            [NameInMap("Targets")]
            [Validation(Required=false)]
            public List<DescribeAlertSceneByEventResponseBodyDataTargets> Targets { get; set; }
            public class DescribeAlertSceneByEventResponseBodyDataTargets : TeaModel {
                /// <summary>
                /// <para>The display name of the entity attribute field that can be added to the whitelist.</para>
                /// 
                /// <b>Example:</b>
                /// <para>host uuid</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The entity attribute field that can be added to the whitelist.</para>
                /// 
                /// <b>Example:</b>
                /// <para>host_uuid</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The right operand that is displayed by default in the whitelist rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>441862da-a539-4cc0-a00d-47395582****</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// <para>The supported right operands of the whitelist rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;441862da-a539-4cc0-a00d-473955826881&quot;]</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9AAA9ED9-78F4-5021-86DC-D51C7511****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
