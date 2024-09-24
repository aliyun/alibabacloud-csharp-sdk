// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GenerateTemplateByScratchResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D22C1D13-D74E-558C-AF68-1B4C05FA6F1A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resources that you want to import into a stack in the resource management scenario.</para>
        /// <remarks>
        /// <para>This parameter is returned only for a resource management scenario.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ResourcesToImport")]
        [Validation(Required=false)]
        public List<GenerateTemplateByScratchResponseBodyResourcesToImport> ResourcesToImport { get; set; }
        public class GenerateTemplateByScratchResponseBodyResourcesToImport : TeaModel {
            /// <summary>
            /// <para>The logical ID of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECSVPC_001</para>
            /// </summary>
            [NameInMap("LogicalResourceId")]
            [Validation(Required=false)]
            public string LogicalResourceId { get; set; }

            /// <summary>
            /// <para>The key-value mapping between strings. The value is a JSON string that identifies the resource that you want to import into a stack.\
            /// A key is an identifier for a resource, and a value is an assignment of data to the key. For example, VpcId is a key that indicates the ID of a virtual private cloud (VPC), and <c>vpc-bp1m6fww66xbntjyc****&quot;</c> is a value that is assigned to VpcId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;VpcId&quot;: &quot;vpc-bp1m6fww66xbntjyc****&quot; }</para>
            /// </summary>
            [NameInMap("ResourceIdentifier")]
            [Validation(Required=false)]
            public Dictionary<string, object> ResourceIdentifier { get; set; }

            /// <summary>
            /// <para>The type of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN::ECS::VPC</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// <para>The template content of the resource scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;ROSTemplateFormatVersion\&quot;: \&quot;2015-09-01\&quot;, \&quot;Resources\&quot;: {\&quot;ECSVPC_001\&quot;: {\&quot;DeletionPolicy\&quot;: \&quot;Retain\&quot;, \&quot;Type\&quot;: \&quot;ALIYUN::ECS::VPC\&quot;, \&quot;Properties\&quot;: {\&quot;CidrBlock\&quot;: \&quot;172.16.0.0/12\&quot;, \&quot;VpcName\&quot;: \&quot;MyTestVpc\&quot;, \&quot;EnableIpv6\&quot;: false}}}}</para>
        /// </summary>
        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

    }

}
