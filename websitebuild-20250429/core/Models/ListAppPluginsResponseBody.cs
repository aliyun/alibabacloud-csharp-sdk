// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ListAppPluginsResponseBody : TeaModel {
        /// <summary>
        /// <para>Detailed reason for access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>Indicates whether retry is allowed</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// <para>Application name. Query the application with this name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dewuApp</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>Dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ERROR-oo1</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>Dynamic error message used to replace the <c>%s</c> placeholder in the <b>ErrMessage</b> error message.  </para>
        /// <remarks>
        /// <para>If <b>ErrMessage</b> returns <b>The Value of Input Parameter %s is not valid</b> and <b>DynamicMessage</b> returns <b>DtsJobId</b>, it indicates that the provided request parameter <b>DtsJobId</b> is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM_ERROR</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>Returned error parameters</para>
        /// </summary>
        [NameInMap("ErrorArgs")]
        [Validation(Required=false)]
        public List<object> ErrorArgs { get; set; }

        /// <summary>
        /// <para>Number of results per query.  </para>
        /// <para>Value range: 10 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Returned object.</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public List<ListAppPluginsResponseBodyModule> Module { get; set; }
        public class ListAppPluginsResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>plugin code</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>Configuration form in React JSON Schema format</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("ConfigItems")]
            [Validation(Required=false)]
            public string ConfigItems { get; set; }

            /// <summary>
            /// <para>plugin Description</para>
            /// 
            /// <b>Example:</b>
            /// <para>fail to decode json</para>
            /// </summary>
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            /// <summary>
            /// <para>Image display. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description><b>0</b> (None): Do not display.  </description></item>
            /// <item><description><b>1</b> (Always): Always display.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>always</para>
            /// </summary>
            [NameInMap("Display")]
            [Validation(Required=false)]
            public int? Display { get; set; }

            /// <summary>
            /// <para>Indicates whether scheduled delivery of resource snapshots is enabled.  </para>
            /// <para>Valid values:  </para>
            /// <list type="bullet">
            /// <item><description>true: Enabled.  </description></item>
            /// <item><description>false: Shutdown.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public int? Enabled { get; set; }

            /// <summary>
            /// <para>environment</para>
            /// 
            /// <b>Example:</b>
            /// <para>pre</para>
            /// </summary>
            [NameInMap("Env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            /// <summary>
            /// <para>Creation Time</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>1740479834</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>Updated At</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-08-28T02:25:41Z</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            /// <summary>
            /// <para>hook definitions</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("Hooks")]
            [Validation(Required=false)]
            public string Hooks { get; set; }

            /// <summary>
            /// <para>plugin Description</para>
            /// 
            /// <b>Example:</b>
            /// <para>@lALPM2AwTOg9IUHNAUDNAUA</para>
            /// </summary>
            [NameInMap("Icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// <para>primary key</para>
            /// 
            /// <b>Example:</b>
            /// <para>16257</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Indicates whether the item has been deleted: 0—No, 1—Yes</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsDeleted")]
            [Validation(Required=false)]
            public int? IsDeleted { get; set; }

            /// <summary>
            /// <para>plugin Name</para>
            /// 
            /// <b>Example:</b>
            /// <para>文件名</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>skill header, used by the model for selection</para>
            /// 
            /// <b>Example:</b>
            /// <para>header</para>
            /// </summary>
            [NameInMap("SkillHeader")]
            [Validation(Required=false)]
            public string SkillHeader { get; set; }

            /// <summary>
            /// <para>Categorization label</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;Key\&quot;: \&quot;kubernetes.io/cluster-id\&quot;, \&quot;Value\&quot;: \&quot;cc67198b13db948c9848599654da5586e\&quot;}, {\&quot;Key\&quot;: \&quot;created-by\&quot;, \&quot;Value\&quot;: \&quot;alibabacloud-imagecache-controller\&quot;}]</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

        }

        /// <summary>
        /// <para>Token for starting the next query. It is empty if there is no next query.</para>
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
        /// <para>Error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM.ERROR</para>
        /// </summary>
        [NameInMap("RootErrorCode")]
        [Validation(Required=false)]
        public string RootErrorCode { get; set; }

        /// <summary>
        /// <para>Abnormal message</para>
        /// 
        /// <b>Example:</b>
        /// <para>系统异常</para>
        /// </summary>
        [NameInMap("RootErrorMsg")]
        [Validation(Required=false)]
        public string RootErrorMsg { get; set; }

        /// <summary>
        /// <para>Reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Synchro")]
        [Validation(Required=false)]
        public bool? Synchro { get; set; }

    }

}
