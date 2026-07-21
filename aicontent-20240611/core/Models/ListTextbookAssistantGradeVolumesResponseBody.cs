// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ListTextbookAssistantGradeVolumesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListTextbookAssistantGradeVolumesResponseBodyData> Data { get; set; }
        public class ListTextbookAssistantGradeVolumesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The grade and volume information.</para>
            /// </summary>
            [NameInMap("gradeVolumes")]
            [Validation(Required=false)]
            public List<ListTextbookAssistantGradeVolumesResponseBodyDataGradeVolumes> GradeVolumes { get; set; }
            public class ListTextbookAssistantGradeVolumesResponseBodyDataGradeVolumes : TeaModel {
                /// <summary>
                /// <para>The grade level. Valid values: 1 to 9.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("grade")]
                [Validation(Required=false)]
                public string Grade { get; set; }

                /// <summary>
                /// <para>The volume. Valid values: <c>0</c> (single volume), <c>1</c> (Volume 1), and <c>2</c> (Volume 2).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("volume")]
                [Validation(Required=false)]
                public string Volume { get; set; }

            }

            /// <summary>
            /// <para>The version of the textbook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>人教版</para>
            /// </summary>
            [NameInMap("textbookVersion")]
            [Validation(Required=false)]
            public string TextbookVersion { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>未知错误</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F3B1AAF2-3041-5AA7-A352-BD5F998FA465</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
