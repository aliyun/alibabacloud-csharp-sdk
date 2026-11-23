// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ExpressConnectRouter20230901.Models
{
    public class CheckAddRegionToExpressConnectRouterResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Authentication is failed for ****</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>Indicates whether the Express Connect Router (ECR) instance has cross-border connections between the Chinese mainland and regions outside the Chinese mainland. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Yes.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: No.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AnyCrossBorderLink")]
        [Validation(Required=false)]
        public bool? AnyCrossBorderLink { get; set; }

        /// <summary>
        /// <para>Indicates whether the Express Connect Router (ECR) instance has cross-region connections in the Chinese mainland. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Yes.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: No.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AnyInterRegionLink")]
        [Validation(Required=false)]
        public bool? AnyInterRegionLink { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. A return value of 200 indicates that the request was successful. Any other value indicates that the request failed. For more information about the causes of failure, see Error codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IllegalParamFormat.EcrId</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic error message, which is used to replace <c>%s</c> in the <b>ErrMessage</b> error message.</para>
        /// <remarks>
        /// <para>If <b>ErrMessage</b> returns <b>The Value of Input Parameter %s is not valid</b> and <b>DynamicMessage</b> returns <b>DtsInstanceId</b>, it indicates that the <b>DtsInstanceId</b> request parameter is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>The param format of EcrId **** is illegal.</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Indicates whether the cross-border Cloud Data Transfer (CDT) service is enabled for the account to which the Express Connect Router (ECR) instance belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Yes.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: No.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsCdtCrossBorderEnabled")]
        [Validation(Required=false)]
        public bool? IsCdtCrossBorderEnabled { get; set; }

        /// <summary>
        /// <para>Indicates whether the Cloud Data Transfer (CDT) service is enabled for the account to which the Express Connect Router (ECR) instance belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Yes.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: No.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsCdtInterRegionEnabled")]
        [Validation(Required=false)]
        public bool? IsCdtInterRegionEnabled { get; set; }

        /// <summary>
        /// <para>Indicates whether the account to which the Express Connect Router (ECR) instance belongs is allowed to create cross-border connections. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Yes.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: No.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsUserAllowedToCreateCrossBorderLink")]
        [Validation(Required=false)]
        public bool? IsUserAllowedToCreateCrossBorderLink { get; set; }

        /// <summary>
        /// <para>The message returned for the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6FABF516-FED3-5697-BDA2-B18C5D9A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>True</b>: The call was successful.</para>
        /// </description></item>
        /// <item><description><para><b>False</b>: The call failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
