// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class ChatRefDocItem : TeaModel {
        /// <summary>
        /// <para>Related document information.</para>
        /// </summary>
        [NameInMap("docInfo")]
        [Validation(Required=false)]
        public ChatRefDocInfo DocInfo { get; set; }

        /// <summary>
        /// <para>Document name. If the original file is of types like doc, it will be converted to PDF for easier document location. This file should be used for document location information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a.pdf</para>
        /// </summary>
        [NameInMap("docName")]
        [Validation(Required=false)]
        public string DocName { get; set; }

        /// <summary>
        /// <para>Document link.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://carbon-aidoc.oss-accelerate.aliyuncs.com/jobs/42dbc7-3a9e-4e18-8939-3fd2d247bd3c/document/97178d94c75941d3b932883c810c5e.pdf">https://carbon-aidoc.oss-accelerate.aliyuncs.com/jobs/42dbc7-3a9e-4e18-8939-3fd2d247bd3c/document/97178d94c75941d3b932883c810c5e.pdf</a></para>
        /// </summary>
        [NameInMap("docUrl")]
        [Validation(Required=false)]
        public string DocUrl { get; set; }

        /// <summary>
        /// <para>Original document name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a.doc</para>
        /// </summary>
        [NameInMap("originDocName")]
        [Validation(Required=false)]
        public string OriginDocName { get; set; }

        /// <summary>
        /// <para>Original document link.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://carbon-aidoc.oss-accelerate.aliyuncs.com/jobs/42dbc7-3a9e-4e18-8939-3fd2d247bd3c/document/97178d94c75941d3b932883c810c5e.doc">https://carbon-aidoc.oss-accelerate.aliyuncs.com/jobs/42dbc7-3a9e-4e18-8939-3fd2d247bd3c/document/97178d94c75941d3b932883c810c5e.doc</a></para>
        /// </summary>
        [NameInMap("originDocUrl")]
        [Validation(Required=false)]
        public string OriginDocUrl { get; set; }

        /// <summary>
        /// <para>Page number information.</para>
        /// </summary>
        [NameInMap("pageNum")]
        [Validation(Required=false)]
        public List<ChatDocumentPageNum> PageNum { get; set; }

        /// <summary>
        /// <para>Return file type: \&quot;doc\&quot; for document files, \&quot;web\&quot; for internet information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>doc</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
