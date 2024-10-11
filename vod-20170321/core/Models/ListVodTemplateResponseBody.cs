// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListVodTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2A56B75B-B7E6-48*****27-A9BEAA3E50A8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The snapshot templates.</para>
        /// </summary>
        [NameInMap("VodTemplateInfoList")]
        [Validation(Required=false)]
        public List<ListVodTemplateResponseBodyVodTemplateInfoList> VodTemplateInfoList { get; set; }
        public class ListVodTemplateResponseBodyVodTemplateInfoList : TeaModel {
            /// <summary>
            /// <para>The ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app-****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The time when the template was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-11-30T08:05:59:57Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the template is the default one. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Default</b>: The template is the default one.</description></item>
            /// <item><description><b>NotDefault</b>: The template is not the default one.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NotDefault</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public string IsDefault { get; set; }

            /// <summary>
            /// <para>The time when the template was modified. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-11-30T09:05:59:97Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The name of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The detailed configurations of the template. The value is a JSON-formatted string. For more information about the data structure, see the &quot;SnapshotTemplateConfig&quot; section of the <a href="https://help.aliyun.com/document_detail/98618.html">Media processing parameters</a> topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;SnapshotConfig\&quot;:{\&quot;Count\&quot;:10,\&quot;SpecifiedOffsetTime\&quot;:0,\&quot;Interval\&quot;:1},\&quot;SnapshotType\&quot;:\&quot;NormalSnapshot\&quot;}</para>
            /// </summary>
            [NameInMap("TemplateConfig")]
            [Validation(Required=false)]
            public string TemplateConfig { get; set; }

            /// <summary>
            /// <para>The type of the template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Snapshot</b></description></item>
            /// <item><description><b>DynamicImage</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Snapshot</para>
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

            /// <summary>
            /// <para>The ID of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7c49f2f42b1c*****0969fcd446690</para>
            /// </summary>
            [NameInMap("VodTemplateId")]
            [Validation(Required=false)]
            public string VodTemplateId { get; set; }

        }

    }

}
