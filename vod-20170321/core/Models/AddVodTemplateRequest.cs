// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddVodTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application. Default value: <b>app-1000000</b>. For more information, see <a href="https://help.aliyun.com/document_detail/113600.html">Multi-application service</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The name of the template.</para>
        /// <list type="bullet">
        /// <item><description>The name cannot exceed 128 bytes.</description></item>
        /// <item><description>The value must be encoded in UTF-8.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The configurations of the snapshot template. The value must be a JSON string. For more information about the data structure, see <a href="https://help.aliyun.com/document_detail/98618.html">SnapshotTemplateConfig</a> and <a href="https://help.aliyun.com/document_detail/98618.html">DynamicImageTemplateConfig</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;SnapshotConfig&quot;:{&quot;Count&quot;:10,&quot;SpecifiedOffsetTime&quot;:0,&quot;Interval&quot;:1,&quot;FrameType&quot;:&quot;normal&quot;},&quot;SnapshotType&quot;:&quot;NormalSnapshot&quot;}</para>
        /// </summary>
        [NameInMap("TemplateConfig")]
        [Validation(Required=false)]
        public string TemplateConfig { get; set; }

        /// <summary>
        /// <para>The type of the template. Set the value to <b>Snapshot</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Snapshot</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
