// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeVerifySearchPageListRequest : TeaModel {
        /// <summary>
        /// <para>The ID card number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3203212000XXXX701X</para>
        /// </summary>
        [NameInMap("CertNo")]
        [Validation(Required=false)]
        public string CertNo { get; set; }

        /// <summary>
        /// <para>The authentication ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>shadbdd3dbacd001cfa892a5e2b98dxx</para>
        /// </summary>
        [NameInMap("CertifyId")]
        [Validation(Required=false)]
        public string CertifyId { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>The end time of the query. Format: YYYY-MM-DD HH:mm:ss, such as 2025-10-16 23:59:59.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-10-16 23:59:59</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>Specifies whether device risk exists. Set this parameter to true to indicate root = 1, simulator = 1, or virtual_video = 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasDeviceRisk")]
        [Validation(Required=false)]
        public bool? HasDeviceRisk { get; set; }

        /// <summary>
        /// <para>The liveness detection model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LIVENESS</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>The unique identifier of the customer request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a77f5ac40a5aa5e6ed20c353888</para>
        /// </summary>
        [NameInMap("OuterOrderNo")]
        [Validation(Required=false)]
        public string OuterOrderNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>Indicates whether the authentication is passed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>T</b>: Passed.</description></item>
        /// <item><description><b>F</b>: Not passed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>F</para>
        /// </summary>
        [NameInMap("Passed")]
        [Validation(Required=false)]
        public string Passed { get; set; }

        /// <summary>
        /// <para>The product code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ID_PRO</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The business scenario risk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: No risk.</description></item>
        /// <item><description><b>1</b>: Risk exists.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RiskBizScenario")]
        [Validation(Required=false)]
        public int? RiskBizScenario { get; set; }

        /// <summary>
        /// <para>The device risk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: No risk.</description></item>
        /// <item><description><b>1</b>: Risk exists.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RiskDevice")]
        [Validation(Required=false)]
        public int? RiskDevice { get; set; }

        /// <summary>
        /// <para>The DeviceToken risk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: No risk.</description></item>
        /// <item><description><b>1</b>: Risk exists.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RiskDeviceToken")]
        [Validation(Required=false)]
        public int? RiskDeviceToken { get; set; }

        /// <summary>
        /// <para>The generic risk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: No risk.</description></item>
        /// <item><description><b>1</b>: Risk exists.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RiskGeneric")]
        [Validation(Required=false)]
        public int? RiskGeneric { get; set; }

        /// <summary>
        /// <para>The large model mining risk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: No risk.</description></item>
        /// <item><description><b>1</b>: Risk exists.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RiskModelMining")]
        [Validation(Required=false)]
        public int? RiskModelMining { get; set; }

        /// <summary>
        /// <para>Specifies whether the device is rooted. Set this parameter to 1 if selected. Otherwise, do not pass this parameter. This corresponds to the identity tag risk type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Root")]
        [Validation(Required=false)]
        public int? Root { get; set; }

        /// <summary>
        /// <para>The scene ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000072xx</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

        /// <summary>
        /// <para>Specifies whether the device is a simulator. Set this parameter to 1 if selected. Otherwise, do not pass this parameter. This corresponds to the device tag risk type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Simulator")]
        [Validation(Required=false)]
        public int? Simulator { get; set; }

        /// <summary>
        /// <para>The start time of the query. Format: YYYY-MM-DD HH:mm:ss, such as 2025-10-10 00:00:00.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-10-10 00:00:00</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The result code. For more information about valid values, see <a href="https://www.alibabacloud.com/help/en/id-verification/financial-grade-id-verification/error-code-person-verify#d88910e172fgg">SubCode description</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>201</para>
        /// </summary>
        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        /// <summary>
        /// <para>Comma-separated result codes. For more information about valid values, see <a href="https://www.alibabacloud.com/help/en/id-verification/financial-grade-id-verification/error-code-person-verify#d88910e172fgg">SubCode description</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>201,202</para>
        /// </summary>
        [NameInMap("SubCodes")]
        [Validation(Required=false)]
        public string SubCodes { get; set; }

        /// <summary>
        /// <para>Specifies whether virtual video adaptation is used. Set this parameter to 1 if selected. Otherwise, do not pass this parameter. This corresponds to the behavior tag risk type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("VirtualVideo")]
        [Validation(Required=false)]
        public int? VirtualVideo { get; set; }

    }

}
