// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListFlowTagGroupsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>”“</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>”“</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("flowTagGroups")]
        [Validation(Required=false)]
        public List<ListFlowTagGroupsResponseBodyFlowTagGroups> FlowTagGroups { get; set; }
        public class ListFlowTagGroupsResponseBodyFlowTagGroups : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>111111111</para>
            /// </summary>
            [NameInMap("creatorAccountId")]
            [Validation(Required=false)]
            public string CreatorAccountId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11111111</para>
            /// </summary>
            [NameInMap("modiferAccountId")]
            [Validation(Required=false)]
            public string ModiferAccountId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>标签名称</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ASSDS-ASSASX-XSAXSA-XSAXSAXS</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true 接口调用成功，false 接口调用失败</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
