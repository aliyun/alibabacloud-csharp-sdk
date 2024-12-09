// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class GenerateServicePolicyRequest : TeaModel {
        /// <summary>
        /// <para>The type of operation N for which you want to generate the policy information.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CreateServiceInstance: creates a serviceInstance by calling the CreateServiceInstance operation.</description></item>
        /// <item><description>UpdateServiceInstance: updates a serviceInstance by calling the UpdateServiceInstance operation.</description></item>
        /// <item><description>DeleteServiceInstance: deletes a serviceInstance by calling the DeleteServiceInstance operation.</description></item>
        /// </list>
        /// <remarks>
        /// <para> The default value is the combination of all valid values.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("OperationTypes")]
        [Validation(Required=false)]
        public List<string> OperationTypes { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The service ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>service-b3e9ed878b0c4xxxxxx</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The service version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>draft</para>
        /// </summary>
        [NameInMap("ServiceVersion")]
        [Validation(Required=false)]
        public string ServiceVersion { get; set; }

        /// <summary>
        /// <para>The name of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GPU-单机版</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The trial policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Trial: Trials are supported.</description></item>
        /// <item><description>NotTrial: Trials are not supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NotTrial</para>
        /// </summary>
        [NameInMap("TrialType")]
        [Validation(Required=false)]
        public string TrialType { get; set; }

    }

}
