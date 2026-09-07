// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DeleteRumUploadFileRequest : TeaModel {
        /// <summary>
        /// <para>The batch deletion parameters in JSON array format. Leave this parameter empty if you want to delete a single file. If you want to delete multiple files in a batch, specify only this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{
        ///     &quot;fileName&quot; : &quot;test.js.map&quot;,
        ///     &quot;version&quot; : &quot;1.0.0&quot;
        ///   },
        ///   {
        ///     &quot;fileName&quot; : &quot;test.dSYM&quot;,
        ///     &quot;version&quot; : &quot;1.20.1&quot;,
        ///     &quot;uuid&quot; : &quot;xxxx-xxxx-xxxx-xxxx&quot;
        ///   }]</para>
        /// </summary>
        [NameInMap("BatchItems")]
        [Validation(Required=false)]
        public string BatchItems { get; set; }

        /// <summary>
        /// <para>The file name, including the file name extension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.js.map</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>atc889zkcf@d8deedfa9bf****</para>
        /// </summary>
        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The unique ID of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MS4wLjAtbWFpbi4wZjM0NzRlOSxxxxxx</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// <para>The file version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
