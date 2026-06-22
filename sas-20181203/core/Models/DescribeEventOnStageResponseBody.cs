// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeEventOnStageResponseBody : TeaModel {
        /// <summary>
        /// <para>The unique identifier that Alibaba Cloud generated for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24A20733-10A0-4AF6-BE6B-E332241XXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The platforms supported by threat detection.</para>
        /// </summary>
        [NameInMap("SecurityEventStageResponse")]
        [Validation(Required=false)]
        public DescribeEventOnStageResponseBodySecurityEventStageResponse SecurityEventStageResponse { get; set; }
        public class DescribeEventOnStageResponseBodySecurityEventStageResponse : TeaModel {
            /// <summary>
            /// <para>The platforms supported by threat detection.</para>
            /// <list type="bullet">
            /// <item><description><b>container</b>: container</description></item>
            /// <item><description><b>linux</b>: linux</description></item>
            /// <item><description><b>windows</b>: windows.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("SecurityEventOnStag")]
            [Validation(Required=false)]
            public Dictionary<string, object> SecurityEventOnStag { get; set; }

        }

    }

}
