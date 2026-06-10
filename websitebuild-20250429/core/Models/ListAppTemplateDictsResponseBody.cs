// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ListAppTemplateDictsResponseBody : TeaModel {
        /// <summary>
        /// <para>Detailed reason why access was denied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>is retry allowed</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// <para>application name; queries the application with this name</para>
        /// 
        /// <b>Example:</b>
        /// <para>spring-cloud-b</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ERROR-oo1</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>dynamic error message used to replace the <c>%s</c> placeholder in the <b>ErrMessage</b> response parameter.  </para>
        /// <remarks>
        /// <para>If <b>ErrMessage</b> returns <b>The Value of Input Parameter %s is not valid</b> and <b>DynamicMessage</b> returns <b>DtsJobId</b>, it indicates that the request parameter <b>DtsJobId</b> is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM_ERROR</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>faulty parameters</para>
        /// </summary>
        [NameInMap("ErrorArgs")]
        [Validation(Required=false)]
        public List<object> ErrorArgs { get; set; }

        /// <summary>
        /// <para>Number of results per query.  </para>
        /// <para>Value range: 10–100. Default Value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>response Data</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public List<ListAppTemplateDictsResponseBodyModule> Module { get; set; }
        public class ListAppTemplateDictsResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>Dictionary Code</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("DictCode")]
            [Validation(Required=false)]
            public string DictCode { get; set; }

            /// <summary>
            /// <para>Dictionary label</para>
            /// 
            /// <b>Example:</b>
            /// <para>label</para>
            /// </summary>
            [NameInMap("DictLabel")]
            [Validation(Required=false)]
            public string DictLabel { get; set; }

            /// <summary>
            /// <para>Enumeration of template dictionary types</para>
            /// 
            /// <b>Example:</b>
            /// <para>product_version</para>
            /// </summary>
            [NameInMap("DictType")]
            [Validation(Required=false)]
            public string DictType { get; set; }

            /// <summary>
            /// <para>Dictionary value</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("DictValue")]
            [Validation(Required=false)]
            public string DictValue { get; set; }

            /// <summary>
            /// <para>Indicates whether a template exists.</para>
            /// </summary>
            [NameInMap("HasTemplates")]
            [Validation(Required=false)]
            public bool? HasTemplates { get; set; }

            /// <summary>
            /// <para>Sorting order. The default is descending.  </para>
            /// <para>Enumeration values:  </para>
            /// <para>ASC: ascending.  </para>
            /// <para>DESC: descending.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desc</para>
            /// </summary>
            [NameInMap("SortOrder")]
            [Validation(Required=false)]
            public int? SortOrder { get; set; }

        }

        /// <summary>
        /// <para>Token for the start of the next query. It is empty when there is no next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAARbaCuN6hiD08qrLdwJ9Fh3BFw8paIJ7ylB6A7Qn9JjM</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C6B99AC-39EC-5350-874C-204128C905E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM.ERROR</para>
        /// </summary>
        [NameInMap("RootErrorCode")]
        [Validation(Required=false)]
        public string RootErrorCode { get; set; }

        /// <summary>
        /// <para>abnormal message</para>
        /// 
        /// <b>Example:</b>
        /// <para>系统异常</para>
        /// </summary>
        [NameInMap("RootErrorMsg")]
        [Validation(Required=false)]
        public string RootErrorMsg { get; set; }

        /// <summary>
        /// <para>is processing synchronous</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Synchro")]
        [Validation(Required=false)]
        public bool? Synchro { get; set; }

    }

}
