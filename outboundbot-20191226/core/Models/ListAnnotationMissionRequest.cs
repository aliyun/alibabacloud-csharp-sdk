// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListAnnotationMissionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0943abcb-bd7d-4ace-8cf7-97d39d4dd0b9</para>
        /// </summary>
        [NameInMap("AnnotationMissionId")]
        [Validation(Required=false)]
        public string AnnotationMissionId { get; set; }

        [NameInMap("AnnotationMissionName")]
        [Validation(Required=false)]
        public string AnnotationMissionName { get; set; }

        [NameInMap("AnnotationStatusListFilter")]
        [Validation(Required=false)]
        public List<int?> AnnotationStatusListFilter { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[1]</para>
        /// </summary>
        [NameInMap("AnnotationStatusListStringFilter")]
        [Validation(Required=false)]
        public string AnnotationStatusListStringFilter { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1673280000000</para>
        /// </summary>
        [NameInMap("CreateTimeEndFilter")]
        [Validation(Required=false)]
        public long? CreateTimeEndFilter { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1661961600000</para>
        /// </summary>
        [NameInMap("CreateTimeStartFilter")]
        [Validation(Required=false)]
        public long? CreateTimeStartFilter { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>191ef468-75a2-4004-9441-a5c31bf5cd9d</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
