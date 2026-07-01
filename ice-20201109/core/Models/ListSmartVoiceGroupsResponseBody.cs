// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListSmartVoiceGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>627B30EB-1D0A-5C6D-8467-431626E0FA10</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array of voice groups.</para>
        /// </summary>
        [NameInMap("VoiceGroups")]
        [Validation(Required=false)]
        public List<ListSmartVoiceGroupsResponseBodyVoiceGroups> VoiceGroups { get; set; }
        public class ListSmartVoiceGroupsResponseBodyVoiceGroups : TeaModel {
            /// <summary>
            /// <para>The name of the voice group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ultra HD</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The voice list.</para>
            /// </summary>
            [NameInMap("VoiceList")]
            [Validation(Required=false)]
            public List<ListSmartVoiceGroupsResponseBodyVoiceGroupsVoiceList> VoiceList { get; set; }
            public class ListSmartVoiceGroupsResponseBodyVoiceGroupsVoiceList : TeaModel {
                /// <summary>
                /// <para>The description of the voice.</para>
                /// 
                /// <b>Example:</b>
                /// <para>甜美女声</para>
                /// </summary>
                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                /// <summary>
                /// <para>The name of the voice.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Zhi Tian</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Notes for the voice.</para>
                /// 
                /// <b>Example:</b>
                /// <para>中文及中英文混合场景</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>The sample rates supported by the voice.</para>
                /// 
                /// <b>Example:</b>
                /// <para>48000</para>
                /// </summary>
                [NameInMap("SupportSampleRate")]
                [Validation(Required=false)]
                public string SupportSampleRate { get; set; }

                /// <summary>
                /// <para>The tag for the voice category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>General scenario</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// <para>The voice ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zhitian</para>
                /// </summary>
                [NameInMap("Voice")]
                [Validation(Required=false)]
                public string Voice { get; set; }

                [NameInMap("VoiceSource")]
                [Validation(Required=false)]
                public string VoiceSource { get; set; }

                /// <summary>
                /// <para>The voice type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Female</para>
                /// </summary>
                [NameInMap("VoiceType")]
                [Validation(Required=false)]
                public string VoiceType { get; set; }

                /// <summary>
                /// <para>The URL of the sample audio.</para>
                /// 
                /// <b>Example:</b>
                /// <para>https://***.com/zhitian.mp3</para>
                /// </summary>
                [NameInMap("VoiceUrl")]
                [Validation(Required=false)]
                public string VoiceUrl { get; set; }

            }

        }

    }

}
