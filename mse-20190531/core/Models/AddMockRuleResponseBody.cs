// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class AddMockRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data overview.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AddMockRuleResponseBodyData Data { get; set; }
        public class AddMockRuleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>178432728867xxxx</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The ID of the service consumer application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hkhon1po62@a000601b265xxxx</para>
            /// </summary>
            [NameInMap("ConsumerAppId")]
            [Validation(Required=false)]
            public string ConsumerAppId { get; set; }

            /// <summary>
            /// <para>The name of the application to be queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo-xxxx</para>
            /// </summary>
            [NameInMap("ConsumerAppName")]
            [Validation(Required=false)]
            public string ConsumerAppName { get; set; }

            /// <summary>
            /// <para>Indicates whether the rule is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Enabled.</description></item>
            /// <item><description><c>false</c>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desc</para>
            /// </summary>
            [NameInMap("ExtraJson")]
            [Validation(Required=false)]
            public string ExtraJson { get; set; }

            /// <summary>
            /// <para>The rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>275</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The model type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>[unk]0[unk]</c>: Desktop model</description></item>
            /// <item><description><c>[unk]1[unk]</c>: Mobile model</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MockType")]
            [Validation(Required=false)]
            public long? MockType { get; set; }

            /// <summary>
            /// <para>The name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse-bc1a29b0-160230875****-reg-center-0-1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The namespace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            /// <summary>
            /// <para>The ID of the service provider application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hkhon1po62@a000601b265xxxx</para>
            /// </summary>
            [NameInMap("ProviderAppId")]
            [Validation(Required=false)]
            public string ProviderAppId { get; set; }

            /// <summary>
            /// <para>The name of the service provider application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo-xxxx</para>
            /// </summary>
            [NameInMap("ProviderAppName")]
            [Validation(Required=false)]
            public string ProviderAppName { get; set; }

            /// <summary>
            /// <para>The region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The mock rule for the HTTP protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;oper&quot;:&quot;return+json&quot;,&quot;Path&quot;:&quot;/mock&quot;,&quot;Value&quot;:&quot;{\n \&quot;date\&quot;: \&quot;2021-09-10T07:45:12.357+0000\&quot;,\n \&quot;name\&quot;: \&quot;name\&quot;,\n \&quot;id\&quot;: \&quot;1\&quot;\n}&quot;,&quot;Method&quot;:&quot;GET&quot;,&quot;Condition&quot;:&quot;AND&quot;,&quot;Timeout&quot;:1,&quot;ArgumentMockItems&quot;:[{&quot;type&quot;:&quot;param&quot;,&quot;name&quot;:&quot;id&quot;,&quot;value&quot;:&quot;1&quot;,&quot;cond&quot;:&quot;==&quot;,&quot;operator&quot;:&quot;rawvalue&quot;},{&quot;type&quot;:&quot;param&quot;,&quot;name&quot;:&quot;name&quot;,&quot;value&quot;:&quot;aliyun&quot;,&quot;cond&quot;:&quot;==&quot;,&quot;operator&quot;:&quot;rawvalue&quot;}]}]</para>
            /// </summary>
            [NameInMap("ScMockItemJson")]
            [Validation(Required=false)]
            public string ScMockItemJson { get; set; }

            /// <summary>
            /// <para>The source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>edasmsc</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Succ</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>316F5F64-F73D-42DC-8632-01E308B6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request succeeded.</description></item>
        /// <item><description><c>false</c>: The request failed.</description></item>
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
