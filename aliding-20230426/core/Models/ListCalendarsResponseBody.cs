// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class ListCalendarsResponseBody : TeaModel {
        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("response")]
        [Validation(Required=false)]
        public ListCalendarsResponseBodyResponse Response { get; set; }
        public class ListCalendarsResponseBodyResponse : TeaModel {
            [NameInMap("Calendars")]
            [Validation(Required=false)]
            public List<ListCalendarsResponseBodyResponseCalendars> Calendars { get; set; }
            public class ListCalendarsResponseBodyResponseCalendars : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>描述</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ETag")]
                [Validation(Required=false)]
                public string ETag { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cnNTbWxxx</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>VIEW_DETAIL</para>
                /// </summary>
                [NameInMap("Privilege")]
                [Validation(Required=false)]
                public string Privilege { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>标题</para>
                /// </summary>
                [NameInMap("Summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Asia/Shanghai</para>
                /// </summary>
                [NameInMap("TimeZone")]
                [Validation(Required=false)]
                public string TimeZone { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>primary</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

    }

}
