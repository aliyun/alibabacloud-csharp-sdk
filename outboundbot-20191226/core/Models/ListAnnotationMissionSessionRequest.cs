// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListAnnotationMissionSessionRequest : TeaModel {
        /// <summary>
        /// <para>The annotation mission ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8434a4b0-41fc-41b1-aa75-bbd1f2ab0c8d</para>
        /// </summary>
        [NameInMap("AnnotationMissionId")]
        [Validation(Required=false)]
        public string AnnotationMissionId { get; set; }

        /// <summary>
        /// <para>The annotation mission chat instance ID.</para>
        /// <remarks>
        /// <para>Obtained by calling the SaveAnnotationMissionSessionList operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8434a4b0-41fc-41b1-aa75-bbd1f2ab0c8d</para>
        /// </summary>
        [NameInMap("AnnotationMissionSessionId")]
        [Validation(Required=false)]
        public string AnnotationMissionSessionId { get; set; }

        /// <summary>
        /// <para>The environment.</para>
        /// <remarks>
        /// <para>Default value: 2.</para>
        /// </remarks>
        /// <para><b>Valid values:</b></para>
        /// <list type="bullet">
        /// <item><description>0: NONE.</description></item>
        /// <item><description>1: Private cloud.</description></item>
        /// <item><description>2: Public cloud.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Environment")]
        [Validation(Required=false)]
        public int? Environment { get; set; }

        /// <summary>
        /// <para>The list of included statuses.</para>
        /// <remarks>
        /// <para>The format is [1]. Specify the actual enum values in the array.</para>
        /// </remarks>
        /// <para><b>Valid values:</b></para>
        /// <list type="bullet">
        /// <item><description>1: Correct recognition.</description></item>
        /// <item><description>2: Incorrect recognition.</description></item>
        /// <item><description>8: Invalid data.</description></item>
        /// <item><description>4: Uncovered intent.</description></item>
        /// <item><description>16: Transcription misrecognition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[1]</para>
        /// </summary>
        [NameInMap("IncludeStatusListJsonString")]
        [Validation(Required=false)]
        public string IncludeStatusListJsonString { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
