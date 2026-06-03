// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class GetLogListRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-06-06 00:00:00</para>
        /// </summary>
        [NameInMap("BeginDate")]
        [Validation(Required=false)]
        public string BeginDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>111.164.XX.XX</para>
        /// </summary>
        [NameInMap("ClientIpList")]
        [Validation(Required=false)]
        public List<string> ClientIpList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>navicat</para>
        /// </summary>
        [NameInMap("ClientProgramList")]
        [Validation(Required=false)]
        public List<string> ClientProgramList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("DbHostList")]
        [Validation(Required=false)]
        public List<string> DbHostList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DbId")]
        [Validation(Required=false)]
        public int? DbId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>root</para>
        /// </summary>
        [NameInMap("DbUserList")]
        [Validation(Required=false)]
        public List<string> DbUserList { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-06-06 23:59:59</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbaudit-cn-78v1gc****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public string IsSuccess { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MaxAffectRows")]
        [Validation(Required=false)]
        public int? MaxAffectRows { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20000</para>
        /// </summary>
        [NameInMap("MaxExecCostUS")]
        [Validation(Required=false)]
        public int? MaxExecCostUS { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MinAffectRows")]
        [Validation(Required=false)]
        public int? MinAffectRows { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MinExecCostUS")]
        [Validation(Required=false)]
        public int? MinExecCostUS { get; set; }

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
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RiskLevelList")]
        [Validation(Required=false)]
        public List<string> RiskLevelList { get; set; }

        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("RuleTypeList")]
        [Validation(Required=false)]
        public List<string> RuleTypeList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3011610850021000000</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1907181552270011186</para>
        /// </summary>
        [NameInMap("SqlId")]
        [Validation(Required=false)]
        public string SqlId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>select</para>
        /// </summary>
        [NameInMap("SqlKey")]
        [Validation(Required=false)]
        public string SqlKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("SqlTypeList")]
        [Validation(Required=false)]
        public List<string> SqlTypeList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
