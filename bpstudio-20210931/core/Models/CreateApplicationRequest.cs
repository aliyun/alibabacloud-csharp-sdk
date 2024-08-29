// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BPStudio20210931.Models
{
    public class CreateApplicationRequest : TeaModel {
        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("AreaId")]
        [Validation(Required=false)]
        public string AreaId { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The parameters that are used to configure the application you want to create. For example, enableMonitor specifies whether to automatically create a CloudMonitor task for the application, and enableReport specifies whether to generate reports.
        /// </summary>
        [NameInMap("Configuration")]
        [Validation(Required=false)]
        public Dictionary<string, string> Configuration { get; set; }

        /// <summary>
        /// The instances in which you want to create the application. You can create applications in an existing virtual private cloud (VPC).
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<CreateApplicationRequestInstances> Instances { get; set; }
        public class CreateApplicationRequestInstances : TeaModel {
            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The name of the instance.
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// The type of the instance.
            /// </summary>
            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

        }

        /// <summary>
        /// The name of the application.
        /// 
        /// *   The application name must be unique. You can call the [ListApplication](https://www.alibabacloud.com/help/en/bp-studio/latest/api-bpstudio-2021-09-31-listapplication) operation to query the existing applications.
        /// *   The application name must be 2 to 128 characters in length. The name must start with a letter and cannot start with `http:// or https://`. The name can contain letters, digits, underscores (_), and hyphens (-).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the resource group to which the application you want to create belongs.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The ID of the template.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// The parameter values that are contained in the template. If the template contains no parameter values, the default values are used.
        /// </summary>
        [NameInMap("Variables")]
        [Validation(Required=false)]
        public Dictionary<string, object> Variables { get; set; }

    }

}
