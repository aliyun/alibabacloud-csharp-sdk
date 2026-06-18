// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class SubmitUploadTaskRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to refresh resources in the corresponding directory if the requested content is different from that on the origin server. Default value: false. This parameter takes effect for a purge task.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: purges all resources in the directory.</description></item>
        /// <item><description><b>false</b>: refresh the changed resources in the directory.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>The website ID. You can call the <a href="~~ListSites~~">ListSites</a> operation to obtain the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The ID of the file upload task, which is generated when you call <a href="~~UploadTask~~">UploadTask</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1593805857882113</para>
        /// </summary>
        [NameInMap("UploadId")]
        [Validation(Required=false)]
        public long? UploadId { get; set; }

    }

}
