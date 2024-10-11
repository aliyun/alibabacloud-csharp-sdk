// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateVodTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The name of the template.</para>
        /// <list type="bullet">
        /// <item><description>The name can be up to 128 bytes in length.</description></item>
        /// <item><description>The value must be encoded in UTF-8.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The configurations of the snapshot template. The value is a JSON-formatted string. For more information about the data structure, see the &quot;SnapshotTemplateConfig&quot; section of the <a href="https://help.aliyun.com/document_detail/98618.html">Media processing parameters</a> topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;SnapshotConfig&quot;:{&quot;Count&quot;:10,&quot;SpecifiedOffsetTime&quot;:0,&quot;Interval&quot;:1}</para>
        /// </summary>
        [NameInMap("TemplateConfig")]
        [Validation(Required=false)]
        public string TemplateConfig { get; set; }

        /// <summary>
        /// <para>The ID of the snapshot template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8c75a02e339b*****0b0d2c48171a22</para>
        /// </summary>
        [NameInMap("VodTemplateId")]
        [Validation(Required=false)]
        public string VodTemplateId { get; set; }

    }

}
