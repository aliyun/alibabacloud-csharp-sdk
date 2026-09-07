// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateRumUploadFileUrlRequest : TeaModel {
        /// <summary>
        /// <para>The application name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-app</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The file type. Valid values include <c>&quot;application/zip&quot;</c> and <c>&quot;text/plain&quot;</c>. You can also pass an empty string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text/plain</para>
        /// </summary>
        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>The file name.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>iioe7jcnuk@582846f37******</para>
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
        /// <para>The file type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>source-map: a source map file</para>
        /// </description></item>
        /// <item><description><para>mapping: an Android symbol table file</para>
        /// </description></item>
        /// <item><description><para>dsym: an iOS dSYM file</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>source-map</para>
        /// </summary>
        [NameInMap("SourcemapType")]
        [Validation(Required=false)]
        public string SourcemapType { get; set; }

        /// <summary>
        /// <para>The UUID of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>125bdb39-a415-4503-bd96-e293925fc64c</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// <para>The file version.</para>
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
