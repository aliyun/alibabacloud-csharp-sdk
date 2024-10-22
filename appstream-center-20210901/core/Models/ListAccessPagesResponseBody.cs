// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListAccessPagesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public string Count { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAccessPagesResponseBodyData> Data { get; set; }
        public class ListAccessPagesResponseBodyData : TeaModel {
            [NameInMap("AccessMode")]
            [Validation(Required=false)]
            public string AccessMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>a-062wec3cwmayw****</para>
            /// </summary>
            [NameInMap("AccessPageId")]
            [Validation(Required=false)]
            public string AccessPageId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>notepad_test</para>
            /// </summary>
            [NameInMap("AccessPageName")]
            [Validation(Required=false)]
            public string AccessPageName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AccessPageState")]
            [Validation(Required=false)]
            public string AccessPageState { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>id=a-062wec3cwmayw****&amp;token=9E9A62937B0E41F4AEFE5EC9B238156CCDFB682954003AEE940A05FB2568****</para>
            /// </summary>
            [NameInMap("AccessUrl")]
            [Validation(Required=false)]
            public string AccessUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>c-05to6wm3w5d53****</para>
            /// </summary>
            [NameInMap("ContentId")]
            [Validation(Required=false)]
            public string ContentId { get; set; }

            [NameInMap("ContentName")]
            [Validation(Required=false)]
            public string ContentName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>168</para>
            /// </summary>
            [NameInMap("EffectTime")]
            [Validation(Required=false)]
            public int? EffectTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-11-16T08:48:15.000+00:00</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>p-062wec3cwmayu****</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>notepad_demo</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Hour</para>
            /// </summary>
            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-11-23T08:48:15.000+00:00</para>
            /// </summary>
            [NameInMap("UrlExpireTime")]
            [Validation(Required=false)]
            public string UrlExpireTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>InternalError</para>
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
        public string PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AF8361BD-5ECB-139A-B019-2E0350CC****</para>
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

    }

}
