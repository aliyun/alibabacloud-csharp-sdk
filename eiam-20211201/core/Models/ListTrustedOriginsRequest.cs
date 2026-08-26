// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListTrustedOriginsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the IDaaS EIAM instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_example</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20. Maximum value: 100. If you set this parameter to 0, the default value is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The NextToken returned by the previous call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NT_example</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Filters by the exact normalized origin.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://console.qoder.com">https://console.qoder.com</a></para>
        /// </summary>
        [NameInMap("Origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        /// <summary>
        /// <para>Filters by exact status. Valid values: Enabled or Disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Filters by exact name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Qoder Production Console</para>
        /// </summary>
        [NameInMap("TrustOriginName")]
        [Validation(Required=false)]
        public string TrustOriginName { get; set; }

        /// <summary>
        /// <para>Filters by exact trusted origin scene. You can specify at most one value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iframe_embed</para>
        /// </summary>
        [NameInMap("TrustedOriginScene")]
        [Validation(Required=false)]
        public List<string> TrustedOriginScene { get; set; }

    }

}
