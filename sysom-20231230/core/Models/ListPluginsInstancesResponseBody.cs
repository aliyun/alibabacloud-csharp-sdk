// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListPluginsInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code  </para>
        /// <list type="bullet">
        /// <item><description><c>code == Success</c> indicates successful authorization;  </description></item>
        /// <item><description>Other status codes indicate failed authorization. When authorization fails, view the <c>message</c> field to obtain detailed error information.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Return Result.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListPluginsInstancesResponseBodyData> Data { get; set; }
        public class ListPluginsInstancesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp118piqcio9tiwgh84b</para>
            /// </summary>
            [NameInMap("instance_id")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Widget instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>allowed-repos-qmf8w</para>
            /// </summary>
            [NameInMap("instance_name")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>Tags of instances</para>
            /// </summary>
            [NameInMap("instance_tag")]
            [Validation(Required=false)]
            public List<ListPluginsInstancesResponseBodyDataInstanceTag> InstanceTag { get; set; }
            public class ListPluginsInstancesResponseBodyDataInstanceTag : TeaModel {
                /// <summary>
                /// <para>Name of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_tag_key</para>
                /// </summary>
                [NameInMap("tag_key")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>Tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_tag_value</para>
                /// </summary>
                [NameInMap("tag_value")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>Operating system name of the instance</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba Cloud Linux  3.2104 LTS 64 bit</para>
            /// </summary>
            [NameInMap("os_name")]
            [Validation(Required=false)]
            public string OsName { get; set; }

            /// <summary>
            /// <para>Private IP address</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.1.1</para>
            /// </summary>
            [NameInMap("private_ip")]
            [Validation(Required=false)]
            public string PrivateIp { get; set; }

            /// <summary>
            /// <para>Internet IP address</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.1.1</para>
            /// </summary>
            [NameInMap("public_ip")]
            [Validation(Required=false)]
            public string PublicIp { get; set; }

            /// <summary>
            /// <para>Area where the instance resides</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>Resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-xxxx</para>
            /// </summary>
            [NameInMap("resource_group_id")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>Resource group name</para>
            /// 
            /// <b>Example:</b>
            /// <para>default resource group</para>
            /// </summary>
            [NameInMap("resource_group_name")]
            [Validation(Required=false)]
            public string ResourceGroupName { get; set; }

        }

        /// <summary>
        /// <para>Description</para>
        /// 
        /// <b>Example:</b>
        /// <para>SysomOpenAPIException: SysomOpenAPI.InvalidParameter Invalid params, should be json string or dict</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request RequestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>35F91AAB-5FDF-5A22-B211-C7C6B00817D0</para>
        /// </summary>
        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
