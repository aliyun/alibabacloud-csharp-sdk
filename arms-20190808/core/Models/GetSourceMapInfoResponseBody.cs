// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetSourceMapInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C21AB7CF-B7AF-410F-BD61-82D1567F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the SourceMap file.</para>
        /// </summary>
        [NameInMap("SourceMapList")]
        [Validation(Required=false)]
        public List<GetSourceMapInfoResponseBodySourceMapList> SourceMapList { get; set; }
        public class GetSourceMapInfoResponseBodySourceMapList : TeaModel {
            /// <summary>
            /// <para>The ID of the SourceMap file.</para>
            /// </summary>
            [NameInMap("Fid")]
            [Validation(Required=false)]
            public string Fid { get; set; }

            /// <summary>
            /// <para>The name of the SourceMap file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.sourcemap.js</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The size of the file. Unit: KB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>201223</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public string Size { get; set; }

            /// <summary>
            /// <para>The timestamp that indicates when the file was uploaded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1590657842000</para>
            /// </summary>
            [NameInMap("UploadTime")]
            [Validation(Required=false)]
            public string UploadTime { get; set; }

            /// <summary>
            /// <para>The version of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.0</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
