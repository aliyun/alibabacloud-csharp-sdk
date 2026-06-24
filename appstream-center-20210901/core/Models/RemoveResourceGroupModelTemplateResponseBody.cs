// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class RemoveResourceGroupModelTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The removal results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<RemoveResourceGroupModelTemplateResponseBodyData> Data { get; set; }
        public class RemoveResourceGroupModelTemplateResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The error code returned if the operation fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InvalidParameter.resourceGroupIds</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The error message returned if the operation fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The parameter resourceGroupIds is invalid.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-xxxxx</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>Indicates whether the operation is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
