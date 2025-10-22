// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Companyreg20200306.Models
{
    public class RecordCallCenterEventForPartnerRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>P20211117141528000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>esp.beian_assist</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MakeCall</para>
        /// </summary>
        [NameInMap("CallAction")]
        [Validation(Required=false)]
        public string CallAction { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>18578602216</para>
        /// </summary>
        [NameInMap("Callee")]
        [Validation(Required=false)]
        public string Callee { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>13162828888</para>
        /// </summary>
        [NameInMap("Caller")]
        [Validation(Required=false)]
        public string Caller { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12313</para>
        /// </summary>
        [NameInMap("ConnId")]
        [Validation(Required=false)]
        public string ConnId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>897265</para>
        /// </summary>
        [NameInMap("ContactId")]
        [Validation(Required=false)]
        public string ContactId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ufbo502ma94m480</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>RequestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000030990004</para>
        /// </summary>
        [NameInMap("RelatedId")]
        [Validation(Required=false)]
        public long? RelatedId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MTAFA/DF#</para>
        /// </summary>
        [NameInMap("SecretMobile")]
        [Validation(Required=false)]
        public string SecretMobile { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SkillType")]
        [Validation(Required=false)]
        public int? SkillType { get; set; }

    }

}
