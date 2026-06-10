// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListAgentInstallRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID, which can be used for end-to-end Diagnosis</para>
        /// 
        /// <b>Example:</b>
        /// <para>E8CDFBA1-0564-5897-B070-D3C85002AF2F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Status code  </para>
        /// <list type="bullet">
        /// <item><description><c>code == Success</c> indicates successful authorization;  </description></item>
        /// <item><description>Other status codes indicate failed authorization. When authorization fails, view the <c>message</c> field to obtain detailed error message;</description></item>
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
        public List<ListAgentInstallRecordsResponseBodyData> Data { get; set; }
        public class ListAgentInstallRecordsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Creation Time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-11-27T16:37:53</para>
            /// </summary>
            [NameInMap("created_at")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp118piqcio9tiwgh84b</para>
            /// </summary>
            [NameInMap("instance_id")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>widget ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>74a86327-3170-412c-8e67-da3389ec56a9</para>
            /// </summary>
            [NameInMap("plugin_id")]
            [Validation(Required=false)]
            public string PluginId { get; set; }

            /// <summary>
            /// <para>plugin Version</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.4.0-1</para>
            /// </summary>
            [NameInMap("plugin_version")]
            [Validation(Required=false)]
            public string PluginVersion { get; set; }

            /// <summary>
            /// <para>widget status</para>
            /// 
            /// <b>Example:</b>
            /// <para>Installed</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Updated At</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-11-27T16:37:53</para>
            /// </summary>
            [NameInMap("updated_at")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

        }

        /// <summary>
        /// <para>error message  </para>
        /// <list type="bullet">
        /// <item><description>If <c>code == Success</c>, this field is empty;  </description></item>
        /// <item><description>Otherwise, this field contains the request error message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SysomOpenAPIAssumeRoleException: EntityNotExist.Role The role not exists: acs:ram::xxxxx:role/aliyunserviceroleforsysom</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
