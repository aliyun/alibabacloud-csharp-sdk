// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class UpdateStackTemplateByResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The template content after correction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;ROSTemplateFormatVersion\&quot;: \&quot;2015-09-01\&quot;, \&quot;Resources\&quot;: {\&quot;Vpc\&quot;: {\&quot;Type\&quot;: \&quot;ALIYUN::ECS::VPC\&quot;, \&quot;Properties\&quot;: {\&quot;VpcName\&quot;: \&quot;test\&quot;, \&quot;CidrBlock\&quot;: \&quot;192.168.0.0/16\&quot;, \&quot;Description\&quot;: \&quot;test2\&quot;}}}, \&quot;Outputs\&quot;: {\&quot;VpcId\&quot;: {\&quot;Value\&quot;: {\&quot;Fn::GetAtt\&quot;: [\&quot;Vpc\&quot;, \&quot;VpcId\&quot;]}}}}</para>
        /// </summary>
        [NameInMap("NewTemplateBody")]
        [Validation(Required=false)]
        public string NewTemplateBody { get; set; }

        /// <summary>
        /// <para>The template content before correction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;ROSTemplateFormatVersion\&quot;: \&quot;2015-09-01\&quot;, \&quot;Resources\&quot;: {\&quot;Vpc\&quot;: {\&quot;Type\&quot;: \&quot;ALIYUN::ECS::VPC\&quot;, \&quot;Properties\&quot;: {\&quot;VpcName\&quot;: \&quot;test\&quot;, \&quot;CidrBlock\&quot;: \&quot;192.168.0.0/16\&quot;, \&quot;Description\&quot;: \&quot;test1\&quot;}}}, \&quot;Outputs\&quot;: {\&quot;VpcId\&quot;: {\&quot;Value\&quot;: {\&quot;Fn::GetAtt\&quot;: [\&quot;Vpc\&quot;, \&quot;VpcId\&quot;]}}}}</para>
        /// </summary>
        [NameInMap("OldTemplateBody")]
        [Validation(Required=false)]
        public string OldTemplateBody { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B288A0BE-D927-4888-B0F7-B35EF84B6E6F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
