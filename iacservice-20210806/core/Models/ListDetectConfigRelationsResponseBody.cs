// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListDetectConfigRelationsResponseBody : TeaModel {
        /// <summary>
        /// <para>List of associations</para>
        /// </summary>
        [NameInMap("detectConfigRelations")]
        [Validation(Required=false)]
        public List<ListDetectConfigRelationsResponseBodyDetectConfigRelations> DetectConfigRelations { get; set; }
        public class ListDetectConfigRelationsResponseBodyDetectConfigRelations : TeaModel {
            /// <summary>
            /// <para>Association time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-08T08:53:07.000+00:00</para>
            /// </summary>
            [NameInMap("attachDate")]
            [Validation(Required=false)]
            public string AttachDate { get; set; }

            /// <summary>
            /// <para>Drift detection configuration ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>dc-xxxx</para>
            /// </summary>
            [NameInMap("detectConfigId")]
            [Validation(Required=false)]
            public string DetectConfigId { get; set; }

            /// <summary>
            /// <para>Whether enabled</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public string Enabled { get; set; }

            /// <summary>
            /// <para>Target ID. StackId or TaskId</para>
            /// 
            /// <b>Example:</b>
            /// <para>stack-xxxx</para>
            /// </summary>
            [NameInMap("targetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// <para>Target name</para>
            /// 
            /// <b>Example:</b>
            /// <para>stack-name-xxx</para>
            /// </summary>
            [NameInMap("targetName")]
            [Validation(Required=false)]
            public string TargetName { get; set; }

            /// <summary>
            /// <para>Target type  </para>
            /// <list type="bullet">
            /// <item><description>Task: orchestration job  </description></item>
            /// <item><description>Stack: resource stack</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Stack</para>
            /// </summary>
            [NameInMap("targetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

        /// <summary>
        /// <para>ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>0D797DC3-FF04-5C21-81EB-XXXXXXXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
