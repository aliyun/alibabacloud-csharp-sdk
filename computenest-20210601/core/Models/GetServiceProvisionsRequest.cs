// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class GetServiceProvisionsRequest : TeaModel {
        /// <summary>
        /// <para>The parameters for deploying the user instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;RegionId\&quot;:\&quot;cn-hangzhou\&quot;,\&quot;ZoneId\&quot;:\&quot;cn-hangzhou-g\&quot;,\&quot;EcsInstanceType\&quot;:\&quot;ecs.g5.large\&quot;,\&quot;InstancePassword\&quot;:\&quot;xxxxxxxx\&quot;,\&quot;PayType\&quot;:\&quot;PostPaid\&quot;,\&quot;PayPeriodUnit\&quot;:\&quot;Month\&quot;,\&quot;PayPeriod\&quot;:1}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>service-0efc0db451794bxxxxxx</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

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
        /// <para>The template name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Template 1</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The usage type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Trial: The service supports trial use.</para>
        /// </description></item>
        /// <item><description><para>NotTrial: The service does not support trial use.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Trial</para>
        /// </summary>
        [NameInMap("TrialType")]
        [Validation(Required=false)]
        public string TrialType { get; set; }

    }

}
