// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class ListApplicationResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[{}]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListApplicationResponseBodyData> Data { get; set; }
        public class ListApplicationResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;ODIN_TOPIC_ID\&quot;:\&quot;256\&quot;}</para>
            /// </summary>
            [NameInMap("AppConfig")]
            [Validation(Required=false)]
            public string AppConfig { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>APP_XCxxx</para>
            /// </summary>
            [NameInMap("AppType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ONLINE</para>
            /// </summary>
            [NameInMap("ApplicationStatus")]
            [Validation(Required=false)]
            public string ApplicationStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ding5xxx</para>
            /// </summary>
            [NameInMap("CorpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("CreatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>小明创建的宜搭应用</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>appdiqiu%%#0089FF</para>
            /// </summary>
            [NameInMap("Icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>y</para>
            /// </summary>
            [NameInMap("Inexistence")]
            [Validation(Required=false)]
            public string Inexistence { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>app</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ding5xxx</para>
            /// </summary>
            [NameInMap("SubCorpId")]
            [Validation(Required=false)]
            public string SubCorpId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dingtalk</para>
        /// </summary>
        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
