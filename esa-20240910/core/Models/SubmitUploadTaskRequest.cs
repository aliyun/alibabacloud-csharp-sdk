// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class SubmitUploadTaskRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to purge resources in the corresponding directory when the back-to-origin content is inconsistent with the origin server resources. Default value: false. This parameter is valid only for purge tasks.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Purges all resources in the corresponding directory.</description></item>
        /// <item><description><b>false</b>: Purges only the changed resources in the corresponding directory.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>The site ID. You can call the <a href="~~ListSites~~">ListSites</a> operation to obtain the site ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The file upload task ID, which is generated when you call the <a href="~~UploadTask~~">UploadTask</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1593805857882113</para>
        /// </summary>
        [NameInMap("UploadId")]
        [Validation(Required=false)]
        public long? UploadId { get; set; }

    }

}
