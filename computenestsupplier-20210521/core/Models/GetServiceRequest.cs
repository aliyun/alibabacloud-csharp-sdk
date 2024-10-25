// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class GetServiceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to filter information based on Alibaba Cloud account IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("FilterAliUid")]
        [Validation(Required=false)]
        public bool? FilterAliUid { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The service ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>service-4ee86df83fd948******</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        [NameInMap("ServiceInstanceId")]
        [Validation(Required=false)]
        public string ServiceInstanceId { get; set; }

        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The service version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ServiceVersion")]
        [Validation(Required=false)]
        public string ServiceVersion { get; set; }

        /// <summary>
        /// <para>The share type of the service. Default value: SharedAccount. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SharedAccount: The service is shared by multiple accounts.</description></item>
        /// <item><description>Resell: The service is distributed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SharedAccount</para>
        /// </summary>
        [NameInMap("SharedAccountType")]
        [Validation(Required=false)]
        public string SharedAccountType { get; set; }

        /// <summary>
        /// <para>The information that you want to query.</para>
        /// </summary>
        [NameInMap("ShowDetail")]
        [Validation(Required=false)]
        public List<string> ShowDetail { get; set; }

    }

}
