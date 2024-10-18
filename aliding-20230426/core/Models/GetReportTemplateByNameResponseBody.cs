// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetReportTemplateByNameResponseBody : TeaModel {
        [NameInMap("defaultReceivedConvs")]
        [Validation(Required=false)]
        public List<GetReportTemplateByNameResponseBodyDefaultReceivedConvs> DefaultReceivedConvs { get; set; }
        public class GetReportTemplateByNameResponseBodyDefaultReceivedConvs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cid12334##2341</para>
            /// </summary>
            [NameInMap("ConversationId")]
            [Validation(Required=false)]
            public string ConversationId { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("defaultReceivers")]
        [Validation(Required=false)]
        public List<GetReportTemplateByNameResponseBodyDefaultReceivers> DefaultReceivers { get; set; }
        public class GetReportTemplateByNameResponseBodyDefaultReceivers : TeaModel {
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("Userid")]
            [Validation(Required=false)]
            public string Userid { get; set; }

        }

        [NameInMap("fields")]
        [Validation(Required=false)]
        public List<GetReportTemplateByNameResponseBodyFields> Fields { get; set; }
        public class GetReportTemplateByNameResponseBodyFields : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>key1</para>
            /// </summary>
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Sort")]
            [Validation(Required=false)]
            public long? Sort { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public long? Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>11111</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("userid")]
        [Validation(Required=false)]
        public string Userid { get; set; }

    }

}
