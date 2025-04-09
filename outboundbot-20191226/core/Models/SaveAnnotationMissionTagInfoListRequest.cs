// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class SaveAnnotationMissionTagInfoListRequest : TeaModel {
        [NameInMap("AnnotationMissionTagInfoList")]
        [Validation(Required=false)]
        public List<SaveAnnotationMissionTagInfoListRequestAnnotationMissionTagInfoList> AnnotationMissionTagInfoList { get; set; }
        public class SaveAnnotationMissionTagInfoListRequestAnnotationMissionTagInfoList : TeaModel {
            [NameInMap("AnnotationMissionTagInfoDescription")]
            [Validation(Required=false)]
            public string AnnotationMissionTagInfoDescription { get; set; }

            /// <summary>
            /// <para>tag id</para>
            /// </summary>
            [NameInMap("AnnotationMissionTagInfoId")]
            [Validation(Required=false)]
            public string AnnotationMissionTagInfoId { get; set; }

            [NameInMap("AnnotationMissionTagInfoName")]
            [Validation(Required=false)]
            public string AnnotationMissionTagInfoName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Delete")]
            [Validation(Required=false)]
            public bool? Delete { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>bdbff6a5-1f68-4b41-8d37-6ff805ce165a</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>bdbff6a5-1f68-4b41-8d37-6ff805ce165a</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("AnnotationMissionTagInfoListJsonString")]
        [Validation(Required=false)]
        public string AnnotationMissionTagInfoListJsonString { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>af81a389-91f0-4157-8d82-720edd02b66a</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Reset")]
        [Validation(Required=false)]
        public bool? Reset { get; set; }

    }

}
