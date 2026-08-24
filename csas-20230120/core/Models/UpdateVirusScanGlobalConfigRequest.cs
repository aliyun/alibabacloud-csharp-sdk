// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateVirusScanGlobalConfigRequest : TeaModel {
        /// <summary>
        /// <para>The maximum size of a single virus file that can be uploaded. Unit: KB. Valid values: 0 to 204800. A value of 0 indicates no size limit. Values from 1 to 204800 specify the actual size limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10240</para>
        /// </summary>
        [NameInMap("UploadFileMaxSize")]
        [Validation(Required=false)]
        public long? UploadFileMaxSize { get; set; }

        /// <summary>
        /// <para>The maximum upload rate for virus files. Unit: KB/s. Valid values: 0 to 102400. A value of 0 indicates no rate limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("UploadFileMaxSpeed")]
        [Validation(Required=false)]
        public long? UploadFileMaxSpeed { get; set; }

        /// <summary>
        /// <para>The collection of file types that are prohibited from being uploaded. Duplicate values are not allowed. Files that match the specified types are not uploaded even if upload is enabled.</para>
        /// </summary>
        [NameInMap("UploadFileSuffixBlacklist")]
        [Validation(Required=false)]
        public List<string> UploadFileSuffixBlacklist { get; set; }

        /// <summary>
        /// <para>Specifies whether user terminal devices are allowed to upload detected virus files to the cloud for further analysis. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Allowed.</description></item>
        /// <item><description><b>false</b>: Not allowed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("VirusFileUpload")]
        [Validation(Required=false)]
        public bool? VirusFileUpload { get; set; }

    }

}
