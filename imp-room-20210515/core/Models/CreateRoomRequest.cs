// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp_room20210515.Models
{
    public class CreateRoomRequest : TeaModel {
        [NameInMap("Request")]
        [Validation(Required=false)]
        public CreateRoomRequestRequest Request { get; set; }
        public class CreateRoomRequestRequest : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }
            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }
            [NameInMap("RoomId")]
            [Validation(Required=false)]
            public string RoomId { get; set; }
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }
            [NameInMap("Notice")]
            [Validation(Required=false)]
            public string Notice { get; set; }
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }
            [NameInMap("Extension")]
            [Validation(Required=false)]
            public Dictionary<string, string> Extension { get; set; }
        };

    }

}
