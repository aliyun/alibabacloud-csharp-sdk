// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class DescribeInstanceResponseBody : TeaModel {
        [NameInMap("Avatar")]
        [Validation(Required=false)]
        public string Avatar { get; set; }

        [NameInMap("Categories")]
        [Validation(Required=false)]
        public List<DescribeInstanceResponseBodyCategories> Categories { get; set; }
        public class DescribeInstanceResponseBodyCategories : TeaModel {
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public long? CategoryId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ParentCategoryId")]
            [Validation(Required=false)]
            public long? ParentCategoryId { get; set; }

        }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("EditStatus")]
        [Validation(Required=false)]
        public string EditStatus { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Introduction")]
        [Validation(Required=false)]
        public string Introduction { get; set; }

        [NameInMap("LanguageCode")]
        [Validation(Required=false)]
        public string LanguageCode { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RobotType")]
        [Validation(Required=false)]
        public string RobotType { get; set; }

        [NameInMap("TimeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

    }

}
