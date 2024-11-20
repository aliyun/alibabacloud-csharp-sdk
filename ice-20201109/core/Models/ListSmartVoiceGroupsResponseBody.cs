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
        /// <para>The queried speaker groups.</para>
        /// </summary>
        [NameInMap("VoiceGroups")]
        [Validation(Required=false)]
        public List<ListSmartVoiceGroupsResponseBodyVoiceGroups> VoiceGroups { get; set; }
        public class ListSmartVoiceGroupsResponseBodyVoiceGroups : TeaModel {
            /// <summary>
            /// <para>The name of the speaker group.</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The speakers.</para>
            /// </summary>
            [NameInMap("VoiceList")]
            [Validation(Required=false)]
            public List<ListSmartVoiceGroupsResponseBodyVoiceGroupsVoiceList> VoiceList { get; set; }
            public class ListSmartVoiceGroupsResponseBodyVoiceGroupsVoiceList : TeaModel {
                /// <summary>
                /// <para>The speaker description.</para>
                /// </summary>
                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                /// <summary>
                /// <para>The speaker name.</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The remarks of the speaker.</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("SupportSampleRate")]
                [Validation(Required=false)]
                public string SupportSampleRate { get; set; }

                /// <summary>
                /// <para>The tag of the speaker type.</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// <para>The speaker ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zhitian</para>
                /// </summary>
                [NameInMap("Voice")]
                [Validation(Required=false)]
                public string Voice { get; set; }

                /// <summary>
                /// <para>The speaker type.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Male</description></item>
                /// <item><description>Female</description></item>
                /// <item><description>Boy</description></item>
                /// <item><description>Girl</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Female</para>
                /// </summary>
                [NameInMap("VoiceType")]
                [Validation(Required=false)]
                public string VoiceType { get; set; }

                /// <summary>
                /// <para>The URL of the sample audio file.</para>
                /// 
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
