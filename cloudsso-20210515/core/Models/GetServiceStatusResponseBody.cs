// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetServiceStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADADC31D-90EE-5459-99B0-D83DF07769A3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status information of CloudSSO.</para>
        /// </summary>
        [NameInMap("ServiceStatus")]
        [Validation(Required=false)]
        public GetServiceStatusResponseBodyServiceStatus ServiceStatus { get; set; }
        public class GetServiceStatusResponseBodyServiceStatus : TeaModel {
            /// <summary>
            /// <para>The ID of your Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>151266687691****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>Indicates whether you have permissions to enable CloudSSO. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Success: You have permissions to enable CloudSSO.</description></item>
            /// <item><description>Failed: You do not have permissions to enable CloudSSO.</description></item>
            /// </list>
            /// <remarks>
            /// <para> The value of this parameter is returned only if the value of <c>Status</c> is <c>Disabled</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("PrerequisiteCheckResult")]
            [Validation(Required=false)]
            public string PrerequisiteCheckResult { get; set; }

            /// <summary>
            /// <para>The ID of the region.</para>
            /// </summary>
            [NameInMap("RegionsInUse")]
            [Validation(Required=false)]
            public List<string> RegionsInUse { get; set; }

            /// <summary>
            /// <para>Indicates whether CloudSSO is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Enabled</description></item>
            /// <item><description>Disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
