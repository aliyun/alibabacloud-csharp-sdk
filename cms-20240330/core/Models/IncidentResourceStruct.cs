// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentResourceStruct : TeaModel {
        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Production web server</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The incident ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>incident-001</para>
        /// </summary>
        [NameInMap("incidentId")]
        [Validation(Required=false)]
        public string IncidentId { get; set; }

        /// <summary>
        /// <para>The unique ID of the resource in the incident.</para>
        /// 
        /// <b>Example:</b>
        /// <para>res-001</para>
        /// </summary>
        [NameInMap("incidentResourceId")]
        [Validation(Required=false)]
        public string IncidentResourceId { get; set; }

        /// <summary>
        /// <para>The incident resource details object.</para>
        /// </summary>
        [NameInMap("resource")]
        [Validation(Required=false)]
        public IncidentResourceDetail Resource { get; set; }

        /// <summary>
        /// <para>The source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloudmonitor</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1741234567890</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public long? Time { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

    }

}
