// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ListTextbookAssistantGradeVolumesResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListTextbookAssistantGradeVolumesResponseBodyData> Data { get; set; }
        public class ListTextbookAssistantGradeVolumesResponseBodyData : TeaModel {
            [NameInMap("gradeVolumes")]
            [Validation(Required=false)]
            public List<ListTextbookAssistantGradeVolumesResponseBodyDataGradeVolumes> GradeVolumes { get; set; }
            public class ListTextbookAssistantGradeVolumesResponseBodyDataGradeVolumes : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("grade")]
                [Validation(Required=false)]
                public string Grade { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("volume")]
                [Validation(Required=false)]
                public string Volume { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>人教版</para>
            /// </summary>
            [NameInMap("textbookVersion")]
            [Validation(Required=false)]
            public string TextbookVersion { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>F3B1AAF2-3041-5AA7-A352-BD5F998FA465</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
