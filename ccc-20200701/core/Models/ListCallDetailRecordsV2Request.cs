// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListCallDetailRecordsV2Request : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;Web&quot;,&quot;AliMe&quot;]</para>
        /// </summary>
        [NameInMap("AccessChannelTypeList")]
        [Validation(Required=false)]
        public string AccessChannelTypeList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>agent@ccc-test</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        [NameInMap("AnalyticsReportReady")]
        [Validation(Required=false)]
        public bool? AnalyticsReportReady { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>021****4972</para>
        /// </summary>
        [NameInMap("Broker")]
        [Validation(Required=false)]
        public string Broker { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>191***9993</para>
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>191***9993</para>
        /// </summary>
        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public string CallingNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;Success&quot;,&quot;NoAnswer&quot;]</para>
        /// </summary>
        [NameInMap("ContactDispositionList")]
        [Validation(Required=false)]
        public string ContactDispositionList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;job-123456789&quot;,&quot;job-234567891&quot;]</para>
        /// </summary>
        [NameInMap("ContactIdList")]
        [Validation(Required=false)]
        public string ContactIdList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;INBOUND&quot;,&quot;OUTBOUND&quot;]</para>
        /// </summary>
        [NameInMap("ContactTypeList")]
        [Validation(Required=false)]
        public string ContactTypeList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;NotConnected&quot;,&quot;NoAnswer&quot;]</para>
        /// </summary>
        [NameInMap("EarlyMediaStateList")]
        [Validation(Required=false)]
        public string EarlyMediaStateList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1657879880010</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>agent@ccc-test</para>
        /// </summary>
        [NameInMap("FirstAgentId")]
        [Validation(Required=false)]
        public string FirstAgentId { get; set; }

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
        /// <para>AUDIO</para>
        /// </summary>
        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public string MediaType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>191***9993</para>
        /// </summary>
        [NameInMap("Number")]
        [Validation(Required=false)]
        public string Number { get; set; }

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

        [NameInMap("ReleaseInitiatorList")]
        [Validation(Required=false)]
        public string ReleaseInitiatorList { get; set; }

        [NameInMap("ReleaseReasonList")]
        [Validation(Required=false)]
        public string ReleaseReasonList { get; set; }

        [NameInMap("SatisfactionDescriptionList")]
        [Validation(Required=false)]
        public string SatisfactionDescriptionList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;1&quot;,&quot;3&quot;]</para>
        /// </summary>
        [NameInMap("SatisfactionRateList")]
        [Validation(Required=false)]
        public string SatisfactionRateList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>IVR</para>
        /// </summary>
        [NameInMap("SatisfactionSurveyChannel")]
        [Validation(Required=false)]
        public string SatisfactionSurveyChannel { get; set; }

        [NameInMap("SearchPattern")]
        [Validation(Required=false)]
        public string SearchPattern { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[
        ///       &quot;skg1@ccc-test&quot;,
        ///       &quot;skg2@ccc-test&quot;
        /// ]</para>
        /// </summary>
        [NameInMap("SkillGroupIdList")]
        [Validation(Required=false)]
        public string SkillGroupIdList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1657853640015</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
