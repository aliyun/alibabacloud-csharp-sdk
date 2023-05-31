// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeModuleConfigResponseBody : TeaModel {
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("ModuleConfigList")]
        [Validation(Required=false)]
        public List<DescribeModuleConfigResponseBodyModuleConfigList> ModuleConfigList { get; set; }
        public class DescribeModuleConfigResponseBodyModuleConfigList : TeaModel {
            [NameInMap("ConfigName")]
            [Validation(Required=false)]
            public string ConfigName { get; set; }

            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeModuleConfigResponseBodyModuleConfigListItems> Items { get; set; }
            public class DescribeModuleConfigResponseBodyModuleConfigListItems : TeaModel {
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public int? GroupId { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            [NameInMap("ModuleName")]
            [Validation(Required=false)]
            public string ModuleName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
