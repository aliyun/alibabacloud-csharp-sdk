// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class UpdatePropertyResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result of the modification.</para>
        /// </summary>
        [NameInMap("UpdateResult")]
        [Validation(Required=false)]
        public UpdatePropertyResponseBodyUpdateResult UpdateResult { get; set; }
        public class UpdatePropertyResponseBodyUpdateResult : TeaModel {
            /// <summary>
            /// <para>The ID of the property.</para>
            /// 
            /// <b>Example:</b>
            /// <para>390</para>
            /// </summary>
            [NameInMap("PropertyId")]
            [Validation(Required=false)]
            public long? PropertyId { get; set; }

            /// <summary>
            /// <para>The name of the property.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testkey2</para>
            /// </summary>
            [NameInMap("PropertyKey")]
            [Validation(Required=false)]
            public string PropertyKey { get; set; }

            /// <summary>
            /// <para>The result of the property value modification.</para>
            /// </summary>
            [NameInMap("SavePropertyValueModel")]
            [Validation(Required=false)]
            public UpdatePropertyResponseBodyUpdateResultSavePropertyValueModel SavePropertyValueModel { get; set; }
            public class UpdatePropertyResponseBodyUpdateResultSavePropertyValueModel : TeaModel {
                /// <summary>
                /// <para>The property values that failed to be modified.</para>
                /// </summary>
                [NameInMap("FailedPropertyValues")]
                [Validation(Required=false)]
                public List<UpdatePropertyResponseBodyUpdateResultSavePropertyValueModelFailedPropertyValues> FailedPropertyValues { get; set; }
                public class UpdatePropertyResponseBodyUpdateResultSavePropertyValueModelFailedPropertyValues : TeaModel {
                    /// <summary>
                    /// <para>The error code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ExistedPropertyValue</para>
                    /// </summary>
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    /// <summary>
                    /// <para>The error message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The property value is used by another property.</para>
                    /// </summary>
                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    /// <summary>
                    /// <para>The ID of the property.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>390</para>
                    /// </summary>
                    [NameInMap("PropertyId")]
                    [Validation(Required=false)]
                    public long? PropertyId { get; set; }

                    /// <summary>
                    /// <para>The value of the property.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testvalue</para>
                    /// </summary>
                    [NameInMap("PropertyValue")]
                    [Validation(Required=false)]
                    public string PropertyValue { get; set; }

                }

                /// <summary>
                /// <para>The property values that were modified.</para>
                /// </summary>
                [NameInMap("SavePropertyValues")]
                [Validation(Required=false)]
                public List<UpdatePropertyResponseBodyUpdateResultSavePropertyValueModelSavePropertyValues> SavePropertyValues { get; set; }
                public class UpdatePropertyResponseBodyUpdateResultSavePropertyValueModelSavePropertyValues : TeaModel {
                    /// <summary>
                    /// <para>The value of the property.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testvalue2</para>
                    /// </summary>
                    [NameInMap("PropertyValue")]
                    [Validation(Required=false)]
                    public string PropertyValue { get; set; }

                    /// <summary>
                    /// <para>The ID of the property value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>978</para>
                    /// </summary>
                    [NameInMap("PropertyValueId")]
                    [Validation(Required=false)]
                    public long? PropertyValueId { get; set; }

                }

            }

        }

    }

}
