// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class CreatePropertyResponseBody : TeaModel {
        /// <summary>
        /// The result of creating the property.
        /// </summary>
        [NameInMap("CreateResult")]
        [Validation(Required=false)]
        public CreatePropertyResponseBodyCreateResult CreateResult { get; set; }
        public class CreatePropertyResponseBodyCreateResult : TeaModel {
            /// <summary>
            /// The ID of the property.
            /// </summary>
            [NameInMap("PropertyId")]
            [Validation(Required=false)]
            public long? PropertyId { get; set; }

            /// <summary>
            /// The name of the property.
            /// </summary>
            [NameInMap("PropertyKey")]
            [Validation(Required=false)]
            public string PropertyKey { get; set; }

            /// <summary>
            /// The result of creating the property value.
            /// </summary>
            [NameInMap("SavePropertyValueModel")]
            [Validation(Required=false)]
            public CreatePropertyResponseBodyCreateResultSavePropertyValueModel SavePropertyValueModel { get; set; }
            public class CreatePropertyResponseBodyCreateResultSavePropertyValueModel : TeaModel {
                /// <summary>
                /// The property values that failed to be created.
                /// </summary>
                [NameInMap("FailedPropertyValues")]
                [Validation(Required=false)]
                public List<CreatePropertyResponseBodyCreateResultSavePropertyValueModelFailedPropertyValues> FailedPropertyValues { get; set; }
                public class CreatePropertyResponseBodyCreateResultSavePropertyValueModelFailedPropertyValues : TeaModel {
                    /// <summary>
                    /// The error code.
                    /// </summary>
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    /// <summary>
                    /// The error message.
                    /// </summary>
                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    /// <summary>
                    /// The ID of the property value.
                    /// </summary>
                    [NameInMap("PropertyId")]
                    [Validation(Required=false)]
                    public long? PropertyId { get; set; }

                    /// <summary>
                    /// The value of the property.
                    /// </summary>
                    [NameInMap("PropertyValue")]
                    [Validation(Required=false)]
                    public string PropertyValue { get; set; }

                }

                /// <summary>
                /// Details of the property values that were created.
                /// </summary>
                [NameInMap("SavePropertyValues")]
                [Validation(Required=false)]
                public List<CreatePropertyResponseBodyCreateResultSavePropertyValueModelSavePropertyValues> SavePropertyValues { get; set; }
                public class CreatePropertyResponseBodyCreateResultSavePropertyValueModelSavePropertyValues : TeaModel {
                    /// <summary>
                    /// The value of the property.
                    /// </summary>
                    [NameInMap("PropertyValue")]
                    [Validation(Required=false)]
                    public string PropertyValue { get; set; }

                    /// <summary>
                    /// The ID of the property value.
                    /// </summary>
                    [NameInMap("PropertyValueId")]
                    [Validation(Required=false)]
                    public long? PropertyValueId { get; set; }

                }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
