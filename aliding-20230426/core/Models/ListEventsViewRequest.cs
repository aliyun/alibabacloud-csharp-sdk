// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class ListEventsViewRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>primary</para>
        /// </summary>
        [NameInMap("CalendarId")]
        [Validation(Required=false)]
        public string CalendarId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxAttendees")]
        [Validation(Required=false)]
        public int? MaxAttendees { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cnNTbW1xxx</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-11-28T00:00:00+08:00</para>
        /// </summary>
        [NameInMap("TimeMax")]
        [Validation(Required=false)]
        public string TimeMax { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-11-27T00:00:00+08:00</para>
        /// </summary>
        [NameInMap("TimeMin")]
        [Validation(Required=false)]
        public string TimeMin { get; set; }

    }

}
