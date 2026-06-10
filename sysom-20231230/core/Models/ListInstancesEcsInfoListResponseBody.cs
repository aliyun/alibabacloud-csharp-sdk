// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListInstancesEcsInfoListResponseBody : TeaModel {
        /// <summary>
        /// <para>error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>SysomOpenAPI.InvalidParameter</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Return Data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListInstancesEcsInfoListResponseBodyData> Data { get; set; }
        public class ListInstancesEcsInfoListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>IP address of the machine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11.193.52.91</para>
            /// </summary>
            [NameInMap("ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>Name of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sysom</para>
            /// </summary>
            [NameInMap("tag_key")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>diagnosis</para>
            /// </summary>
            [NameInMap("tag_value")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

            /// <summary>
            /// <para>IP type</para>
            /// 
            /// <b>Example:</b>
            /// <para>public</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>error message  </para>
        /// <list type="bullet">
        /// <item><description>If <c>code == Success</c>, this field is empty;  </description></item>
        /// <item><description>Otherwise, this field contains the request error message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
