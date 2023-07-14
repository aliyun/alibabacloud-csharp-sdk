// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateRetcodeAppResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RetcodeAppDataBean")]
        [Validation(Required=false)]
        public CreateRetcodeAppResponseBodyRetcodeAppDataBean RetcodeAppDataBean { get; set; }
        public class CreateRetcodeAppResponseBodyRetcodeAppDataBean : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public long? AppId { get; set; }

            [NameInMap("Pid")]
            [Validation(Required=false)]
            public string Pid { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public CreateRetcodeAppResponseBodyRetcodeAppDataBeanTags Tags { get; set; }
            public class CreateRetcodeAppResponseBodyRetcodeAppDataBeanTags : TeaModel {
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<CreateRetcodeAppResponseBodyRetcodeAppDataBeanTagsTags> Tags { get; set; }
                public class CreateRetcodeAppResponseBodyRetcodeAppDataBeanTagsTags : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

        }

    }

}
