// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class GetCanTrySasRequest : TeaModel {
        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-guangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The Security Center SDK request parameters.</para>
        /// </summary>
        [NameInMap("SdkRequest")]
        [Validation(Required=false)]
        public GetCanTrySasRequestSdkRequest SdkRequest { get; set; }
        public class GetCanTrySasRequestSdkRequest : TeaModel {
            /// <summary>
            /// <para>Specifies whether the request is from the ECS console. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The request is from the ECS console.</description></item>
            /// <item><description><b>false</b>: The request is not from the ECS console.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("FromEcs")]
            [Validation(Required=false)]
            public bool? FromEcs { get; set; }

            /// <summary>
            /// <para>The language type for the request and response messages. Default value: zh. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>zh</b>: Chinese</description></item>
            /// <item><description><b>en</b>: English</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>zh</para>
            /// </summary>
            [NameInMap("Lang")]
            [Validation(Required=false)]
            public string Lang { get; set; }

        }

    }

}
