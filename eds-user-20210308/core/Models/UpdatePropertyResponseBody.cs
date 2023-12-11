// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class UpdatePropertyResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The result of the modification.
        /// </summary>
        [NameInMap("UpdateResult")]
        [Validation(Required=false)]
        public UpdatePropertyResponseBodyUpdateResult UpdateResult { get; set; }
        public class UpdatePropertyResponseBodyUpdateResult : TeaModel {
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
            /// The result of the property value modification.
            /// </summary>
            [NameInMap("SavePropertyValueModel")]
            [Validation(Required=false)]
            public UpdatePropertyResponseBodyUpdateResultSavePropertyValueModel SavePropertyValueModel { get; set; }
            public class UpdatePropertyResponseBodyUpdateResultSavePropertyValueModel : TeaModel {
                /// <summary>
                /// The property values that failed to be modified.
                /// </summary>
                [NameInMap("FailedPropertyValues")]
                [Validation(Required=false)]
                public List<UpdatePropertyResponseBodyUpdateResultSavePropertyValueModelFailedPropertyValues> FailedPropertyValues { get; set; }
                public class UpdatePropertyResponseBodyUpdateResultSavePropertyValueModelFailedPropertyValues : TeaModel {
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
                    /// The ID of the property.
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
                /// The property values that were modified.
                /// </summary>
                [NameInMap("SavePropertyValues")]
                [Validation(Required=false)]
                public List<UpdatePropertyResponseBodyUpdateResultSavePropertyValueModelSavePropertyValues> SavePropertyValues { get; set; }
                public class UpdatePropertyResponseBodyUpdateResultSavePropertyValueModelSavePropertyValues : TeaModel {
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

    }

}
