// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListAnnotationMissionRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the annotation task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0943abcb-bd7d-4ace-8cf7-97d39d4dd0b9</para>
        /// </summary>
        [NameInMap("AnnotationMissionId")]
        [Validation(Required=false)]
        public string AnnotationMissionId { get; set; }

        /// <summary>
        /// <para>The name of the annotation task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Panorama service scenario - Annotation task - 20230316-103253</para>
        /// </summary>
        [NameInMap("AnnotationMissionName")]
        [Validation(Required=false)]
        public string AnnotationMissionName { get; set; }

        /// <summary>
        /// <para>The annotation status filter. This parameter is deprecated.</para>
        /// </summary>
        [NameInMap("AnnotationStatusListFilter")]
        [Validation(Required=false)]
        public List<int?> AnnotationStatusListFilter { get; set; }

        /// <summary>
        /// <para>The annotation status filter.</para>
        /// <remarks>
        /// <para>The format is [1]. You can select multiple filter conditions. The valid values are as follows:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>1: In progress.</description></item>
        /// <item><description>2: Completed.</description></item>
        /// <item><description>3: Closed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[1]</para>
        /// </summary>
        [NameInMap("AnnotationStatusListStringFilter")]
        [Validation(Required=false)]
        public string AnnotationStatusListStringFilter { get; set; }

        /// <summary>
        /// <para>The end time for the annotation task creation filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1673280000000</para>
        /// </summary>
        [NameInMap("CreateTimeEndFilter")]
        [Validation(Required=false)]
        public long? CreateTimeEndFilter { get; set; }

        /// <summary>
        /// <para>The start time for the annotation task creation filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1661961600000</para>
        /// </summary>
        [NameInMap("CreateTimeStartFilter")]
        [Validation(Required=false)]
        public long? CreateTimeStartFilter { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>191ef468-75a2-4004-9441-a5c31bf5cd9d</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
