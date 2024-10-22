// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListProjectsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListProjectsResponseBodyData> Data { get; set; }
        public class ListProjectsResponseBodyData : TeaModel {
            [NameInMap("AccessPageId")]
            [Validation(Required=false)]
            public List<long?> AccessPageId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3174301</para>
            /// </summary>
            [NameInMap("AvailableHours")]
            [Validation(Required=false)]
            public int? AvailableHours { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>c-06vcpamarryyq****</para>
            /// </summary>
            [NameInMap("ContentId")]
            [Validation(Required=false)]
            public string ContentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>notepad++***</para>
            /// </summary>
            [NameInMap("ContentName")]
            [Validation(Required=false)]
            public string ContentName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1701141509000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("InUseSessions")]
            [Validation(Required=false)]
            public long? InUseSessions { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("MaxHours")]
            [Validation(Required=false)]
            public long? MaxHours { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("MaxSessions")]
            [Validation(Required=false)]
            public long? MaxSessions { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>p-065z4tu9ak07h****</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>notepad++***</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ProjectState")]
            [Validation(Required=false)]
            public string ProjectState { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>appstreaming.general.basic</para>
            /// </summary>
            [NameInMap("SessionSpec")]
            [Validation(Required=false)]
            public string SessionSpec { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>There is a missing parameter.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
