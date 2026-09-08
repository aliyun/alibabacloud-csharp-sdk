// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class CreateTicketRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job-38860977107324****</para>
        /// </summary>
        [NameInMap("ContactId")]
        [Validation(Required=false)]
        public string ContactId { get; set; }

        /// <summary>
        /// <para>Ticket field information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;productName&quot;:&quot;玩具1&quot;}</para>
        /// </summary>
        [NameInMap("Context")]
        [Validation(Required=false)]
        public string Context { get; set; }

        /// <summary>
        /// <para>Customer ID, the customer ID in Cloud Contact Center customer profiles.</para>
        /// 
        /// <b>Example:</b>
        /// <para>51e155ce-3747-4f21-b402-13c69597b920</para>
        /// </summary>
        [NameInMap("CustomerId")]
        [Validation(Required=false)]
        public string CustomerId { get; set; }

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
        /// <para>Ticket source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CHAT</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>Ticket template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e9e4c76c-948d-4a6e-9ce2-9da0f5967a73</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>Ticket title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>售后工单。</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
