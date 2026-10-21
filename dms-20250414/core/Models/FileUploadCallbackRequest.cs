// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class FileUploadCallbackRequest : TeaModel {
        /// <summary>
        /// <para>Used only by the frontend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TrailCenter</para>
        /// </summary>
        [NameInMap("CallFrom")]
        [Validation(Required=false)]
        public string CallFrom { get; set; }

        /// <summary>
        /// <para>The current DMS unit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DmsUnit")]
        [Validation(Required=false)]
        public string DmsUnit { get; set; }

        /// <summary>
        /// <para>The size of the file, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8110</para>
        /// </summary>
        [NameInMap("FileSize")]
        [Validation(Required=false)]
        public long? FileSize { get; set; }

        /// <summary>
        /// <para>The name of the file.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>conversion_metrics.csv</para>
        /// </summary>
        [NameInMap("Filename")]
        [Validation(Required=false)]
        public string Filename { get; set; }

        /// <summary>
        /// <para>The name of the user\&quot;s OSS bucket.</para>
        /// <list type="bullet">
        /// <item><description>Specify this parameter to use a file in the user\&quot;s OSS bucket and register the file as a data center file through the callback.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>bgc-hangzhou-test-bucket</para>
        /// </summary>
        [NameInMap("OssBucket")]
        [Validation(Required=false)]
        public string OssBucket { get; set; }

        /// <summary>
        /// <para>The full path of the uploaded file.</para>
        /// <list type="bullet">
        /// <item><description>Format: Concatenate the UploadDir field returned by the DescribeFileUploadSignature operation with the file name.</description></item>
        /// <item><description>Example: ${UploadDir}/${Filename}</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UploadLocation")]
        [Validation(Required=false)]
        public string UploadLocation { get; set; }

        /// <summary>
        /// <para>The ID of the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccihe433d3*******lxljv</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
