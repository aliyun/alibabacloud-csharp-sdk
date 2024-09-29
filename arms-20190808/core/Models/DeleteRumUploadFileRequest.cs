// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DeleteRumUploadFileRequest : TeaModel {
        /// <summary>
        /// <para>Information of files to be deleted in JSON array format. If a single file needs to be deleted, this field should be left empty. If multiple files need to be deleted, just fill in this field.</para>
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
        /// <para>The file name, with the extension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.js.map</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
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

        /// <summary>
        /// <para>The file ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MS4wLjAtbWFpbi4wZjM0NzRlOSxxxxxx</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// <para>The version number of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}
