// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class RecoverRenderingDataPackageRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cloud application service data package.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dp-449ea3d16c0841b8bf33ec5bbc86a152</para>
        /// </summary>
        [NameInMap("DataPackageId")]
        [Validation(Required=false)]
        public string DataPackageId { get; set; }

        /// <summary>
        /// <para>The data loading mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>System: system-level loading, which provides high stability but takes a relatively long time.</description></item>
        /// <item><description>Process: process-level loading, which provides high loading timeliness but relatively low stability.
        /// Default value: System.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Process</para>
        /// </summary>
        [NameInMap("LoadMode")]
        [Validation(Required=false)]
        public string LoadMode { get; set; }

        /// <summary>
        /// <para>The cloud application service instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>render-9f8c57355d224ad7beaf95e145f22111</para>
        /// </summary>
        [NameInMap("RenderingInstanceId")]
        [Validation(Required=false)]
        public string RenderingInstanceId { get; set; }

    }

}
