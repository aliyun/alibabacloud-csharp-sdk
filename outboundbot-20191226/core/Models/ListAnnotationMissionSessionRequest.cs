// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListAnnotationMissionSessionRequest : TeaModel {
        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8434a4b0-41fc-41b1-aa75-bbd1f2ab0c8d</para>
        /// </summary>
        [NameInMap("AnnotationMissionId")]
        [Validation(Required=false)]
        public string AnnotationMissionId { get; set; }

        /// <summary>
        /// <para>The ID of the chat instance for the annotation task.</para>
        /// <remarks>
        /// <para>Obtain this ID by calling the SaveAnnotationMissionSessionList operation.</para>
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
        /// <para>The default value is 2.</para>
        /// </remarks>
        /// <para><b>Enumeration values</b></para>
        /// <list type="bullet">
        /// <item><description><para>0: NONE</para>
        /// </description></item>
        /// <item><description><para>1: Private cloud</para>
        /// </description></item>
        /// <item><description><para>2: Public cloud</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Environment")]
        [Validation(Required=false)]
        public int? Environment { get; set; }

        /// <summary>
        /// <para>The list of statuses to include.</para>
        /// <remarks>
        /// <para>The format is [1]. Fill the array with specific enumeration values.</para>
        /// </remarks>
        /// <para><b>Enumeration values</b></para>
        /// <list type="bullet">
        /// <item><description><para>1: Correctly detected</para>
        /// </description></item>
        /// <item><description><para>2: Incorrectly detected</para>
        /// </description></item>
        /// <item><description><para>8: Invalid data</para>
        /// </description></item>
        /// <item><description><para>4: Uncovered intent</para>
        /// </description></item>
        /// <item><description><para>16: Transcription error</para>
        /// </description></item>
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
        /// <para>The number of records to display on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
