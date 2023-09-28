// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class CreateTemplateRequest : TeaModel {
        /// <summary>
        /// The content of the template.
        /// 
        /// For more information about the template syntax, see [Structure of Terraform templates](~~184397~~).
        /// </summary>
        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// The type of the template.
        /// 
        /// Set the value to RosTerraformTemplate, which specifies the Terraform template that is supported by Resource Orchestration Service (ROS).
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

        /// <summary>
        /// The variable settings of the Terraform template. You can configure the variables in a structured manner. Service Catalog applies the variable settings to the template.
        /// 
        /// > The variables must be defined in the Terraform template.
        /// </summary>
        [NameInMap("TerraformVariables")]
        [Validation(Required=false)]
        public List<CreateTemplateRequestTerraformVariables> TerraformVariables { get; set; }
        public class CreateTemplateRequestTerraformVariables : TeaModel {
            /// <summary>
            /// The description of the variable.
            /// 
            /// For more information about the format of variable descriptions, see [Methods and suggestions for Terraform code development](~~322216~~).
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The name of the variable.
            /// </summary>
            [NameInMap("VariableName")]
            [Validation(Required=false)]
            public string VariableName { get; set; }

        }

    }

}
