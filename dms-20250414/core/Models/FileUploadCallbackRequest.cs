// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class FileUploadCallbackRequest : TeaModel {
        /// <summary>
        /// <para>For frontend use only.</para>
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
        /// <para>The file size in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8110</para>
        /// </summary>
        [NameInMap("FileSize")]
        [Validation(Required=false)]
        public long? FileSize { get; set; }

        /// <summary>
        /// <para>The file name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>conversion_metrics.csv</para>
        /// </summary>
        [NameInMap("Filename")]
        [Validation(Required=false)]
        public string Filename { get; set; }

        [NameInMap("OssBucket")]
        [Validation(Required=false)]
        public string OssBucket { get; set; }

        /// <summary>
        /// <para>The full path for the file upload.</para>
        /// <list type="bullet">
        /// <item><description><para>Format: This path is formed by appending the file name to the UploadDir value returned by the DescribeFileUploadSignature operation.</para>
        /// </description></item>
        /// <item><description><para>Example: ${UploadDir}/${Filename}</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UploadLocation")]
        [Validation(Required=false)]
        public string UploadLocation { get; set; }

    }

}
