// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class CreatePropertyResponseBody : TeaModel {
        [NameInMap("CreateResult")]
        [Validation(Required=false)]
        public CreatePropertyResponseBodyCreateResult CreateResult { get; set; }
        public class CreatePropertyResponseBodyCreateResult : TeaModel {
            [NameInMap("PropertyId")]
            [Validation(Required=false)]
            public long? PropertyId { get; set; }

            [NameInMap("PropertyKey")]
            [Validation(Required=false)]
            public string PropertyKey { get; set; }

            [NameInMap("SavePropertyValueModel")]
            [Validation(Required=false)]
            public CreatePropertyResponseBodyCreateResultSavePropertyValueModel SavePropertyValueModel { get; set; }
            public class CreatePropertyResponseBodyCreateResultSavePropertyValueModel : TeaModel {
                [NameInMap("FailedPropertyValues")]
                [Validation(Required=false)]
                public List<CreatePropertyResponseBodyCreateResultSavePropertyValueModelFailedPropertyValues> FailedPropertyValues { get; set; }
                public class CreatePropertyResponseBodyCreateResultSavePropertyValueModelFailedPropertyValues : TeaModel {
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    [NameInMap("PropertyId")]
                    [Validation(Required=false)]
                    public long? PropertyId { get; set; }

                    [NameInMap("PropertyValue")]
                    [Validation(Required=false)]
                    public string PropertyValue { get; set; }

                }

                [NameInMap("SavePropertyValues")]
                [Validation(Required=false)]
                public List<CreatePropertyResponseBodyCreateResultSavePropertyValueModelSavePropertyValues> SavePropertyValues { get; set; }
                public class CreatePropertyResponseBodyCreateResultSavePropertyValueModelSavePropertyValues : TeaModel {
                    [NameInMap("PropertyValue")]
                    [Validation(Required=false)]
                    public string PropertyValue { get; set; }

                    [NameInMap("PropertyValueId")]
                    [Validation(Required=false)]
                    public long? PropertyValueId { get; set; }

                }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
