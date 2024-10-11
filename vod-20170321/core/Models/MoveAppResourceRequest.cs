// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class MoveAppResourceRequest : TeaModel {
        /// <summary>
        /// <para>The resource ID. You can specify a maximum of 20 IDs at a time. Separate multiple IDs with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9afb4<b><b>06de180880e,f7bba</b></b>caa546cfe2ba</para>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public string ResourceIds { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>video</b>: video files.</description></item>
        /// <item><description><b>image</b>: image files.</description></item>
        /// <item><description><b>attached</b>: auxiliary media assets.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>video</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The ID of the application to which resources are migrated. Default value: <b>app-1000000</b>. For more information, see <a href="https://help.aliyun.com/document_detail/113600.html">Use the multi-application service</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-****</para>
        /// </summary>
        [NameInMap("TargetAppId")]
        [Validation(Required=false)]
        public string TargetAppId { get; set; }

    }

}
