// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class GetServiceTemplateParameterConstraintsRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. Generate a unique value from your client for each request. The token can contain only ASCII characters and cannot be more than 64 characters long.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The deployment region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DeployRegionId")]
        [Validation(Required=false)]
        public string DeployRegionId { get; set; }

        /// <summary>
        /// <para>Indicates whether PrivateLink is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: enabled</para>
        /// </description></item>
        /// <item><description><para>false: disabled</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnablePrivateVpcConnection")]
        [Validation(Required=false)]
        public bool? EnablePrivateVpcConnection { get; set; }

        /// <summary>
        /// <para>The configuration parameters of the service instance.</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<GetServiceTemplateParameterConstraintsRequestParameters> Parameters { get; set; }
        public class GetServiceTemplateParameterConstraintsRequestParameters : TeaModel {
            /// <summary>
            /// <para>The name of the parameter. If you do not specify the name and value of the parameter, Resource Orchestration Service (ROS) uses the default value that is specified in the template.</para>
            /// <remarks>
            /// <para>The Parameters parameter is optional. If you specify Parameters, ParameterKey is required.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>InstanceType</para>
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// <para>The value of the parameter that is defined in the template.</para>
            /// <remarks>
            /// <para>The Parameters parameter is optional. If you specify Parameters, ParameterValue is required.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-j</para>
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

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
        /// <para>service-731f788406024axxxxxx</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The service instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>si-461ee95f46ca46xxxxxx</para>
        /// </summary>
        [NameInMap("ServiceInstanceId")]
        [Validation(Required=false)]
        public string ServiceInstanceId { get; set; }

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
        /// <para>The specification name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Package 1</para>
        /// </summary>
        [NameInMap("SpecificationName")]
        [Validation(Required=false)]
        public string SpecificationName { get; set; }

        /// <summary>
        /// <para>The template name.</para>
        /// <para>This parameter is required.</para>
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
        /// <item><description><para>Trial: The service supports a trial.</para>
        /// </description></item>
        /// <item><description><para>NotTrial: The service does not support a trial.</para>
        /// </description></item>
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
