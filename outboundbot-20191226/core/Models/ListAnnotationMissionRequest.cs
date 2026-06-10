// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListAnnotationMissionRequest : TeaModel {
        /// <summary>
        /// <para>Annotation mission ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>0943abcb-bd7d-4ace-8cf7-97d39d4dd0b9</para>
        /// </summary>
        [NameInMap("AnnotationMissionId")]
        [Validation(Required=false)]
        public string AnnotationMissionId { get; set; }

        /// <summary>
        /// <para>Annotation mission name</para>
        /// 
        /// <b>Example:</b>
        /// <para>全景服务场景-标注任务-20230316-103253</para>
        /// </summary>
        [NameInMap("AnnotationMissionName")]
        [Validation(Required=false)]
        public string AnnotationMissionName { get; set; }

        /// <summary>
        /// <para>Annotation status filter. Deprecated.</para>
        /// </summary>
        [NameInMap("AnnotationStatusListFilter")]
        [Validation(Required=false)]
        public List<int?> AnnotationStatusListFilter { get; set; }

        /// <summary>
        /// <para>Annotation status filter</para>
        /// <remarks>
        /// <para>Format: [1]. You can specify multiple values. Valid values:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>1: In progress</para>
        /// </description></item>
        /// <item><description><para>2: Completed</para>
        /// </description></item>
        /// <item><description><para>3: Closed</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[1]</para>
        /// </summary>
        [NameInMap("AnnotationStatusListStringFilter")]
        [Validation(Required=false)]
        public string AnnotationStatusListStringFilter { get; set; }

        /// <summary>
        /// <para>End time of the annotation mission creation filter</para>
        /// 
        /// <b>Example:</b>
        /// <para>1673280000000</para>
        /// </summary>
        [NameInMap("CreateTimeEndFilter")]
        [Validation(Required=false)]
        public long? CreateTimeEndFilter { get; set; }

        /// <summary>
        /// <para>Start time of the annotation mission creation filter</para>
        /// 
        /// <b>Example:</b>
        /// <para>1661961600000</para>
        /// </summary>
        [NameInMap("CreateTimeStartFilter")]
        [Validation(Required=false)]
        public long? CreateTimeStartFilter { get; set; }

        /// <summary>
        /// <para>Instance ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>191ef468-75a2-4004-9441-a5c31bf5cd9d</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Page number</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>Number of entries per page</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
