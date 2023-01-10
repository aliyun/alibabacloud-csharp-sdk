// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eais20190624.Models
{
    public class CreateEaiEciRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("EaisName")]
        [Validation(Required=false)]
        public string EaisName { get; set; }

        [NameInMap("EaisType")]
        [Validation(Required=false)]
        public string EaisType { get; set; }

        [NameInMap("Eci")]
        [Validation(Required=false)]
        public CreateEaiEciRequestEci Eci { get; set; }
        public class CreateEaiEciRequestEci : TeaModel {
            [NameInMap("Container")]
            [Validation(Required=false)]
            public CreateEaiEciRequestEciContainer Container { get; set; }
            public class CreateEaiEciRequestEciContainer : TeaModel {
                [NameInMap("Arg")]
                [Validation(Required=false)]
                public string Arg { get; set; }

                [NameInMap("Command")]
                [Validation(Required=false)]
                public string Command { get; set; }

                [NameInMap("Image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Volumes")]
                [Validation(Required=false)]
                public string Volumes { get; set; }

            }

            [NameInMap("EipId")]
            [Validation(Required=false)]
            public string EipId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Volume")]
            [Validation(Required=false)]
            public string Volume { get; set; }

        }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
