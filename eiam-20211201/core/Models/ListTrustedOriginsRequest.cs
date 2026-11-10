// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListTrustedOriginsRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_example</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The maximum number of results per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NT_example</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The origin filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://console.qoder.com">https://console.qoder.com</a></para>
        /// </summary>
        [NameInMap("Origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        /// <summary>
        /// <para>The status filter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled: Enabled.</description></item>
        /// <item><description>Disabled: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The name filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Qoder Production Console</para>
        /// </summary>
        [NameInMap("TrustOriginName")]
        [Validation(Required=false)]
        public string TrustOriginName { get; set; }

        /// <summary>
        /// <para>The trusted origin scene filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iframe_embed</para>
        /// </summary>
        [NameInMap("TrustedOriginScene")]
        [Validation(Required=false)]
        public List<string> TrustedOriginScene { get; set; }

    }

}
