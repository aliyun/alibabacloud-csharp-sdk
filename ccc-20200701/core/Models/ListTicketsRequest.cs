// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListTicketsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>assignee@cccV2-kmz</para>
        /// </summary>
        [NameInMap("Assignee")]
        [Validation(Required=false)]
        public string Assignee { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Agent</para>
        /// </summary>
        [NameInMap("AssigneeType")]
        [Validation(Required=false)]
        public string AssigneeType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>43c2671b-****-4223-86d0-6bd187905cc8</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>creator@cccV2-kmz</para>
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>51e155ce-3747-*****-b402-13c69597b920</para>
        /// </summary>
        [NameInMap("CustomerId")]
        [Validation(Required=false)]
        public string CustomerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1646928000000</para>
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
        /// <para>[&quot;job-12******&quot;,&quot;job-23****&quot;]</para>
        /// </summary>
        [NameInMap("JobIdList")]
        [Validation(Required=false)]
        public string JobIdList { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>participant@cccV2-kmz</para>
        /// </summary>
        [NameInMap("Participant")]
        [Validation(Required=false)]
        public string Participant { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1646841600000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Processing</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5491d3b4-14ee-4341-b5f1-db2c78beddeb</para>
        /// </summary>
        [NameInMap("TicketId")]
        [Validation(Required=false)]
        public string TicketId { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
