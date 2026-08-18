// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class CreateSasTrialRequest : TeaModel {
        /// <summary>
        /// <para>The region ID of the access control instance. You can call the DescribeRegions operation to query the region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The Security Center SDK request.</para>
        /// </summary>
        [NameInMap("SdkRequest")]
        [Validation(Required=false)]
        public CreateSasTrialRequestSdkRequest SdkRequest { get; set; }
        public class CreateSasTrialRequestSdkRequest : TeaModel {
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
            /// <para>The language of the request and response. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>zh</b> (default): Chinese.</para>
            /// </description></item>
            /// <item><description><para><b>en</b>: English.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>en</para>
            /// </summary>
            [NameInMap("Lang")]
            [Validation(Required=false)]
            public string Lang { get; set; }

            /// <summary>
            /// <para>The reason for applying for the trial.</para>
            /// </summary>
            [NameInMap("RequestForm")]
            [Validation(Required=false)]
            public CreateSasTrialRequestSdkRequestRequestForm RequestForm { get; set; }
            public class CreateSasTrialRequestSdkRequestRequestForm : TeaModel {
                /// <summary>
                /// <para>The reason for applying for the trial.</para>
                /// 
                /// <b>Example:</b>
                /// <para>for poc</para>
                /// </summary>
                [NameInMap("TryReason")]
                [Validation(Required=false)]
                public string TryReason { get; set; }

            }

            /// <summary>
            /// <para>The trial type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: trial not allowed</description></item>
            /// <item><description><b>1</b>: first trial</description></item>
            /// <item><description><b>2</b>: second trial</description></item>
            /// </list>
            /// <remarks>
            /// <para>Call the <a href="https://help.aliyun.com/document_detail/2623574.html">GetCanTrySas</a> operation to obtain this parameter. The trial can be started only when the value is not 0.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TryType")]
            [Validation(Required=false)]
            public int? TryType { get; set; }

            /// <summary>
            /// <para>The trial edition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>3</b>: Enterprise Edition.</description></item>
            /// <item><description><b>7</b>: Ultimate Edition.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Call the <a href="https://help.aliyun.com/document_detail/2623574.html">GetCanTrySas</a> operation to obtain this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TryVersion")]
            [Validation(Required=false)]
            public int? TryVersion { get; set; }

        }

    }

}
