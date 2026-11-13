// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ListAppCommoditySpecificationsV2ForPartnerResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>Indicates whether retries are allowed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// <para>The application name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>or</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ERROR-oo1</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic error message used to replace <c>%s</c> in the error message returned in the <b>ErrMessage</b> response parameter.</para>
        /// <remarks>
        /// <para>If <b>ErrMessage</b> returns <b>The Value of Input Parameter %s is not valid</b> and <b>DynamicMessage</b> returns <b>DtsJobId</b>, it indicates that the <b>DtsJobId</b> request parameter is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM_ERROR</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error parameters.</para>
        /// </summary>
        [NameInMap("ErrorArgs")]
        [Validation(Required=false)]
        public List<object> ErrorArgs { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return per query. Valid values: 10 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public ListAppCommoditySpecificationsV2ForPartnerResponseBodyModule Module { get; set; }
        public class ListAppCommoditySpecificationsV2ForPartnerResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("CurrentPageNum")]
            [Validation(Required=false)]
            public int? CurrentPageNum { get; set; }

            /// <summary>
            /// <para>The request results.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListAppCommoditySpecificationsV2ForPartnerResponseBodyModuleData> Data { get; set; }
            public class ListAppCommoditySpecificationsV2ForPartnerResponseBodyModuleData : TeaModel {
                /// <summary>
                /// <para>The API status or POP error code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The component mapping for the product specifications, where the key is the component code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;deploy_area&quot;:{&quot;Code&quot;:&quot;deploy_area&quot;,&quot;Name&quot;:&quot;Deployment region&quot;,&quot;ModuleAttrStatus&quot;:1,&quot;Properties&quot;:{&quot;deploy_area&quot;:{&quot;Code&quot;:&quot;deploy_area&quot;,&quot;Name&quot;:&quot;Deployment region&quot;,&quot;Value&quot;:&quot;HongKong&quot;,&quot;Values&quot;:[{&quot;Value&quot;:&quot;HongKong&quot;,&quot;Name&quot;:&quot;China (Hong Kong)&quot;}]}}}}</para>
                /// </summary>
                [NameInMap("Components")]
                [Validation(Required=false)]
                public Dictionary<string, ModuleDataComponentsValue> Components { get; set; }

                /// <summary>
                /// <para>The file name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>File name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The property mapping for the product specifications, where the key is the property code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;version&quot;:{&quot;Code&quot;:&quot;version&quot;,&quot;Values&quot;:[{&quot;Value&quot;:&quot;V2.0&quot;}]}}</para>
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public Dictionary<string, ModuleDataPropertiesValue> Properties { get; set; }

            }

            /// <summary>
            /// <para>The next feature ID.</para>
            /// </summary>
            [NameInMap("Next")]
            [Validation(Required=false)]
            public ListAppCommoditySpecificationsV2ForPartnerResponseBodyModuleNext Next { get; set; }
            public class ListAppCommoditySpecificationsV2ForPartnerResponseBodyModuleNext : TeaModel {
                /// <summary>
                /// <para>The API status or POP error code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OK</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The component mapping for the product specifications, where the key is the component code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;deploy_area&quot;:{&quot;Code&quot;:&quot;deploy_area&quot;,&quot;Name&quot;:&quot;Deployment region&quot;,&quot;ModuleAttrStatus&quot;:1,&quot;Properties&quot;:{&quot;deploy_area&quot;:{&quot;Code&quot;:&quot;deploy_area&quot;,&quot;Name&quot;:&quot;Deployment region&quot;,&quot;Value&quot;:&quot;HongKong&quot;,&quot;Values&quot;:[{&quot;Value&quot;:&quot;HongKong&quot;,&quot;Name&quot;:&quot;China (Hong Kong)&quot;}]}}}}</para>
                /// </summary>
                [NameInMap("Components")]
                [Validation(Required=false)]
                public Dictionary<string, ModuleNextComponentsValue> Components { get; set; }

                /// <summary>
                /// <para>The website name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>docs</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The property mapping for the product specifications, where the key is the property code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;version&quot;:{&quot;Code&quot;:&quot;version&quot;,&quot;Values&quot;:[{&quot;Value&quot;:&quot;V2.0&quot;}]}}</para>
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public Dictionary<string, ModuleNextPropertiesValue> Properties { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether a next page exists.</para>
            /// 
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("NextPage")]
            [Validation(Required=false)]
            public bool? NextPage { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Indicates whether a previous page exists.</para>
            /// 
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("PrePage")]
            [Validation(Required=false)]
            public bool? PrePage { get; set; }

            /// <summary>
            /// <para>In addition to the pagination limit, the server processes a maximum of the latest 1,000 records for the current query. If the number of results exceeds 1,000, <b>ResultLimit</b> is set to <b>true</b>. In this case, narrow the time range and search again. Otherwise, <b>ResultLimit</b> is set to <b>false</b>.</para>
            /// </summary>
            [NameInMap("ResultLimit")]
            [Validation(Required=false)]
            public bool? ResultLimit { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalItemNum")]
            [Validation(Required=false)]
            public int? TotalItemNum { get; set; }

            /// <summary>
            /// <para>The total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPageNum")]
            [Validation(Required=false)]
            public int? TotalPageNum { get; set; }

        }

        /// <summary>
        /// <para>The token used to start the next query. This value is empty if there are no more results.</para>
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
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM.ERROR</para>
        /// </summary>
        [NameInMap("RootErrorCode")]
        [Validation(Required=false)]
        public string RootErrorCode { get; set; }

        /// <summary>
        /// <para>The exception message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>System exception</para>
        /// </summary>
        [NameInMap("RootErrorMsg")]
        [Validation(Required=false)]
        public string RootErrorMsg { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is processed synchronously.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Synchro")]
        [Validation(Required=false)]
        public bool? Synchro { get; set; }

    }

}
