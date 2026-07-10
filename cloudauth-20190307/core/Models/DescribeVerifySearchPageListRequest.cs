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
        /// <para>The certification ID.</para>
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
        /// <para>The query end time. The format is a Unix timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-10-16 23:59:59 +0800</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>Specifies whether there is a device risk. Setting this parameter to true indicates that root = 1, simulator = 1, or virtual_video = 1.</para>
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
        /// <para>The unique identifier for the customer request.</para>
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
        /// <para>Specifies whether the authentication passed:</para>
        /// <list type="bullet">
        /// <item><description><b>T</b>: Passed.</description></item>
        /// <item><description><b>F</b>: Failed.</description></item>
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
        /// <para>The business scenario risk:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: No risk.</description></item>
        /// <item><description><b>1</b>: Risk detected.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RiskBizScenario")]
        [Validation(Required=false)]
        public int? RiskBizScenario { get; set; }

        /// <summary>
        /// <para>The device risk:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: No risk.</description></item>
        /// <item><description><b>1</b>: Risk detected.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RiskDevice")]
        [Validation(Required=false)]
        public int? RiskDevice { get; set; }

        /// <summary>
        /// <para>The DeviceToken risk:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: No risk.</description></item>
        /// <item><description><b>1</b>: Risk detected.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RiskDeviceToken")]
        [Validation(Required=false)]
        public int? RiskDeviceToken { get; set; }

        /// <summary>
        /// <para>The generic risk:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: No risk.</description></item>
        /// <item><description><b>1</b>: Risk detected.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RiskGeneric")]
        [Validation(Required=false)]
        public int? RiskGeneric { get; set; }

        /// <summary>
        /// <para>The large model mining risk:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: No risk.</description></item>
        /// <item><description><b>1</b>: Risk detected.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RiskModelMining")]
        [Validation(Required=false)]
        public int? RiskModelMining { get; set; }

        /// <summary>
        /// <para>Specifies whether the device is rooted. Set to 1 if selected; otherwise, do not pass this parameter. This parameter corresponds to the identity tag risk type.</para>
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
        /// <para>Specifies whether the device is a simulator. Set to 1 if selected; otherwise, do not pass this parameter. This parameter corresponds to the device tag risk type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Simulator")]
        [Validation(Required=false)]
        public int? Simulator { get; set; }

        /// <summary>
        /// <para>The query start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-10-10 00:00:00 +0800</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The result code. For details, see <a href="https://help.aliyun.com/zh/id-verification/financial-grade-id-verification/error-code-person-verify?spm=a2c4g.11186623.0.0.6015566ebArcFw#d88910e172fgg">SubCode Description</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>201</para>
        /// </summary>
        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        /// <summary>
        /// <para>Comma-separated result codes. For details, see <a href="https://help.aliyun.com/zh/id-verification/financial-grade-id-verification/error-code-person-verify?spm=a2c4g.11186623.0.0.6015566ebArcFw#d88910e172fgg">SubCode Description</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>201,202</para>
        /// </summary>
        [NameInMap("SubCodes")]
        [Validation(Required=false)]
        public string SubCodes { get; set; }

        /// <summary>
        /// <para>Specifies whether virtual video is used. Set to 1 if selected; otherwise, do not pass this parameter. This parameter corresponds to the behavior tag risk type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("VirtualVideo")]
        [Validation(Required=false)]
        public int? VirtualVideo { get; set; }

    }

}
