// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetVirusScanGlobalConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3D7EC0AF-DB2A-5D9C-90EC-F090A6BAAEA7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The maximum size of a single virus file that can be uploaded, in KB. A value of 0 indicates no size limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10240</para>
        /// </summary>
        [NameInMap("UploadFileMaxSize")]
        [Validation(Required=false)]
        public long? UploadFileMaxSize { get; set; }

        /// <summary>
        /// <para>The maximum upload rate for virus files, in KB/s. A value of 0 indicates no rate limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("UploadFileMaxSpeed")]
        [Validation(Required=false)]
        public long? UploadFileMaxSpeed { get; set; }

        /// <summary>
        /// <para>The collection of file types that are prohibited from being uploaded. Files that match these types are not uploaded even if the upload feature is enabled. An empty list is returned if no file types are configured.</para>
        /// </summary>
        [NameInMap("UploadFileSuffixBlacklist")]
        [Validation(Required=false)]
        public List<string> UploadFileSuffixBlacklist { get; set; }

        /// <summary>
        /// <para>Indicates whether user terminal devices are allowed to upload detected virus files to the cloud for further analysis. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Upload is allowed.</description></item>
        /// <item><description><b>false</b>: Upload is not allowed.</description></item>
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
