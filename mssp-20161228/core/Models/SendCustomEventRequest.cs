// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mssp20161228.Models
{
    public class SendCustomEventRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1214484929940219</para>
        /// </summary>
        [NameInMap("CustomerId")]
        [Validation(Required=false)]
        public string CustomerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>aegis_suspicious_event</para>
        /// </summary>
        [NameInMap("DataSource")]
        [Validation(Required=false)]
        public string DataSource { get; set; }

        [NameInMap("EventDescription")]
        [Validation(Required=false)]
        public string EventDescription { get; set; }

        [NameInMap("EventDetails")]
        [Validation(Required=false)]
        public string EventDetails { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUSP_CUSTOM_CFW</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-23 14:47:34</para>
        /// </summary>
        [NameInMap("FindTime")]
        [Validation(Required=false)]
        public long? FindTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>i-uf60h3ns25bzq9eyf8ps</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IsSend")]
        [Validation(Required=false)]
        public string IsSend { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>serious</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1724956996000</para>
        /// </summary>
        [NameInMap("OccurrenceTime")]
        [Validation(Required=false)]
        public long? OccurrenceTime { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CloudSecCenter</para>
        /// </summary>
        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68888f02-98f2-492b-a2b2-5b13295755b7</para>
        /// </summary>
        [NameInMap("UniqueId")]
        [Validation(Required=false)]
        public string UniqueId { get; set; }

        /// <summary>
        /// <para>UUID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>93B6CDAB-7D2E-33D2-9EBA-25D561A2E95F</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
