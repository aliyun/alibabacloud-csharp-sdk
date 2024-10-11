// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListCallDetailRecordsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>agent@ccc-test</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1320523****</para>
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>07353988****</para>
        /// </summary>
        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public string CallingNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("ContactDisposition")]
        [Validation(Required=false)]
        public string ContactDisposition { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;Success&quot;,&quot;NoAnswer&quot;]</para>
        /// </summary>
        [NameInMap("ContactDispositionList")]
        [Validation(Required=false)]
        public string ContactDispositionList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>job-12515239414412****</para>
        /// </summary>
        [NameInMap("ContactId")]
        [Validation(Required=false)]
        public string ContactId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Outbound</para>
        /// </summary>
        [NameInMap("ContactType")]
        [Validation(Required=false)]
        public string ContactType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;Internal&quot;,&quot;Inbound&quot;]</para>
        /// </summary>
        [NameInMap("ContactTypeList")]
        [Validation(Required=false)]
        public string ContactTypeList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;phoneNumber&quot;:&quot;0735&quot;}</para>
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;NotConnected&quot;,&quot;NoAnswer&quot;]</para>
        /// </summary>
        [NameInMap("EarlyMediaStateList")]
        [Validation(Required=false)]
        public string EarlyMediaStateList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1532707199000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>startTime</para>
        /// </summary>
        [NameInMap("OrderByField")]
        [Validation(Required=false)]
        public string OrderByField { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("SatisfactionDescriptionList")]
        [Validation(Required=false)]
        public string SatisfactionDescriptionList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;1&quot;,&quot;3&quot;]</para>
        /// </summary>
        [NameInMap("SatisfactionList")]
        [Validation(Required=false)]
        public string SatisfactionList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>IVR</para>
        /// </summary>
        [NameInMap("SatisfactionSurveyChannel")]
        [Validation(Required=false)]
        public string SatisfactionSurveyChannel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>skillgroup@ccc-test</para>
        /// </summary>
        [NameInMap("SkillGroupId")]
        [Validation(Required=false)]
        public string SkillGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1532448000000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
