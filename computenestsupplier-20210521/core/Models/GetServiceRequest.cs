// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class GetServiceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to filter the results by Alibaba Cloud account ID.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Filters the results by Alibaba Cloud account ID.</para>
        /// </description></item>
        /// <item><description><para>false: Does not filter the results by Alibaba Cloud account ID.</para>
        /// </description></item>
        /// </list>
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
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/2264368.html">ListServices</a> operation to obtain the service ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>service-f8469d2d14eb40af****</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The service instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>si-56eb5823dxxxx</para>
        /// </summary>
        [NameInMap("ServiceInstanceId")]
        [Validation(Required=false)]
        public string ServiceInstanceId { get; set; }

        /// <summary>
        /// <para>The service name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WordPress Community Edition</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The service version.</para>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/2264368.html">ListServices</a> operation to obtain the service version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ServiceVersion")]
        [Validation(Required=false)]
        public string ServiceVersion { get; set; }

        /// <summary>
        /// <para>The service sharing type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>SharedAccount (default): common sharing.</para>
        /// </description></item>
        /// <item><description><para>Resell: distribution sharing.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SharedAccount</para>
        /// </summary>
        [NameInMap("SharedAccountType")]
        [Validation(Required=false)]
        public string SharedAccountType { get; set; }

        /// <summary>
        /// <para>The details to be returned.</para>
        /// </summary>
        [NameInMap("ShowDetail")]
        [Validation(Required=false)]
        public List<string> ShowDetail { get; set; }

    }

}
