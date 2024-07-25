// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListSmartVoiceGroupsResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VoiceGroups")]
        [Validation(Required=false)]
        public List<ListSmartVoiceGroupsResponseBodyVoiceGroups> VoiceGroups { get; set; }
        public class ListSmartVoiceGroupsResponseBodyVoiceGroups : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("VoiceList")]
            [Validation(Required=false)]
            public List<ListSmartVoiceGroupsResponseBodyVoiceGroupsVoiceList> VoiceList { get; set; }
            public class ListSmartVoiceGroupsResponseBodyVoiceGroupsVoiceList : TeaModel {
                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                [NameInMap("Voice")]
                [Validation(Required=false)]
                public string Voice { get; set; }

                [NameInMap("VoiceType")]
                [Validation(Required=false)]
                public string VoiceType { get; set; }

                [NameInMap("VoiceUrl")]
                [Validation(Required=false)]
                public string VoiceUrl { get; set; }

            }

        }

    }

}
