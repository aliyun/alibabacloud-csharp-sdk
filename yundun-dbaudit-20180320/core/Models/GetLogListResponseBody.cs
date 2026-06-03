// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class GetLogListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2019-06-06 00:00:00</para>
        /// </summary>
        [NameInMap("BeginDate")]
        [Validation(Required=false)]
        public string BeginDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2019-06-06 23:59:59</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Incomplete")]
        [Validation(Required=false)]
        public string Incomplete { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1B217656-2267-4FBF-B26C-CDD201BDC3B8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<GetLogListResponseBodyResults> Results { get; set; }
        public class GetLogListResponseBodyResults : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("AffectRows")]
            [Validation(Required=false)]
            public int? AffectRows { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8.8.XX.XX</para>
            /// </summary>
            [NameInMap("AppClientIp")]
            [Validation(Required=false)]
            public string AppClientIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>zhangsan</para>
            /// </summary>
            [NameInMap("AppUsername")]
            [Validation(Required=false)]
            public string AppUsername { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2019-06-06 00:00:00</para>
            /// </summary>
            [NameInMap("CaptureTime")]
            [Validation(Required=false)]
            public string CaptureTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            [NameInMap("ClientIpAlias")]
            [Validation(Required=false)]
            public string ClientIpAlias { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>00163E06****</para>
            /// </summary>
            [NameInMap("ClientMac")]
            [Validation(Required=false)]
            public string ClientMac { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>administrator</para>
            /// </summary>
            [NameInMap("ClientOsUser")]
            [Validation(Required=false)]
            public string ClientOsUser { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>15629</para>
            /// </summary>
            [NameInMap("ClientPort")]
            [Validation(Required=false)]
            public int? ClientPort { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>navicat</para>
            /// </summary>
            [NameInMap("ClientProgram")]
            [Validation(Required=false)]
            public string ClientProgram { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DbId")]
            [Validation(Required=false)]
            public int? DbId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>192.168.XX.XX:3306</para>
            /// </summary>
            [NameInMap("DbServer")]
            [Validation(Required=false)]
            public string DbServer { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>root</para>
            /// </summary>
            [NameInMap("DbUser")]
            [Validation(Required=false)]
            public string DbUser { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("ExecCostUS")]
            [Validation(Required=false)]
            public int? ExecCostUS { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("FetchCostUS")]
            [Validation(Required=false)]
            public int? FetchCostUS { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>orcl</para>
            /// </summary>
            [NameInMap("InstName")]
            [Validation(Required=false)]
            public string InstName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ResponseCode")]
            [Validation(Required=false)]
            public string ResponseCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Table \&quot;your_table\&quot; doesn\&quot;t exist</para>
            /// </summary>
            [NameInMap("ResponseText")]
            [Validation(Required=false)]
            public string ResponseText { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public int? RiskLevel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50****</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public int? RuleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50****</para>
            /// </summary>
            [NameInMap("RuleKeyId")]
            [Validation(Required=false)]
            public int? RuleKeyId { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public int? RuleType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>db_test</para>
            /// </summary>
            [NameInMap("Schema")]
            [Validation(Required=false)]
            public string Schema { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>00163E06****</para>
            /// </summary>
            [NameInMap("ServerMac")]
            [Validation(Required=false)]
            public string ServerMac { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3011610850021000000</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2019-06-06 00:00:00</para>
            /// </summary>
            [NameInMap("SessionLoginTime")]
            [Validation(Required=false)]
            public string SessionLoginTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2019-06-06 00:00:00</para>
            /// </summary>
            [NameInMap("SessionLogoutTime")]
            [Validation(Required=false)]
            public string SessionLogoutTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>select * from ****</para>
            /// </summary>
            [NameInMap("SqlContent")]
            [Validation(Required=false)]
            public string SqlContent { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1907181552270011186</para>
            /// </summary>
            [NameInMap("SqlId")]
            [Validation(Required=false)]
            public string SqlId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("SqlType")]
            [Validation(Required=false)]
            public string SqlType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000****</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
