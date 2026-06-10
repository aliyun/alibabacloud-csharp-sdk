// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class GetAppRecommendedCommoditiesResponseBody : TeaModel {
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
        /// <para>App Name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>spring-cloud-b</para>
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
        /// <para>If <b>ErrMessage</b> returns <b>The Value of Input Parameter %s is not valid</b> and <b>DynamicMessage</b> returns <b>DtsJobId</b>, it means the provided request parameter <b>DtsJobId</b> is invalid.</para>
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
        /// <para>Data table module.  </para>
        /// <list type="bullet">
        /// <item><description><para>ABTest: Experiment Data Table  </para>
        /// </description></item>
        /// <item><description><para>ExperimentTool: Experiment Tool Table  </para>
        /// </description></item>
        /// <item><description><para>DataDiagnosis: Data Diagnosis</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public GetAppRecommendedCommoditiesResponseBodyModule Module { get; set; }
        public class GetAppRecommendedCommoditiesResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>Marketing product list</para>
            /// </summary>
            [NameInMap("Commodities")]
            [Validation(Required=false)]
            public List<GetAppRecommendedCommoditiesResponseBodyModuleCommodities> Commodities { get; set; }
            public class GetAppRecommendedCommoditiesResponseBodyModuleCommodities : TeaModel {
                /// <summary>
                /// <para>Commodity code (used for both resource plans and Marketing Products)</para>
                /// 
                /// <b>Example:</b>
                /// <para>rds</para>
                /// </summary>
                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                /// <summary>
                /// <para>Extension fields (such as unsupportedReason)</para>
                /// </summary>
                [NameInMap("Extend")]
                [Validation(Required=false)]
                public Dictionary<string, string> Extend { get; set; }

                /// <summary>
                /// <para>Order Type: BUY - Purchase, UPGRADE - upgrade</para>
                /// 
                /// <b>Example:</b>
                /// <para>DESC</para>
                /// </summary>
                [NameInMap("OrderType")]
                [Validation(Required=false)]
                public string OrderType { get; set; }

                /// <summary>
                /// <para>Sorting Priority (the smaller the number, the higher the priority)</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>Marketing Product ID (returned only for new purchases)</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("PromotionCommodityId")]
                [Validation(Required=false)]
                public string PromotionCommodityId { get; set; }

                /// <summary>
                /// <para>Hyperlink URL (returned when a redirect is required, such as during an upgrade)</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://ecs-workbench-disposable.aliyun.com/account/disposable/login/sst/1291612921555690/edvo2gevfh">https://ecs-workbench-disposable.aliyun.com/account/disposable/login/sst/1291612921555690/edvo2gevfh</a></para>
                /// </summary>
                [NameInMap("RedirectUrl")]
                [Validation(Required=false)]
                public string RedirectUrl { get; set; }

                /// <summary>
                /// <para>Product Status</para>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

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
        /// <para>Indicates whether processing is synchronous</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Synchro")]
        [Validation(Required=false)]
        public bool? Synchro { get; set; }

    }

}
