// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeVerifySearchPageListRequest : TeaModel {
        /// <summary>
        /// <para>ID number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3203212000XXXX701X</para>
        /// </summary>
        [NameInMap("CertNo")]
        [Validation(Required=false)]
        public string CertNo { get; set; }

        /// <summary>
        /// <para>Authentication ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>shadbdd3dbacd001cfa892a5e2b98dxx</para>
        /// </summary>
        [NameInMap("CertifyId")]
        [Validation(Required=false)]
        public string CertifyId { get; set; }

        /// <summary>
        /// <para>Current page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>End date of the query. The format is a Unix timestamp, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-10-16 23:59:59 +0800</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>Whether there is device risk (pass true if root = 1 or simulator = 1 or virtual_video = 1).</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasDeviceRisk")]
        [Validation(Required=false)]
        public bool? HasDeviceRisk { get; set; }

        /// <summary>
        /// <para>Liveness detection model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LIVENESS</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>Unique identifier for the customer request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a77f5ac40a5aa5e6ed20c353888</para>
        /// </summary>
        [NameInMap("OuterOrderNo")]
        [Validation(Required=false)]
        public string OuterOrderNo { get; set; }

        /// <summary>
        /// <para>Number of items per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>Whether the authentication passed:</para>
        /// <list type="bullet">
        /// <item><description><b>T</b>: Passed</description></item>
        /// <item><description><b>F</b>: Not passed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>F</para>
        /// </summary>
        [NameInMap("Passed")]
        [Validation(Required=false)]
        public string Passed { get; set; }

        /// <summary>
        /// <para>Product code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ID_PRO</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("RiskBizScenario")]
        [Validation(Required=false)]
        public int? RiskBizScenario { get; set; }

        [NameInMap("RiskDevice")]
        [Validation(Required=false)]
        public int? RiskDevice { get; set; }

        [NameInMap("RiskDeviceToken")]
        [Validation(Required=false)]
        public int? RiskDeviceToken { get; set; }

        [NameInMap("RiskGeneric")]
        [Validation(Required=false)]
        public int? RiskGeneric { get; set; }

        [NameInMap("RiskModelMining")]
        [Validation(Required=false)]
        public int? RiskModelMining { get; set; }

        /// <summary>
        /// <para>Whether it is rooted (pass 1 if selected, otherwise do not pass; corresponds to identity label risk type).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Root")]
        [Validation(Required=false)]
        public int? Root { get; set; }

        /// <summary>
        /// <para>Scene ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000072xx</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

        /// <summary>
        /// <para>Whether it is a simulator (pass 1 if selected, otherwise do not pass; corresponds to device label risk type).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Simulator")]
        [Validation(Required=false)]
        public int? Simulator { get; set; }

        /// <summary>
        /// <para>Start date of the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-10-10 00:00:00 +0800</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>Result Code. For detailed values, please refer to: <a href="https://help.aliyun.com/zh/id-verification/financial-grade-id-verification/error-code-person-verify?spm=a2c4g.11186623.0.0.6015566ebArcFw#d88910e172fgg">SubCode Explanation</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>201</para>
        /// </summary>
        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        /// <summary>
        /// <para>Comma-separated Result Codes. For detailed values, please refer to: <a href="https://help.aliyun.com/zh/id-verification/financial-grade-id-verification/error-code-person-verify?spm=a2c4g.11186623.0.0.6015566ebArcFw#d88910e172fgg">SubCode Explanation</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>201,202</para>
        /// </summary>
        [NameInMap("SubCodes")]
        [Validation(Required=false)]
        public string SubCodes { get; set; }

        /// <summary>
        /// <para>Whether it is a virtual adaptation (pass 1 if selected, otherwise do not pass; corresponds to behavior label risk type).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("VirtualVideo")]
        [Validation(Required=false)]
        public int? VirtualVideo { get; set; }

    }

}
