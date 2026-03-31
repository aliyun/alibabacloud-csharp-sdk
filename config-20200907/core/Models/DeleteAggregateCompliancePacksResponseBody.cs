// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DeleteAggregateCompliancePacksResponseBody : TeaModel {
        /// <summary>
        /// <para>The results of the delete operations.</para>
        /// </summary>
        [NameInMap("OperateCompliancePacksResult")]
        [Validation(Required=false)]
        public DeleteAggregateCompliancePacksResponseBodyOperateCompliancePacksResult OperateCompliancePacksResult { get; set; }
        public class DeleteAggregateCompliancePacksResponseBodyOperateCompliancePacksResult : TeaModel {
            /// <summary>
            /// <para>An array that contains the deleted compliance packages.</para>
            /// </summary>
            [NameInMap("OperateCompliancePacks")]
            [Validation(Required=false)]
            public List<DeleteAggregateCompliancePacksResponseBodyOperateCompliancePacksResultOperateCompliancePacks> OperateCompliancePacks { get; set; }
            public class DeleteAggregateCompliancePacksResponseBodyOperateCompliancePacksResultOperateCompliancePacks : TeaModel {
                /// <summary>
                /// <para>The ID of the compliance package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cp-541e626622af0087****</para>
                /// </summary>
                [NameInMap("CompliancePackId")]
                [Validation(Required=false)]
                public string CompliancePackId { get; set; }

                /// <summary>
                /// <para>The error code returned.</para>
                /// <list type="bullet">
                /// <item><description>If the compliance package is deleted, no error code is returned.</description></item>
                /// <item><description>If the compliance package fails to be deleted, an error code is returned. For more information about error codes, see <a href="https://error-center.alibabacloud.com/status/product/Config">Error codes</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CompliancePackAlreadyPending</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>Indicates whether the request was successful. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The request was successful.</description></item>
                /// <item><description>false: The request failed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6EC7AED1-172F-42AE-9C12-295BC2ADB751</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
