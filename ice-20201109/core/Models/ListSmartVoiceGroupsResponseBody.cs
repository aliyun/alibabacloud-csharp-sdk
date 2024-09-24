// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListSmartVoiceGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
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

                [NameInMap("SupportSampleRate")]
                [Validation(Required=false)]
                public string SupportSampleRate { get; set; }

                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>zhitian</para>
                /// </summary>
                [NameInMap("Voice")]
                [Validation(Required=false)]
                public string Voice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Female</para>
                /// </summary>
                [NameInMap("VoiceType")]
                [Validation(Required=false)]
                public string VoiceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>https://***.com/zhiqing.mp3</para>
                /// </summary>
                [NameInMap("VoiceUrl")]
                [Validation(Required=false)]
                public string VoiceUrl { get; set; }

            }

        }

    }

}
