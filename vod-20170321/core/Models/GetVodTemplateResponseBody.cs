// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetVodTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DE7A1F49-41C1-47*****DF-4CD0C02087DB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the snapshot template.</para>
        /// </summary>
        [NameInMap("VodTemplateInfo")]
        [Validation(Required=false)]
        public GetVodTemplateResponseBodyVodTemplateInfo VodTemplateInfo { get; set; }
        public class GetVodTemplateResponseBodyVodTemplateInfo : TeaModel {
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
            /// <para>2018-11-30T09:05:59:57Z</para>
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
            /// <para>7c49f2f4c09*****69fcd446690</para>
            /// </summary>
            [NameInMap("VodTemplateId")]
            [Validation(Required=false)]
            public string VodTemplateId { get; set; }

        }

    }

}
