// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class TemplateView : TeaModel {
        /// <summary>
        /// <para>View List</para>
        /// </summary>
        [NameInMap("Fields")]
        [Validation(Required=false)]
        public List<TemplateViewFields> Fields { get; set; }
        public class TemplateViewFields : TeaModel {
            /// <summary>
            /// <para>Whether to Display Original Image</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DisplayOriImg")]
            [Validation(Required=false)]
            public bool? DisplayOriImg { get; set; }

            /// <summary>
            /// <para>Associated Column Name</para>
            /// 
            /// <b>Example:</b>
            /// <para>url</para>
            /// </summary>
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// <para>View Type</para>
            /// 
            /// <b>Example:</b>
            /// <para>IMG</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>Access Information</para>
            /// </summary>
            [NameInMap("VisitInfo")]
            [Validation(Required=false)]
            public TemplateViewFieldsVisitInfo VisitInfo { get; set; }
            public class TemplateViewFieldsVisitInfo : TeaModel {
                /// <summary>
                /// <para>Afts Configuration</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;expiredTime&quot;:20}</para>
                /// </summary>
                [NameInMap("AftsConf")]
                [Validation(Required=false)]
                public Dictionary<string, object> AftsConf { get; set; }

                /// <summary>
                /// <para>OSS Configuration</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;ossEndpoint&quot;:&quot;<em><b>&quot;,&quot;ossAk&quot;:&quot;</b></em>&quot;,&quot;ossAs&quot;:&quot;***&quot;,&quot;ossOwner&quot;:&quot;&quot;,&quot;ossBucket&quot;:&quot;&quot;}</para>
                /// </summary>
                [NameInMap("OssConf")]
                [Validation(Required=false)]
                public Dictionary<string, object> OssConf { get; set; }

            }

        }

    }

}
