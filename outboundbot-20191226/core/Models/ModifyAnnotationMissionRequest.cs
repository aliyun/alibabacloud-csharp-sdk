// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ModifyAnnotationMissionRequest : TeaModel {
        /// <summary>
        /// <para>Annotation task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c88cc004-de69-4eee-aa5f-2efed533a54e</para>
        /// </summary>
        [NameInMap("AnnotationMissionId")]
        [Validation(Required=false)]
        public string AnnotationMissionId { get; set; }

        /// <summary>
        /// <para>Annotation task name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>询问卖车-标注任务-20230506-112934</para>
        /// </summary>
        [NameInMap("AnnotationMissionName")]
        [Validation(Required=false)]
        public string AnnotationMissionName { get; set; }

        /// <summary>
        /// <para>Annotation task status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AnnotationStatus")]
        [Validation(Required=false)]
        public int? AnnotationStatus { get; set; }

        /// <summary>
        /// <para>Delete the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Delete")]
        [Validation(Required=false)]
        public bool? Delete { get; set; }

    }

}
