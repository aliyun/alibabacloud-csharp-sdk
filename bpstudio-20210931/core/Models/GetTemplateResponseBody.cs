// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BPStudio20210931.Models
{
    public class GetTemplateResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The details of the template.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTemplateResponseBodyData Data { get; set; }
        public class GetTemplateResponseBodyData : TeaModel {
            /// <summary>
            /// The time when the template was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// Template DescriptionD
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The path to the template schema image file
            /// </summary>
            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public string ImageURL { get; set; }

            /// <summary>
            /// The name of the template
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The ID of the resource group.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// Template ID
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// The details of the template variables.
            /// </summary>
            [NameInMap("Variables")]
            [Validation(Required=false)]
            public List<GetTemplateResponseBodyDataVariables> Variables { get; set; }
            public class GetTemplateResponseBodyDataVariables : TeaModel {
                /// <summary>
                /// The name of the variable.
                /// </summary>
                [NameInMap("Attribute")]
                [Validation(Required=false)]
                public string Attribute { get; set; }

                /// <summary>
                /// The type of the variable.
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                /// <summary>
                /// The default value of the variable.
                /// </summary>
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                /// <summary>
                /// The value of the variable.
                /// </summary>
                [NameInMap("Variable")]
                [Validation(Required=false)]
                public string Variable { get; set; }

            }

        }

        /// <summary>
        /// The interface returns information
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Request ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
