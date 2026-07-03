// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeScopeUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code of the request.</para>
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
        public List<DescribeScopeUsersResponseBodyData> Data { get; set; }
        public class DescribeScopeUsersResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The user ID in Security Information and Event Management (SIEM).</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456789****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The cloud code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>qcloud: Tencent Cloud</para>
            /// </description></item>
            /// <item><description><para>hcloud: Huawei Cloud</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>qcloud</para>
            /// </summary>
            [NameInMap("CloudCode")]
            [Validation(Required=false)]
            public string CloudCode { get; set; }

            /// <summary>
            /// <para>The list of domain names protected by the WAF instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[123.com, 456.com]</para>
            /// </summary>
            [NameInMap("Domains")]
            [Validation(Required=false)]
            public List<string> Domains { get; set; }

            /// <summary>
            /// <para>The ID of the Web Application Firewall (WAF) instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>waf-cn-tl123ast****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The multicloud user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456789****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test001</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The message returned for the request.</para>
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
        /// <item><description><para>true: The request was successful.</para>
        /// </description></item>
        /// <item><description><para>false: The request failed.</para>
        /// </description></item>
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
