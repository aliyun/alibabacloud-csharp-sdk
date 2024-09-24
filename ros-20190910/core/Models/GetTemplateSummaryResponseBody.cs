// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetTemplateSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The description of the stack template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>No description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The metadata that is defined in the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key&quot;: &quot;value&quot;}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public Dictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// <para>The declarations of the parameters in the template.</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Parameters { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B288A0BE-D927-4888-B0F7-B35EF84B6E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource identifier summaries.\
        /// A summary describes the resource that you want to import and the properties that are used to identify the resource during the import. For example, VpcId is an identifier property of ALIYUN::ECS::VPC.</para>
        /// </summary>
        [NameInMap("ResourceIdentifierSummaries")]
        [Validation(Required=false)]
        public List<GetTemplateSummaryResponseBodyResourceIdentifierSummaries> ResourceIdentifierSummaries { get; set; }
        public class GetTemplateSummaryResponseBodyResourceIdentifierSummaries : TeaModel {
            /// <summary>
            /// <para>The logical IDs of all resources of the type that is specified by ResouceType in the template.</para>
            /// </summary>
            [NameInMap("LogicalResourceIds")]
            [Validation(Required=false)]
            public List<string> LogicalResourceIds { get; set; }

            /// <summary>
            /// <para>The resource properties. You can use a resource property to identify the resource that you want to manage. For example, VpcId is an identifier property of ALIYUN::ECS::VPC.</para>
            /// </summary>
            [NameInMap("ResourceIdentifiers")]
            [Validation(Required=false)]
            public List<string> ResourceIdentifiers { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// <remarks>
            /// <para>The resource import feature is supported for the resource type.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN::ECS::VPC</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// <para>All resource types that are used in the template.</para>
        /// </summary>
        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public List<string> ResourceTypes { get; set; }

        /// <summary>
        /// <para>The version of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-09-01</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
