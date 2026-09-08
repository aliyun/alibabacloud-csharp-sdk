// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListCallDetailRecordsRequest : TeaModel {
        /// <summary>
        /// <para>Filter by agent ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent@ccc-test</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>Filter by called number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1320523****</para>
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        /// <summary>
        /// <para>Filter by calling number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>07353988****</para>
        /// </summary>
        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public string CallingNumber { get; set; }

        /// <summary>
        /// <para>Filter by disposition type. Note: Disposition reasons such as voicemail, transfer to agent failed, queuing timeout, queuing overflow, and IVR abnormal are only displayed if the customer has configured a disposition reason node. If no such node is configured and there is no transfer-to-agent module in the IVR, the disposition reason defaults to &quot;Abandoned in IVR&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("ContactDisposition")]
        [Validation(Required=false)]
        public string ContactDisposition { get; set; }

        /// <summary>
        /// <para>Filter by hang-up reason list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;Success&quot;,&quot;NoAnswer&quot;]</para>
        /// </summary>
        [NameInMap("ContactDispositionList")]
        [Validation(Required=false)]
        public string ContactDispositionList { get; set; }

        /// <summary>
        /// <para>Query the record of a specific call by specifying a contactId. The contactId can be obtained from the softphone software development kit (SDK) during a call. If this parameter is provided, all other query parameters are automatically ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job-12515239414412****</para>
        /// </summary>
        [NameInMap("ContactId")]
        [Validation(Required=false)]
        public string ContactId { get; set; }

        /// <summary>
        /// <para>Filter by call type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Outbound</para>
        /// </summary>
        [NameInMap("ContactType")]
        [Validation(Required=false)]
        public string ContactType { get; set; }

        /// <summary>
        /// <para>Filter by contact type list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;Internal&quot;,&quot;Inbound&quot;]</para>
        /// </summary>
        [NameInMap("ContactTypeList")]
        [Validation(Required=false)]
        public string ContactTypeList { get; set; }

        /// <summary>
        /// <para>Perform a fuzzy query based on the calling or called number. The value must be a JSON string containing only one field, phoneNumber, which can be the full number or a partial segment of either the calling or called number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;phoneNumber&quot;:&quot;0735&quot;}</para>
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// <para>Filter by a list of reasons for failed connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;NotConnected&quot;,&quot;NoAnswer&quot;]</para>
        /// </summary>
        [NameInMap("EarlyMediaStateList")]
        [Validation(Required=false)]
        public string EarlyMediaStateList { get; set; }

        /// <summary>
        /// <para>End time of the historical data to retrieve. The default value is the current time, in UNIX timestamp format with millisecond precision.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1532707199000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Sorting field. Optional. Default value is startTime (call start time).</para>
        /// 
        /// <b>Example:</b>
        /// <para>startTime</para>
        /// </summary>
        [NameInMap("OrderByField")]
        [Validation(Required=false)]
        public string OrderByField { get; set; }

        /// <summary>
        /// <para>Page number for paging, ranging from 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size, ranging from 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Filter by satisfaction description list. The description content is Custom by the Customer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;满意&quot;,&quot;一般&quot;]</para>
        /// </summary>
        [NameInMap("SatisfactionDescriptionList")]
        [Validation(Required=false)]
        public string SatisfactionDescriptionList { get; set; }

        /// <summary>
        /// <para>Filter by satisfaction List. Separate multiple satisfaction Results with commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;1&quot;,&quot;3&quot;]</para>
        /// </summary>
        [NameInMap("SatisfactionList")]
        [Validation(Required=false)]
        public string SatisfactionList { get; set; }

        /// <summary>
        /// <para>Filter by satisfaction survey channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IVR</para>
        /// </summary>
        [NameInMap("SatisfactionSurveyChannel")]
        [Validation(Required=false)]
        public string SatisfactionSurveyChannel { get; set; }

        /// <summary>
        /// <para>Filter by skill group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>skillgroup@ccc-test</para>
        /// </summary>
        [NameInMap("SkillGroupId")]
        [Validation(Required=false)]
        public string SkillGroupId { get; set; }

        /// <summary>
        /// <para>Sorting order. This parameter is optional and defaults to descending.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        /// <summary>
        /// <para>Start time of the historical data to retrieve. The default value is 00:00:00 of the current day, in UNIX timestamp format with millisecond precision.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1532448000000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
