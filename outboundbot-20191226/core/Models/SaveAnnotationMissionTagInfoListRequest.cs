// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class SaveAnnotationMissionTagInfoListRequest : TeaModel {
        /// <summary>
        /// <para>The list of tags.</para>
        /// <remarks>
        /// <para>This parameter has the same function as AnnotationMissionTagInfoListJsonString. Specify either this parameter or AnnotationMissionTagInfoListJsonString.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("AnnotationMissionTagInfoList")]
        [Validation(Required=false)]
        public List<SaveAnnotationMissionTagInfoListRequestAnnotationMissionTagInfoList> AnnotationMissionTagInfoList { get; set; }
        public class SaveAnnotationMissionTagInfoListRequestAnnotationMissionTagInfoList : TeaModel {
            /// <summary>
            /// <para>The tag description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>标签描述</para>
            /// </summary>
            [NameInMap("AnnotationMissionTagInfoDescription")]
            [Validation(Required=false)]
            public string AnnotationMissionTagInfoDescription { get; set; }

            /// <summary>
            /// <para>The tag ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bdbff6a5-1f68-4b41-8d37-6ff805ce165a</para>
            /// </summary>
            [NameInMap("AnnotationMissionTagInfoId")]
            [Validation(Required=false)]
            public string AnnotationMissionTagInfoId { get; set; }

            /// <summary>
            /// <para>The tag name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>标签</para>
            /// </summary>
            [NameInMap("AnnotationMissionTagInfoName")]
            [Validation(Required=false)]
            public string AnnotationMissionTagInfoName { get; set; }

            /// <summary>
            /// <para>Indicates whether to delete the tag.</para>
            /// <remarks>
            /// <para>Set this parameter to true to delete the tag. Set it to false to add the tag.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Delete")]
            [Validation(Required=false)]
            public bool? Delete { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bdbff6a5-1f68-4b41-8d37-6ff805ce165a</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The tenant ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bdbff6a5-1f68-4b41-8d37-6ff805ce165a</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        /// <summary>
        /// <para>The JSON-formatted data of the tags.</para>
        /// <remarks>
        /// <para>The parameters in the JSON string are the same as those in AnnotationMissionTagInfoList. Specify either this parameter or AnnotationMissionTagInfoList.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;delete&quot;:false,				&quot;InstanceId&quot;:&quot;00b37342-e759-4fe5-b296-aef775933af0&quot;,					&quot;AnnotationMissionTagInfoName&quot;:&quot;测试数据1&quot;,					&quot;AnnotationMissionTagInfoDescription&quot;:&quot;测试&quot;}]</para>
        /// </summary>
        [NameInMap("AnnotationMissionTagInfoListJsonString")]
        [Validation(Required=false)]
        public string AnnotationMissionTagInfoListJsonString { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>af81a389-91f0-4157-8d82-720edd02b66a</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Indicates whether to restore the default tag values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Reset")]
        [Validation(Required=false)]
        public bool? Reset { get; set; }

    }

}
