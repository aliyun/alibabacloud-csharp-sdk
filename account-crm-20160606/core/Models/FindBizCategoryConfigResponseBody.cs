// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class FindBizCategoryConfigResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public FindBizCategoryConfigResponseBodyData Data { get; set; }
        public class FindBizCategoryConfigResponseBodyData : TeaModel {
            [NameInMap("BizCategory")]
            [Validation(Required=false)]
            public List<FindBizCategoryConfigResponseBodyDataBizCategory> BizCategory { get; set; }
            public class FindBizCategoryConfigResponseBodyDataBizCategory : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("IsCheck")]
                [Validation(Required=false)]
                public bool? IsCheck { get; set; }

                [NameInMap("MainBiz")]
                [Validation(Required=false)]
                public bool? MainBiz { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Other")]
                [Validation(Required=false)]
                public string Other { get; set; }

                [NameInMap("SubConfigs")]
                [Validation(Required=false)]
                public FindBizCategoryConfigResponseBodyDataBizCategorySubConfigs SubConfigs { get; set; }
                public class FindBizCategoryConfigResponseBodyDataBizCategorySubConfigs : TeaModel {
                    [NameInMap("BizSubCategory")]
                    [Validation(Required=false)]
                    public List<FindBizCategoryConfigResponseBodyDataBizCategorySubConfigsBizSubCategory> BizSubCategory { get; set; }
                    public class FindBizCategoryConfigResponseBodyDataBizCategorySubConfigsBizSubCategory : TeaModel {
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        [NameInMap("IsCheck")]
                        [Validation(Required=false)]
                        public bool? IsCheck { get; set; }

                        [NameInMap("MainBiz")]
                        [Validation(Required=false)]
                        public bool? MainBiz { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("Other")]
                        [Validation(Required=false)]
                        public string Other { get; set; }

                    }

                }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
