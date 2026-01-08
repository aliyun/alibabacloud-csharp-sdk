// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListBindDmAccountResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListBindDmAccountResponseBodyData> Data { get; set; }
        public class ListBindDmAccountResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:xx@xx.com">xx@xx.com</a></para>
            /// </summary>
            [NameInMap("AccountCode")]
            [Validation(Required=false)]
            public string AccountCode { get; set; }

            [NameInMap("ExtendAttr")]
            [Validation(Required=false)]
            public ListBindDmAccountResponseBodyDataExtendAttr ExtendAttr { get; set; }
            public class ListBindDmAccountResponseBodyDataExtendAttr : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="mailto:xx@xx.com">xx@xx.com</a></para>
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>batch</para>
                /// </summary>
                [NameInMap("SendType")]
                [Validation(Required=false)]
                public string SendType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cams-*</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ins</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx-xx**</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
