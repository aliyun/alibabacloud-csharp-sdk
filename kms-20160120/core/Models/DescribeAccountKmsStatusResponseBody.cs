// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class DescribeAccountKmsStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The status of KMS within your Alibaba cloud account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Enabled: KMS is enabled.</para>
        /// </description></item>
        /// <item><description><para>NotEnabled: KMS is disabled.</para>
        /// </description></item>
        /// <item><description><para>InDebt: Your account is overdue, and KMS stops providing services.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If your Alibaba Cloud account is overdue, top up your account at the earliest opportunity to avoid impacts on your services.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Suspended: KMS is suspended.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("AccountStatus")]
        [Validation(Required=false)]
        public string AccountStatus { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3ac84333-d64d-4784-a8bc-997834a7ac6c</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
