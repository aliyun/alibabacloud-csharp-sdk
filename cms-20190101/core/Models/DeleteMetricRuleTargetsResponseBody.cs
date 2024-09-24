// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DeleteMetricRuleTargetsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <para>**</para>
        /// <para><b>Description</b> The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The IDs of the resources that failed to be deleted.</para>
        /// </summary>
        [NameInMap("FailIds")]
        [Validation(Required=false)]
        public DeleteMetricRuleTargetsResponseBodyFailIds FailIds { get; set; }
        public class DeleteMetricRuleTargetsResponseBodyFailIds : TeaModel {
            /// <summary>
            /// <para>The IDs of the resources that failed to be deleted.</para>
            /// </summary>
            [NameInMap("TargetIds")]
            [Validation(Required=false)]
            public DeleteMetricRuleTargetsResponseBodyFailIdsTargetIds TargetIds { get; set; }
            public class DeleteMetricRuleTargetsResponseBodyFailIdsTargetIds : TeaModel {
                [NameInMap("TargetId")]
                [Validation(Required=false)]
                public List<string> TargetId { get; set; }

            }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The Request is not authorization.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>786E92D2-AC66-4250-B76F-F1E2FCDDBA1C</para>
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
